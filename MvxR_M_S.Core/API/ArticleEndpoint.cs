using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MvxR_M_S.Core.Models;

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
    }
}
