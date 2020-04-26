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
    public partial class CustomerEntityForm : Patterns.PatternEntityForm<Entities.Customer>
    {
        public CustomerEntityForm()
        {
            InitializeComponent();
        }

        protected override bool PackEntity()
        {
            throw new NotImplementedException();
        }

        protected override void UnpackEntity()
        {
            throw new NotImplementedException();
        }
    }
}
