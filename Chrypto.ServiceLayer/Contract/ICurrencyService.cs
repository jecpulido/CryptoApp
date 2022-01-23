using Chrypto.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.ServiceLayer.Contract
{
    public interface ICurrencyService
    {
        CryptoCurrency GetCurrencys();

        List<ExchangeInfo> GetExchangeCurrency(int amount, long id, string symbols);
    }
}
