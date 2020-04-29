using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

using CRMCore.Entities;
using CRMCore.Extansions;

namespace CRMCore.Moduls.SignIn
{
    /// <summary>
    /// Navigate user in depenpence on his roles.
    /// </summary>
    partial class Navigator
    {
        List<Patterns.PatternForm> forms;
        Action<string> formsGetter;

        /// <summary>
        /// </summary>
        /// <param name="user"> user, whose roles are used for navigation. </param>
        public Navigator(User user)
        {
            forms = new List<Patterns.PatternForm>();
            DefineFormsGetter();
            foreach (var role in user.Roles)
                formsGetter.Invoke(role.RoleValue);
        }

        partial void DefineFormsGetter();

        /// <summary>
        /// If "s" matches to "role", give access to form for such role.
        /// This method is used as linker in DefineFormsGetter().
        /// </summary>
        /// <typeparam name="Form"> type of form, openning in the method </typeparam>
        /// <param name="s"> input value idential to arg of the formsGetter delegete </param>
        /// <param name="role"> pattern role value, linked to "Form" </param>
        private void GetForm<Form>(string s, string role) where Form : Patterns.PatternForm, new()
        {
            if (s == role)
                forms.Add(new Form());
        }

        /// <summary>
        /// Open navigation form if user has many roles or opens one concrete if user has only one role
        /// </summary>
        /// <param name="sender"></param>
        public void OpenNavigator(Form sender)
        {
            if (forms.Count < 1)
                MessageBox.Show("You have no roles.\n\rAsk administrator to give you one.", "Woops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (forms.Count == 1)
                sender.OpenAsDialog(forms[0]);
            else
            {
                Patterns.PatternForm navForm = new Patterns.PatternForm()
                {
                    AutoSize = true,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = "Navigation"
                };
                TableLayoutPanel table = new TableLayoutPanel()
                {
                    Location = new Point(15, 60),
                    ColumnCount = 1,
                    RowCount = forms.Count,
                    AutoSize = true
                };
                int i = 0;
                foreach (var f in forms)
                {
                    Button button = new Button();
                    button.AutoSize = true;
                    button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    button.BackColor = Color.BlueViolet;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.White;
                    button.Margin = new Padding(10);
                    button.Padding = new Padding(10);
                    button.Text = f.Text;
                    button.Click += (o, e) => { navForm.OpenAsDialog(f); };
                    table.Controls.Add(button, 0, i++);
                }
                navForm.Controls.Add(table);
                sender.OpenAsDialog(navForm);
            }
        }
    }
}
