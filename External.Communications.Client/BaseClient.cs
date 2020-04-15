using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace External.Communications.Client
{
    public class BaseClient: IDisposable, IBaseClient
    {
        protected string Key = "";
        protected string URI = "";
        protected string ReadToken = "";
        public static HttpClient _httpClientInstance;

        public HttpClient InitializeClient()
        {
            if (_httpClientInstance == null)
            {
                _httpClientInstance = new HttpClient();
                _httpClientInstance.DefaultRequestHeaders.ConnectionClose = false; //KeepAlive = True
                _httpClientInstance.DefaultRequestHeaders.Accept.Clear();
                _httpClientInstance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            }

            return _httpClientInstance;
        }

        public void Dispose()
        {
            _httpClientInstance.CancelPendingRequests();
        }
    }
}
