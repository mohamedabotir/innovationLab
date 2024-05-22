using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.Strategy
{
    internal class StandardCustomerDiscountStrategy:ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalPrice) => (totalPrice * 0.05M);//5%
    }
}
