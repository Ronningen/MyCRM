using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRMCore.Entities;
using CRMCore.Moduls.Type_of_product_Managment;
using static CRMCore.Entities.EntitiesHandler;

namespace CRMCore.Moduls.User_Managment
{
    public partial class UserEntityForm : Patterns.PatternEntityForm<Entities.User>
    {
        public UserEntityForm()
        {
            InitializeComponent();
        }

        protected override bool PackEntity()
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
                Inform("Enter login.");
            else if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                Inform("Enter password.");
            else
            {
                if (entity == null)
                    entity = new Entities.User();
                entity.Login = textBoxLogin.Text.Trim();
                entity.Password = textBoxPassword.Text.Trim();
                entity.Phone = textBoxPhone.Text.Trim();
                entity.Email = textBoxEmail.Text.Trim();
                entity.Roles.Clear();
                foreach (var r in listBoxRoles.Items)
                    entity.Roles.Add(Handler.Entities.Roles.Find(r.ToString()));
                return true;
            }
            return false;
        }

        protected override void UnpackEntity()
        {
            textBoxLogin.Text = entity.Login;
            textBoxPassword.Text = entity.Password;
            textBoxPhone.Text = entity.Phone;
            textBoxEmail.Text = entity.Email;
            listBoxRoles.Items.AddRange(entity.Roles.Select(r => r.RoleValue).ToArray());
        }

        private void UserEntityForm_Load(object sender, EventArgs e)
        {
            Text += "user";
            if (mode == Patterns.EntityFormMode.Observe)
            {
                buttonAddRole.Visible = false;
                buttonRemoveRole.Visible = false;
                listBoxRoles.Width = buttonConfirm.Width;
            }
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm(listBoxRoles.Items);
            addRoleForm.ShowDialog();
            if (addRoleForm.added)
                listBoxRoles.Items.Add(addRoleForm.comboBoxRoles.SelectedItem);
        }

        private void buttonRemoveRole_Click(object sender, EventArgs e)
        {
            if (listBoxRoles.SelectedItem == null)
                Inform("Select role you want to remove.");
            else
                listBoxRoles.Items.Remove(listBoxRoles.SelectedItem);
        }
    }
}
