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

            string connectionString = sql.GetConnectionString("Default");

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var sqlStatement = "DELETE GL_article_list WHERE Id = @Id";
                connection.Execute(sqlStatement, new {Id = articleId });
            }
        }
    }
}
