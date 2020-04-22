using System;
using System.Reflection;
using System.Windows.Forms;
using CRMCore.Entities;

namespace CRMCore.Patterns
{
    public partial class PatternEntityForm<TEntity> : PatternForm
        where TEntity : class, IViewEntity, new()
    {
        public TEntity entity;
        public EntityFormMode mode;

        public PatternEntityForm(EntityFormMode mode, TEntity entity = null)
        {
            InitializeComponent();
            Text = mode.ToString() + " " + typeof(TEntity).GetName();
            this.entity = entity;
            this.mode = mode;
            if (mode == EntityFormMode.Add)
                entity = null;
            var consts = new { Anchor = AnchorStyles.Left | AnchorStyles.Right, i = 0 };
            int i = 0;
            foreach (var p in typeof(TEntity).GetProperties())
            {
                if (p.PropertyType == typeof(bool))
                {
                    table.Controls.Add(new CheckBox()
                    {
                        Text = p.GetName(),
                        Name = p.Name,
                        Anchor = consts.Anchor,
                        Checked = GetValue(p) is bool b && b
                    }, 0, i++);
                }
                else
                {
                    table.Controls.Add(new Label()
                    {
                        Text = p.GetName() + ":",
                        Anchor = consts.Anchor,
                    }, 0, i++);
                    if (false)
                    {

                    }
                    else
                    {
                        table.Controls.Add(new RichTextBox()
                        {
                            Name = p.Name,
                            Anchor = consts.Anchor,
                            Text = GetValue(p).ToString()
                        });
                    }
                }
            }

            object GetValue(PropertyInfo p)
            {
                return (entity?.EnitiesViewProperties?.ContainsKey(p.Name) ?? false) ? entity.EnitiesViewProperties[p.Name].getFormatedToView.Invoke() : 
            }
        }

        public static implicit operator PatternEntityForm<TEntity>((EntityFormMode mode, TEntity entity) input)
        {
            return new PatternEntityForm<TEntity>(input.mode, input.entity);
        }

        public static implicit operator PatternEntityForm<TEntity>(EntityFormMode mode)
        {
            return new PatternEntityForm<TEntity>(mode);
        }

        /// <summary>
        /// Fills user controls with data from the param entity
        /// </summary>
        /// <param name="entity"></param>
        protected virtual void UnpackEntity()
        {

        }

        /// <summary>
        /// Checks input data from user controls and creates new entity from it
        /// </summary>
        /// <returns></returns>
        protected virtual bool PackEntity()
        {
            return true;
        }

        private void GenerateControls()
        {

        }

        /// <summary>
        /// Cansels packing of new entity.
        /// </summary>
        /// <param name="reason"> A messege which contains the reason of canseling </param>
        /// <returns></returns>
        protected virtual bool StopPackingEntity(string reason)
        {
            MessageBox.Show(reason, "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (PackEntity())
            {
                forceClosing = true;
                Close();
            }
        }

        private void PatternEntityForm_Load(object sender, EventArgs e)
        {
            if (mode != EntityFormMode.Add)
                UnpackEntity();
            if (mode == EntityFormMode.Observe)
                buttonConfirm.Visible = false;
        }
    }
}
