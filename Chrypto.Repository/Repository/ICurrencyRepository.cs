using Chrypto.Entities.Entities;
using Chrypto.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.Repository.Repository
{
    public interface ICurrencyRepository : IRepository
    {
        CryptoCurrency GetCurrencys();

        List<ExchangeInfo> GetExchangeCurrency(int amount, long id, string symbols);

    }
}
