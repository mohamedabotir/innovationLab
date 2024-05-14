namespace CPM.BusinessLogic
{
    public class CustomerRepository
    {
        public List<Customer> Retrieve()
        {
            return new List<Customer>()
            {
                new Customer(1, "Nasr city, Cairo, Egypt", CustomerType.Normal)
                {
                    Email = "mohammad@gamil.com",
                    FirstName = "Mohammad",
                    LastName = "Atef",
                }
            };
        }
        public Customer Retrieve(int id)
        {
            return new (1, "Nasr city, Cairo, Egypt", CustomerType.Normal)
            {
                Email = "mohammad@gamil.com",
                FirstName = "Mohammad",
                LastName = "Atef",
            };
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
