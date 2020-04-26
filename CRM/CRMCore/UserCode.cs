using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMCore.Entities
{
    public partial class EntitiesHandler
    {
        partial void DefineEvents()
        {
            DataGetFailed += () =>
            {
                MessageBox.Show("The program failed to get data from database.\n\rSigning in and further work are imposible.",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            DataSaveFailed += () =>
            {
                MessageBox.Show("The program failed to save changes to database.\n\rData won't be saved after closing the propram.",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }
    }
}

namespace CRMCore.Moduls.SignIn
{
    partial class Navigator
    {
        partial void DefineFormsGetter()
        {
            formsGetter += (string s) => GetForm<Order_Managment.OrdersForm>(s, "OrderM");
            formsGetter += (string s) => GetForm<User_Managment.UsersForm>(s, "UserM");
            formsGetter += (string s) => GetForm<Product_Managment.ProductsForm>(s, "ProductM");
            formsGetter += (string s) => GetForm<Customer_Managment.CustomersForm>(s, "CustomerM");
        }
    }
}