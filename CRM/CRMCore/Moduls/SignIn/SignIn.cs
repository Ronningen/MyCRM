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
            Handler.Load();
            textBoxLogin.Text = LoginSaver.LoadLogin();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
                Inform("Enter login");
            else if (!(Handler.Entities.Users.Where(u => u.Login.ToLower().Trim() == textBoxLogin.Text.ToLower().Trim()).FirstOrDefault() is User currentUser))
                Inform("Login is incorrect.");
            else if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                Inform("Enter password.");
            else if (currentUser.Password != textBoxPassword.Text)
                Inform("Password is incorrect.");
            else
            {
                if (checkBoxSaveLogin.Checked)
                    LoginSaver.SaveLogin(textBoxLogin.Text);
                Navigator navigator = new Navigator(currentUser);
                navigator.OpenNavigator(this);
            }
            Cursor = Cursors.Default;
        }
    }
}
