using CurrencyConversion.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.Services
{
    public class DiscountManager
    {
        private readonly IAccountDiscountCalculatorFactory _factory;

        private readonly ILoyaltyDiscountCalculator _loyaltyDiscountCalculator;

        public DiscountManager(IAccountDiscountCalculatorFactory factory,
                               ILoyaltyDiscountCalculator loyaltyDiscountCalculator)
        {
            _factory = factory;
            _loyaltyDiscountCalculator = loyaltyDiscountCalculator;
        }

        public decimal ApplyDiscount(decimal price, CustomerType customerType,
                                     int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            priceAfterDiscount = _factory.GetAccountDiscountCalculator
                                 (customerType).ApplyDiscount(price);
            priceAfterDiscount = _loyaltyDiscountCalculator.ApplyDiscount
                                 (priceAfterDiscount, timeOfHavingAccountInYears);
            return priceAfterDiscount;
        }
    }
}
