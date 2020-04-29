using System.Linq;
using System.Windows.Forms;

using CRMCore.Extansions;

namespace CRMCore.Moduls.Order_Managment
{
    public partial class OrdersForm : Patterns.PatternDataForm<Entities.Order, OrderEntityForm>
    {
        public OrdersForm()
        {
            InitializeComponent();
            mainDataGridView.Columns["Id"].Visible = true;
            mainDataGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Description",
                    Name = "Description",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Customer",
                    Name = "Customer",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Status",
                    Name = "Status",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Close date",
                    Name = "CloseDate",
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
                row.Cells["Description"].Value = entity.Description;
                row.Cells["Customer"].Value = entity.Customer.FullName();
                row.Cells["Status"].Value = entity.Status;
                row.Cells["CloseDate"].Value = entity.CloseDate.ToShortDateString();
            }
        }
    }
}
