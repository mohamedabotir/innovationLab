using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.PatternMatch
{
    internal class PatternMatch
    {
        #region simple pattern match1)
        /*
         var customer = CustomerDiscountFactory(5000M);

         Console.WriteLine(customer.CalculateDiscount(5000m));
         ICustomerDiscountStrategy CustomerDiscountFactory(decimal totalCost) => totalCost switch
         {
             < 5000 and > 0 => new StandardCustomerDiscountStrategy(),
             < 10000 and >= 5000 => new GoldCustomerDiscountStrategy(),
             >= 10000 => new PremiumCustomerDiscountStrategy(),//positional pattern
             _ => throw new InvalidOperationException("invalid Operation")
         };
        */
        #endregion

        #region pattern match with multiple input 2)
        /*
        Order order = new(5, 1000);
        var customer2 = CustomerDiscountWithOrderFactory(new Order(5, 1000));
        Console.WriteLine(customer2.CalculateDiscount(order.Cost));
        ICustomerDiscountStrategy CustomerDiscountWithOrderFactory(Order order) => order switch
        {
        { Items: > 10, Cost: > 1000M } => new GoldCustomerDiscountStrategy(),
        { Items: > 5, Cost: > 1000M } => new PremiumCustomerDiscountStrategy(),
        { Cost: <= 1000M and >= 500 } => new StandardCustomerDiscountStrategy(),
        ( < 500M and >= 250M, >= 3) => new LawEndCustomerDiscountStrategy(),
        _ => new NoStandardCustomerDiscountStrategy(),


        public class Order(int items, decimal cost)
        {
            public int Items { get; } = items;
            public decimal Cost { get; } = cost;

            public void Deconstruct(out decimal cost, out int items) // deconstruct
            {
                (items, cost) = (Items, Cost);
            }
        };
    };
        */
        #endregion

        #region deconstruct
        public class Order(int items, decimal cost)
    {
        public int Items { get; } = items;
        public decimal Cost { get; } = cost;

        public void Deconstruct(out decimal cost, out int items) // deconstruct
        {
            (items, cost) = (Items, Cost);
        }
    };


    #endregion
}
}
