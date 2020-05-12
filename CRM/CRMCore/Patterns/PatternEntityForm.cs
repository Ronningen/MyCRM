using System;
using System.Windows.Forms;

namespace CRMCore.Patterns
{
    abstract public partial class PatternEntityForm<TEntity> : PatternForm where TEntity : class, new()
    {
        public TEntity entity;
        public EntityFormMode mode;

        public PatternEntityForm()
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
        /// <returns> true if input has right format </returns>
        protected abstract bool PackEntity();

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (PackEntity())
            {
                forceClosing = true;
                Close();
            }
            Cursor = Cursors.Default;
        }

        private void PatternEntityForm_Load(object sender, EventArgs e)
        {
            Text = mode.ToString() + " ";
            if (mode == default)
                throw new Exception("mode is not initialized");
            else if (mode != EntityFormMode.Add)
            {
                if (entity == null)
                    throw new Exception("entity is not initialized");
                UnpackEntity();
                if (mode == EntityFormMode.Observe)
                    buttonConfirm.Visible = false;
            }
        }
    }
}
