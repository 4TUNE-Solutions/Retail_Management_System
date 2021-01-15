using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R_M_S_API.Library.Internal.DataAccess;
using R_M_S_API.Library.Models;

namespace R_M_S_API.Library.DataAccess
{
    public class ArticleData
    {
        public List<ArticleModel> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetAll", new { }, "Default");

            return output;
        }

        public ArticleModel GetProductById(int productId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetById", new { Id = productId }, "Default").FirstOrDefault();

            return output;
        }
    }
}
