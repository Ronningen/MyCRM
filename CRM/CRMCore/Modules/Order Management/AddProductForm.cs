using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRMCore.Moduls.Order_Managment
{
    public partial class AddProductForm : Patterns.PatternForm
    {
        public bool added;

        public AddProductForm(ListBox.ObjectCollection items)
        {
            InitializeComponent();
            foreach (var p in Entities.EntitiesHandler.Handler.Entities.ConcreteProducts.Select(s => s.ProductType.Description + " " + s.Id.ToString()))
                if (!items.Contains(p))
                    comboBoxProducts.Items.Add(p);
            forceClosing = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem == null)
                Inform("Select some role.");
            else
            {
                added = true;
                Close();
            }
        }
    }
}
