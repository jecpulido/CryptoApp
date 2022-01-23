using Chrypto.Entities.Common;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace Chrypto.BusinessLayer.Chrypto.Base
{
    public class BaseService
    {
        protected string _endpoint;

        //protected readonly static WebClient _httpClient = new WebClient();

        protected static HttpClient httpClient;

        public BaseService(string endpoint)
        {
            _endpoint = endpoint;
        }

        //public T Get<T>()
        //{
        //    _httpClient.UseDefaultCredentials = true;
        //    _httpClient.Headers.Add("X-CMC_PRO_API_KEY", Parameters.API_KEY);
        //    _httpClient.Headers.Add("Accepts", "application/json");
        //    var response = _httpClient.DownloadString(_endpoint);
        //    _httpClient.Dispose();
        //    return JsonConvert.DeserializeObject<T>(response);
        //}


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
