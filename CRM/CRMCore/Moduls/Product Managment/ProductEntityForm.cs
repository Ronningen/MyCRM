using System;
using System.Data;
using System.Linq;

using static CRMCore.Entities.EntitiesHandler;

namespace CRMCore.Moduls.Product_Managment
{
    public partial class ProductEntityForm : Patterns.PatternEntityForm<Entities.ConcreteProduct>
    {
        public ProductEntityForm()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(Handler.Entities.ProductTypes.Select(s => s.Description).ToArray());
        }

        protected override bool PackEntity()
        {
            if (comboBoxType.SelectedItem == null)
                Inform("Select some type.");
            else
            {
                if (entity == null)
                    entity = new Entities.ConcreteProduct();
                entity.ProductType = Handler.Entities.ProductTypes.Where(t => t.Description == comboBoxType.SelectedItem.ToString()).FirstOrDefault();
                entity.Sold = checkBoxSold.Checked;
                return true;
            }
            return false;
        }

        protected override void UnpackEntity()
        {
            checkBoxSold.Checked = entity.Sold;
            comboBoxType.SelectedItem = entity.ProductType.Description;
        }

        private void ProductEntityForm_Load(object sender, EventArgs e)
        {
            Text += "product";
        }
    }
}
