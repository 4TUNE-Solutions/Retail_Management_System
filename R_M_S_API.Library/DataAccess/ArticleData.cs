using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
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

        public ArticleModel GetProductById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetById", new { Id = articleId }, "Default").FirstOrDefault();

            return output;
        }

        public void DeleteProductById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spArticle_Delete", new { Id = articleId }, "Default");
        }
    }
}
