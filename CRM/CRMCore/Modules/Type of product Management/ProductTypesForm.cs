using System.Linq;
using System.Windows.Forms;

namespace CRMCore.Moduls.Type_of_product_Managment
{
    public partial class ProductTypesForm : Patterns.PatternDataForm<Entities.ProductType, ProductTypeEntityForm>
    {
        public ProductTypesForm()
        {
            InitializeComponent();
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
                    HeaderText = "Price",
                    Name = "Price",
                    ReadOnly = true
                },
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
                row.Cells["Description"].Value = entity.Description;
                row.Cells["Price"].Value = entity.Price.ToString();
            }
        }
    }
}
