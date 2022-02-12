using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.IServices
{
   public interface ILoyaltyDiscountCalculator
    {
        decimal ApplyDiscount(decimal price, int timeOfHavingAccountInYears);

    }
}
