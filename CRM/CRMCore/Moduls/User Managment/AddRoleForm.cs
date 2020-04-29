using System;
using System.Windows.Forms;

namespace CRMCore.Moduls.Type_of_product_Managment
{
    public partial class AddRoleForm : Patterns.PatternForm
    {
        public bool added;

        public AddRoleForm(ListBox.ObjectCollection items)
        {
            InitializeComponent();
            foreach (var r in Entities.EntitiesHandler.Handler.Entities.Roles)
                if (!items.Contains(r.RoleValue))
                    comboBoxRoles.Items.Add(r.RoleValue);
            forceClosing = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxRoles.SelectedItem == null)
                Inform("Select some role.");
            else
            {
                added = true;
                Close();
            }
        }
    }
}
