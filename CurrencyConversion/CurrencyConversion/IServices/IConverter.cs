using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.IServices
{
    public interface IConverter
    {
        double ConversionUSDtoEUR(int usd, dynamic currencyRate);

        double ConversionEURtoUSD(int eur, dynamic currencyRate);
    }
}
