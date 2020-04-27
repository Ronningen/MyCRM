// This file contains code, used for adding new moduls in a right way

namespace CRMCore.Entities
{
    using System.Windows.Forms;

    public partial class EntitiesHandler
    {
        /// <summary>
        /// Adds handlers to entitiessHandler's events.
        /// </summary>
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
        /// <summary>
        /// Links manager forms to string values of manager roles.
        /// </summary>
        partial void DefineFormsGetter()
        {
            // pattern: formsGetter += (string s) => GetForm<Entity_Managment.OrdersForm>(s, "RoleToEntity");
            formsGetter += (string s) => GetForm<Order_Managment.OrdersForm>(s, "OrderM");
            formsGetter += (string s) => GetForm<User_Managment.UsersForm>(s, "UserM");
            formsGetter += (string s) => GetForm<Product_Managment.ProductsForm>(s, "ProductM");
            formsGetter += (string s) => GetForm<Customer_Managment.CustomersForm>(s, "CustomerM");
        }
    }
}