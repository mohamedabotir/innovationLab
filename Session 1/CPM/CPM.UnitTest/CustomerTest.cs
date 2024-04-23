using CPM.BusinessLogic;

namespace CPM.UnitTest
{
    public class CustomerTest
    {
        [Fact]
        public void Fullname_ValidFullName_commaSeparatedFirstNameAndLastName()
        {
            // arrange
            var customer = new Customer
            {
                CustomerId = 1,
                FirstName = "Mohammad",
                LastName = "Atef",
            };

            // act
            var acutal = "Mohammad, Atef";

            // assert
            Assert.Equal(acutal, customer.FullName);
        }
        [Fact]
        public void Fullname_FirstNameNull_EqualLastName()
        {
            // arrange
            var customer = new Customer
            {
                CustomerId = 1,
                LastName = "Atef",
            };

            // act
            var acutal = "Atef";

            // assert
            Assert.Equal(acutal, customer.FullName);
        }
    }
}
