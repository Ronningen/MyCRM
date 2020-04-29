using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMCore.Moduls.User_Managment
{
    public partial class UsersForm : Patterns.PatternDataForm<Entities.User, UserEntityForm>
    {
        public UsersForm()
        {
            InitializeComponent();
            mainDataGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Login",
                    Name = "Login",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Password",
                    Name = "Password",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Phone",
                    Name = "Phone",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Email",
                    Name = "Email",
                    ReadOnly = true
                }
            });
        }

        protected override void FillTable()
        {
            mainDataGridView.Rows.Clear();
            mainDataGridView.Rows.Add(source.Count());
            int i = 0;
            foreach (var entity in source)
            {
                var row = mainDataGridView.Rows[i++];
                row.Cells["Id"].Value = entity.Id;
                row.Cells["Login"].Value = entity.Login;
                row.Cells["Password"].Value = entity.Password;
                row.Cells["Phone"].Value = entity.Phone;
                row.Cells["Email"].Value = entity.Email;
            }
        }
    }
}
