using System;
using System.Windows.Forms;

namespace CRMCore.Patterns
{
    abstract public partial class PatternEntityForm<TEntity> : PatternForm where TEntity : class, new()
    {
        public TEntity entity;
        public EntityFormMode mode;

        protected PatternEntityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fills user controls with data from the param entity
        /// </summary>
        /// <param name="entity"></param>
        protected abstract void UnpackEntity();

        /// <summary>
        /// Checks input data from user controls and creates new entity from it
        /// </summary>
        /// <returns></returns>
        protected abstract bool PackEntity();

        /// <summary>
        /// Cansels packing of new entity.
        /// </summary>
        /// <param name="reason"> A messege which contains the reason of canseling </param>
        /// <returns></returns>

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
            Text = mode.ToString() + typeof(TEntity).Name.ToLower();
            switch (mode)
            {
                case EntityFormMode.Edit:
                    UnpackEntity();
                    break;
                case EntityFormMode.Observe:
                    buttonConfirm.Visible = false;
                    break;
            }
        }
    }
}
