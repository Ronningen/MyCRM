using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMCore.Moduls.Order_Managment
{
    public partial class OrdersForm : Patterns.PatternDataForm<Entities.Order, OrderEntityForm>
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        protected override void FillTable()
        {
            throw new NotImplementedException();
        }
    }
}
