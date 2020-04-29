using CRMCore.Extansions;
using System.Linq;
using System.Windows.Forms;

namespace CRMCore.Moduls.Product_Managment
{
    public partial class ProductsForm : Patterns.PatternDataForm<Entities.ConcreteProduct, ProductEntityForm>
    {
        public ProductsForm()
        {
            InitializeComponent();
            mainDataGridView.Columns["Id"].Visible = true;
            mainDataGridView.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Type",
                    Name = "Type",
                    ReadOnly = true
                },
                new DataGridViewCheckBoxColumn()
                {
                    HeaderText = "Sold",
                    Name = "Sold",
                    ReadOnly = true
                },
            });
            buttonNavigator.Visible = true;
            buttonNavigator.Text = "Types";
            buttonNavigator.Click += (o, e) => this.OpenAsDialog(new Type_of_product_Managment.ProductTypesForm());
        }

        protected override void FillTable()
        {
            mainDataGridView.Rows.Add(source.Count());
            int i = 0;
            foreach (var entity in source)
            {
                var row = mainDataGridView.Rows[i++];
                row.Cells["Id"].Value = entity.Id;
                row.Cells["Type"].Value = entity.ProductType.Description;
                row.Cells["Sold"].Value = entity.Sold;
                if (entity.Sold)
                    for (int j = 0; j < row.Cells.Count; j++)
                        row.Cells[j].Style.BackColor = System.Drawing.Color.LightGray;
            }
        }
    }
}
