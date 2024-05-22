using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.Strategy
{
    public class PremiumCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalPrice) => (totalPrice * 0.15M);//5%
    }
}
