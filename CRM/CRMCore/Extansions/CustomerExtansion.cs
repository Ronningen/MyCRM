namespace CRMCore.Extansions
{
    static class CustomerExtansion
    {
        public static string FullName(this Entities.Customer customer)
        {
            return customer.FirstName + " " + customer.SecondName + " " + customer.LastName;
        }
    }
}