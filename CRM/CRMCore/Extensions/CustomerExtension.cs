namespace CRMCore.Extansions
{
    static class CustomerExtension
    {
        public static string FullName(this Entities.Customer customer)
        {
            return customer.FirstName + " " + customer.SecondName + " " + customer.LastName;
        }
    }
}