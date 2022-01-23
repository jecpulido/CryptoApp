using Chrypto.BusinessLayer.Chrypto.Base;
using Chrypto.Entities.Common;
using Chrypto.Entities.Entities;
using Chrypto.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.BusinessLayer.Chrypto
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private const string METHOD_LISTING = "cryptocurrency/listings/latest";
        private const string METHOD_EXCHANGE = "tools/price-conversion";

        public CryptoCurrency GetCurrencys()
        {
            string url = Parameters.BASE_URL + METHOD_LISTING + "?limit=" + Parameters.LIMIT + "&start=1";
            HttpStatusCode status;
            CryptoCurrency Result = new BaseService(url).Get<CryptoCurrency>(out status);
            return Result;
        }

        public List<ExchangeInfo> GetExchangeCurrency(int amount, long id, string symbols)
        {
            List<ExchangeInfo> lstExchange = new List<ExchangeInfo>();
            string url = String.Empty;
            var lstCryptoCurrencys = symbols.Split(' ').ToList();
            foreach (var crypto in lstCryptoCurrencys)
            {
                url = String.Format("{0}{1}?amount={2}&id={3}&convert={4}", Parameters.BASE_URL, METHOD_EXCHANGE, amount, id,crypto);
                HttpStatusCode status;
                var Result = new BaseService(url).Get<ExchangeCrypto>(out status);
                lstExchange.Add(new ExchangeInfo() {
                    Symbol = crypto,
                    Price = Result.Data.Quote[crypto].Price
                });;
            }
            return lstExchange;
        }
    }
}
