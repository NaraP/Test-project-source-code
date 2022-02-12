using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion.IServices
{
  public interface IConverterWrapper
    {
        double Convert(int usd, int eur, int exchangeType);
    }
}
