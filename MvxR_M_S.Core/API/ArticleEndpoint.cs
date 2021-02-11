using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MvxR_M_S.Core.Models;
using Newtonsoft.Json;
using R_M_S_API.Library.DataAccess;

namespace MvxR_M_S.Core.API
{
    public class ArticleEndpoint
    {
        private APIHelper _apiHelper;

        public ArticleEndpoint(APIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<ArticleModel>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Articles"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<ArticleModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task Send<T>(T article)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Articles", article))
            {
                if (response.IsSuccessStatusCode)
                {
                    
                    //TODO LOGGING
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task Delete(int articleId)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.DeleteAsync($"/api/Articles/{articleId}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    //TODO LOGGING
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
