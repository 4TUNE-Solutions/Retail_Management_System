using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MvxR_M_S.Core.API
{
    public class APIHelper
    {
        private HttpClient _apiClient;

        public APIHelper()
        {
            InitializeClient();
        }

        public HttpClient ApiClient => _apiClient; 

        private void InitializeClient()
        {
            string apiURL = "https://localhost:44357/";

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(apiURL);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
