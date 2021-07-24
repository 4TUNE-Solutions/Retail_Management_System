using API.Library.Internal.DataAccess;
using API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Library.DataAccess
{
    public class StoreData
    {
        public void SetStore<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spShop_New", am, "AssisDB");
        }

        public List<StoreModel> GetStores()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<StoreModel, dynamic>("dbo.spShop_GetAll", new { }, "AssisDB");

            return output;
        }

        public StoreModel GetStoreById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<StoreModel, dynamic>("dbo.spShop_GetById", new { Id = articleId }, "AssisDB").FirstOrDefault();

            return output;
        }

        public void DeleteStoreById(int articleId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spShop_Delete", new { Id = articleId }, "AssisDB");
        }

        public void ChangeStoreById<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spShop_Change", am, "AssisDB");
        }
    }
}
