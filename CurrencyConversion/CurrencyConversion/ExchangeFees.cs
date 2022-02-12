using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion
{
   public class ExchangeFees
    {
        public static dynamic GetExchangeRate()
        {
            dynamic currency;
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString("http://www.floatrates.com/daily/usd.json");
                currency = JsonConvert.DeserializeObject<dynamic>(json);
            }

            return currency;
        }
    }
}
