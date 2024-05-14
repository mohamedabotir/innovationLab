namespace CPM.BusinessLogic
{
    public sealed class VIPCustomer : Customer
    {
        public VIPCustomer(int customerId, string homeAddress)
            : base(customerId, homeAddress)
        {
        }
        public override IOrderCalculator Calculator(Order order)
        {
            return new NormalCustomerCalculator(order);
        }
    }
}