using System;
using System.Data.Entity;


namespace CRMCore.Patterns
{
    abstract public partial class PatternDataForm<TEntity, TEntityForm> : PatternForm 
        where TEntity : class, IDeletableEntity, new() 
        where TEntityForm : PatternEntityForm<TEntity>, new()
    {
        protected DbSet<TEntity> source;

        public PatternDataForm()
        {
            InitializeComponent();
            Text = typeof(TEntity).Name + "managment";
        }

        /// <summary>
        /// Fills dataGrid with data from DbSet source
        /// </summary>
        protected abstract void FillTable();

        /// <summary>
        /// Get selected entity in the dataGrid
        /// </summary>
        /// <returns></returns>
        protected TEntity SelectedEntity()
        {
            return source.Find(Convert.ToInt32(mainDataGridView.SelectedRows[0].Cells["ColumnId"].Value));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            TEntityForm entityForm = new TEntityForm() { entity = SelectedEntity() };
            Hide();
            entityForm.ShowDialog();
            Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TEntityForm entityForm = new TEntityForm();
            Hide();
            entityForm.ShowDialog();
            Show();
            if (entityForm.entity != null)
                source.Add(entityForm.entity);
        }

        protected virtual void buttonDelete_Click(object sender, EventArgs e)
        {
            SelectedEntity().Deleted = true;
        }
    }
}
