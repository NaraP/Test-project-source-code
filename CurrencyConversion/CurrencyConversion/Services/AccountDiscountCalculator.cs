using CurrencyConversion.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.Services
{
   public class AccountDiscountCalculator : IAccountDiscountCalculator
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price;
        }
        public class NotRegisteredDiscountCalculator : IAccountDiscountCalculator
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price;
            }
        }

        public class SimpleCustomerDiscountCalculator : IAccountDiscountCalculator
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price - (Constants.DISCOUNT_FOR_SILVER_CUSTOMERS * price);
            }
        }

        public class ValuableCustomerDiscountCalculator : IAccountDiscountCalculator
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price - (Constants.DISCOUNT_FOR_GOLD_CUSTOMERS * price);
            }
        }

        public class MostValuableCustomerDiscountCalculator : IAccountDiscountCalculator
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price - (Constants.DISCOUNT_FOR_PLATINUM_CUSTOMERS * price);
            }
        }
    }
}
