using System;
using System.Data;
using System.Linq;

using CRMCore.Extansions;
using static CRMCore.Entities.EntitiesHandler;

namespace CRMCore.Moduls.Order_Managment
{
    public partial class OrderEntityForm : Patterns.PatternEntityForm<Entities.Order>
    {
        public OrderEntityForm()
        {
            InitializeComponent();
            foreach (var c in Handler.Entities.Customers)
                comboBoxCustomer.Items.Add(c.FullName());
        }

        protected override bool PackEntity()
        {
            if (comboBoxCustomer.SelectedItem == null)
                Inform("Select some customer.");
            else if (String.IsNullOrWhiteSpace(richTextBoxDescription.Text))
                Inform("Enter description.");
            else if (String.IsNullOrWhiteSpace(textBoxStatus.Text))
                Inform("Enter status.");
            else if (dateTimePickerOpen.Value > dateTimePickerClose.Value)
                Inform("Order must be openned before closing.");
            else
            {
                if (entity == null)
                    entity = new Entities.Order();
                foreach (var c in Handler.Entities.Customers)
                    if (c.FullName() == comboBoxCustomer.Text)
                    {
                        entity.Customer = c;
                        break;
                    }
                entity.Description = richTextBoxDescription.Text;
                entity.Status = textBoxStatus.Text;
                entity.OpenDate = dateTimePickerOpen.Value;
                entity.CloseDate = dateTimePickerClose.Value;
                foreach (var p in listBoxProducts.Items)
                    entity.ConcreteProducts.Add(Handler.Entities.ConcreteProducts.Find(Guid.Parse(p.ToString().Split(new char[] { ' ' }).Last())));
                return true;
            }
            return false;
        }

        protected override void UnpackEntity()
        {
            comboBoxCustomer.SelectedItem = entity.Customer.FullName();
            richTextBoxDescription.Text = entity.Description;
            textBoxStatus.Text = entity.Status;
            dateTimePickerOpen.Value = entity.OpenDate;
            dateTimePickerClose.Value = entity.CloseDate;
            listBoxProducts.Items.AddRange(entity.ConcreteProducts.Select(s => s.ProductType.Description + " " + s.Id.ToString()).ToArray());
        }

        private void OrderEntityForm_Load(object sender, EventArgs e)
        {
            Text += "order";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem == null)
                Inform("Select product you want to remove.");
            else
                listBoxProducts.Items.Remove(listBoxProducts.SelectedItem);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(listBoxProducts.Items);
            addProductForm.ShowDialog();
            if (addProductForm.added)
                listBoxProducts.Items.Add(addProductForm.comboBoxProducts.SelectedItem);
        }
    }
}
