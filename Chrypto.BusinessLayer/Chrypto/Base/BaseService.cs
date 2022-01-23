using Chrypto.Entities.Common;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace Chrypto.BusinessLayer.Chrypto.Base
{
    public class BaseService
    {
        protected string _endpoint;


        protected static HttpClient httpClient;

        public BaseService(string endpoint)
        {
            _endpoint = endpoint;
        }

        public T Get<T>(out HttpStatusCode statusCode)
        {
            using (httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", Parameters.API_KEY);
                httpClient.DefaultRequestHeaders.Add("Accepts", "application/json");
                var response = httpClient.GetAsync(_endpoint).GetAwaiter().GetResult();
                statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                else
                    return default(T);
            }                
        }
    }
}
