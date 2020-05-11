using System;

namespace CRMCore.Moduls.Type_of_product_Managment
{
    public partial class ProductTypeEntityForm : Patterns.PatternEntityForm<Entities.ProductType>
    {
        public ProductTypeEntityForm()
        {
            InitializeComponent();
        }

        protected override bool PackEntity()
        {
            if (String.IsNullOrWhiteSpace(textBoxDescription.Text))
                Inform("Description is required.");
            else
            {
                if (entity == null)
                    entity = new Entities.ProductType();
                entity.Description = textBoxDescription.Text.Trim();
                entity.Price = numericrPrice.Value;
                return true;
            }
            return false;
        }

        protected override void UnpackEntity()
        {
            textBoxDescription.Text = entity.Description;
            numericrPrice.Value = entity.Price;
        }

        private void ProductTypeEntityForm_Load(object sender, EventArgs e)
        {
            Text += "type";
        }
    }
}
