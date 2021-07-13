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
        public void SetArticle<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spArticle_New", am, "AssisDB");
        }

        public List<ArticleModel> GetArticles()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetAll", new { }, "AssisDB");

            return output;
        }

        public ArticleModel GetArticleById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetById", new { Id = articleId }, "AssisDB").FirstOrDefault();

            return output;
        }

        public void DeleteArticleById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spArticle_Delete", new { Id = articleId }, "AssisDB");
        }

        public void ChangeArticleById<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spArticle_Change", am, "AssisDB");
        }
    }
}
