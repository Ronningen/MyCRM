using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CRMCore.Entities;
using static CRMCore.Entities.EntitiesHandler;

namespace CRMCore.Moduls.SignIn
{
    public partial class SignIn : Patterns.PatternForm
    {
        public SignIn()
        {
            InitializeComponent();
            CreateEntitiesHandler();
            entitiesHandler.Load();
            //load login
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            void Inform(string reason) { MessageBox.Show(reason, "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
                Inform("Enter login");
            else if (!(entitiesHandler.Entities?.Users.Where(u => u.Login.ToLower() == textBoxLogin.Text.ToLower()) is User currentUser))
                Inform("Login is incorrect.");
            else if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                Inform("Enter password.");
            else if (currentUser.Password != textBoxPassword.Text)
                Inform("Password is incorrect.");
            else
            {
                //save login
                Navigator navigator = new Navigator(currentUser);
            }
        }
    }
}
