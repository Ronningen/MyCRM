using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMCore.Entities;

namespace CRMCore.Moduls.SignIn
{
    partial class Navigator
    {
        List<Patterns.PatternForm> forms;
        Action<string> formsGetter;
        
        public Navigator(User user)
        {
            forms = new List<Patterns.PatternForm>();
            DefineFormsGetter();
            foreach (var role in user.Roles)
                formsGetter.Invoke(role.RoleValue);
        }

        partial void DefineFormsGetter();

        private void GetForm<Form>(string s, string role) where Form : Patterns.PatternForm, new()
        {
            if (s == role)
                forms.Add(new Form());
        }

        public void OpenNavigator(Form sender)
        {
            if (forms.Count < 1)
                MessageBox.Show("You have no roles.\n\rAsk administrator to give you one.", "Woops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (forms.Count == 1)
                sender.OpenAsDialog(forms[0]);
            else
            {
            }
        }
    }
}
