using System;

namespace CRMCore.Moduls.Customer_Managment
{
    public partial class CustomersForm : Patterns.PatternDataForm<Entities.Customer, CustomerEntityForm>
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        protected override void FillTable()
        {
            throw new NotImplementedException();
        }
    }
}
