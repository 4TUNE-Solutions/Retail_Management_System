using API.Library.Internal.DataAccess;
using API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Library.DataAccess
{
    public class CorpoBuyerData
    {
        public List<CorpoBuyerModel> GetCorpoBuyers()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<CorpoBuyerModel, dynamic>("dbo.spCorpo_GetAll", new { }, "AssisDB");

            return output;
        }

        public void SetCorpoBuyer<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spCorpo_New", am, "AssisDB");
        }

        public CorpoBuyerModel GetCorpoBuyerById(int CorpoBuyerID)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<CorpoBuyerModel, dynamic>("dbo.spCorpo_GetById", new { Id = CorpoBuyerID }, "AssisDB").FirstOrDefault();

            return output;
        }

        public void DeleteCorpoBuyerById(int CorpoBuyerId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spCorpo_Delete", new { Id = CorpoBuyerId }, "AssisDB");
        }

        public void ChangeCorpoBuyerById<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spCorpo_Change", am, "AssisDB");
        }
    }
}
