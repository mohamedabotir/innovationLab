using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.Strategy
{
    public class LawEndCustomerDiscountStrategy:ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalPrice) => 0.03M;
    }
}
