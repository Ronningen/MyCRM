using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

using CRMCore.Extansions;

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

        public PatternDataForm()
        {
            InitializeComponent();
            source = Entities.EntitiesHandler.Handler.Entities.Set<TEntity>();
        }

        /// <summary>
        /// Fills mainDataGridView with data from DbSet source
        /// </summary>
        protected abstract void FillTable();

        private void UpdateTable()
        {
            if (source.Count() > 0)
            {
                mainDataGridView.Rows.Clear();
                FillTable();
            }
        }

        private void PatternDataForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

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
            return source.Find(mainDataGridView.SelectedRows[index].Cells["Id"].Value);
        }

        /// <summary>
        /// Checks some row in mainDataGridView is selected
        /// </summary>
        /// <returns></returns>
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
                Entities.EntitiesHandler.Handler.Save();
                UpdateTable();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TEntityForm entityForm = new TEntityForm() { mode = EntityFormMode.Add };
            this.OpenAsDialog(entityForm);
            if (entityForm.entity != null)
            {
                source.Add(entityForm.entity as TEntity);
                Entities.EntitiesHandler.Handler.Save();
                UpdateTable();
            }
        }

        private void buttonObserve_Click(object sender, EventArgs e)
        {
            if (SomethingSelected())
                this.OpenAsDialog(new TEntityForm() { entity = SelectedEntity(), mode = EntityFormMode.Observe });
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SomethingSelected())
            {
                var result = MessageBox.Show("Do you really want to delete seleted " + typeof(TEntity).Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteSelectedEntity();
                    Entities.EntitiesHandler.Handler.Save();
                    UpdateTable();
                }
            }
        }
    }
}
