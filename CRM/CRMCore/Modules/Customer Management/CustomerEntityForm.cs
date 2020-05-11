using System;
using System.Data;
using System.Linq;

using CRMCore.Extansions;
using static CRMCore.Entities.EntitiesHandler;

namespace CRMCore.Moduls.Customer_Managment
{
    public partial class CustomerEntityForm : Patterns.PatternEntityForm<Entities.Customer>
    {
        public CustomerEntityForm()
        {
            InitializeComponent();
            comboBoxManager.Items.AddRange(Handler.Entities.Users.Select(u => u.Login).ToArray());
        }

        protected override bool PackEntity()
        {
            string[] name = textBoxName.Text.Trim().Split(new char[] { ' ' });
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
                Inform("Enter name.");
            else if (name.Count() < 2)
                Inform("Name must contain at least 2 words.");
            else if (String.IsNullOrWhiteSpace(textBoxPhone.Text) && String.IsNullOrWhiteSpace(textBoxEmail.Text))
                Inform("Enter at least one contact (phone or email or both)");
            else
            {
                if (entity == null)
                    entity = new Entities.Customer();
                entity.FirstName = name[0];
                entity.SecondName = name[1];
                if (name.Count() > 2)
                    entity.LastName = name[2];
                entity.Phone = textBoxPhone.Text.Trim();
                entity.Email = textBoxEmail.Text.Trim();
                entity.User = Handler.Entities.Users.Where(u => u.Login == comboBoxManager.SelectedItem.ToString()).FirstOrDefault();
                return true;
            }
            return false;
        }

        protected override void UnpackEntity()
        {
            textBoxName.Text = entity.FullName();
            textBoxPhone.Text = entity.Phone;
            textBoxEmail.Text = entity.Email;
            comboBoxManager.SelectedItem = entity.User?.Login;
        }

        private void CustomerEntityForm_Load(object sender, EventArgs e)
        {
            Text += "customer";
        }
    }
}
