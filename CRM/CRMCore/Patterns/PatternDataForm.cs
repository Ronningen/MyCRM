using System;
using System.Windows.Forms;
using System.Data.Entity;


namespace CRMCore.Patterns
{
    /// <summary>
    /// Windows form showing set of entites from database and allowing to work with this set
    /// </summary>
    /// <typeparam name="TEntity"> Type of entities in set </typeparam>
    /// <typeparam name="TEntityForm"> Type of windows form using to add, change or observe entity </typeparam>
    abstract public partial class PatternDataForm<TEntity, TEntityForm> : PatternForm
        where TEntity : class, new()
        where TEntityForm : PatternEntityForm<TEntity>, new()
    {
        protected DbSet<TEntity> source;

        protected PatternDataForm()
        {
            InitializeComponent();
            source = Entities.EntitiesHandler.Handler.Entities.Set<TEntity>();
            FillTable();
        }

        /// <summary>
        /// Fills mainDataGridView with data from DbSet source
        /// </summary>
        protected abstract void FillTable();

        /// <summary>
        /// In base removes all selected entites
        /// </summary>
        protected virtual void DeleteSelectedEntity()
        {
            for (int i = 0; i < mainDataGridView.SelectedRows.Count; i++)
                source.Remove(SelectedEntity(i));
        }

        /// <summary>
        /// Gets selected entity in mainDataGridView in the position of index in selected rows
        /// </summary>
        /// <param name="index"> Index of the entity in selected rows </param>
        /// <returns></returns>
        protected TEntity SelectedEntity(int index = 0)
        {
            return source.Find(Convert.ToInt32(mainDataGridView.SelectedRows[index].Cells["ColumnId"].Value));
        }

        protected bool SomethingSelected()
        {
            if (mainDataGridView.SelectedRows.Count >= 1)
                return true;
            Inform("Select any row.");
            return false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (SomethingSelected())
            {
                this.OpenAsDialog(new TEntityForm() { entity = SelectedEntity(), mode = EntityFormMode.Edit });
                FillTable();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TEntityForm entityForm = new TEntityForm() { mode = EntityFormMode.Add };
            this.OpenAsDialog(entityForm);
            if (entityForm.entity != null)
                source.Add(entityForm.entity);
            FillTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SomethingSelected())
            {
                var result = MessageBox.Show("Do you really want to delete seleted " + typeof(TEntity).Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    DeleteSelectedEntity();
                FillTable();
            }
        }

        private void buttonObserve_Click(object sender, EventArgs e)
        {
            if (SomethingSelected())
                this.OpenAsDialog(new TEntityForm() { entity = SelectedEntity(), mode = EntityFormMode.Observe });
        }
    }
}
