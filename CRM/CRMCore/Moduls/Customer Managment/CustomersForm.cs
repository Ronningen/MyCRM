using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
