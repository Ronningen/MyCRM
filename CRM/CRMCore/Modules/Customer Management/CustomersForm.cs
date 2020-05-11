using System.Linq;
using System.Windows.Forms;

using CRMCore.Extansions;

namespace CRMCore.Moduls.Customer_Managment
{
    public partial class CustomersForm : Patterns.PatternDataForm<Entities.Customer, CustomerEntityForm>
    {
        public CustomersForm()
        {
            InitializeComponent();
            mainDataGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Name",
                    Name = "Name",
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
            mainDataGridView.Rows.Add(source.Count());
            int i = 0;
            foreach (var entity in source)
            {
                var row = mainDataGridView.Rows[i++];
                row.Cells["Id"].Value = entity.Id;
                row.Cells["Name"].Value = entity.FullName();
                row.Cells["Phone"].Value = entity.Phone;
                row.Cells["Email"].Value = entity.Email;
            }
        }
    }
}
