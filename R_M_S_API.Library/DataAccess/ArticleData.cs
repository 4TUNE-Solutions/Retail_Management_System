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
        public void SetArticle(string Barcode, string Barcode2, string Barcode3, string Barcode4,
            string ArticleName, int TaxId, string Description, string ArticleNote, DateTime ExpDate,
            int SupplierId, bool IsService, int Discount)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spArticle_New", new {
                barcode = Barcode,
                barcode2 = Barcode2,
                barcode3 = Barcode3,
                barcode4 = Barcode4,
                articleName = ArticleName,
                taxId = TaxId,
                description = Description,
                articleNote = ArticleNote,
                expDate = ExpDate,
                supplierId = SupplierId,
                isService = IsService,
                discount = Discount
            }, "Default");
        }

        public List<ArticleModel> GetArticles()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetAll", new { }, "Default");

            return output;
        }

        public ArticleModel GetArticleById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ArticleModel, dynamic>("dbo.spArticle_GetById", new { Id = articleId }, "Default").FirstOrDefault();

            return output;
        }

        public void DeleteArticleById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spArticle_Delete", new { Id = articleId }, "Default");
        }
    }
}
