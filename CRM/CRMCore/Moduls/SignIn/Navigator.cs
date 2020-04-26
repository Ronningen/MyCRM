using System;
using System.Drawing;
using System.Collections.Generic;
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
                    button.Click += (object o, EventArgs e) => { navForm.OpenAsDialog(f); };
                    table.Controls.Add(button, 0, i++);
                }
                navForm.Controls.Add(table);
                sender.OpenAsDialog(navForm);
            }
        }
    }
}
