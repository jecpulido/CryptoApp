using Chrypto.Entities.Entities;
using Chrypto.Repository.Repository;
using Chrypto.ServiceLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.ServiceLayer.Services
{
    public class CurrencyService : ICurrencyService
    {
        private ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public CryptoCurrency GetCurrencys()
        {
            return  _currencyRepository.GetCurrencys();
        }

        public List<ExchangeInfo> GetExchangeCurrency(int amount, long id, string symbols)
        {
            return _currencyRepository.GetExchangeCurrency(amount,id, symbols);
        }
    }
}
