namespace CPM.BusinessLogic
{
    public abstract class Customer
    {
        public Customer(int customerId, string homeAddress)
        {
            CustomerId = customerId;
            HomeAddress = homeAddress;
        }
        public int CustomerId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        public string Email { get; set; }
        public string HomeAddress { get; }
        public string WorkAddress { get; set; }

        public abstract IOrderCalculator Calculator(Order order);
    }
}