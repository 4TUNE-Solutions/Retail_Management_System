using API.Library.Internal.DataAccess;
using API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Library.DataAccess
{
    public class InventoryData
    {
        public void SetInventory<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spInventory_New", am, "AssisDB");
        }

        public List<InventoryModel> GetInventories()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<InventoryModel, dynamic>("dbo.spInventory_GetAll", new { }, "AssisDB");

            return output;
        }

        public InventoryModel GetInventoryById(int inventoryId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<InventoryModel, dynamic>("dbo.spInventory_GetById", new { Id = inventoryId }, "AssisDB").FirstOrDefault();

            return output;
        }

        public void DeleteInventoryById(int inventoryId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spInventory_Delete", new { Id = inventoryId }, "AssisDB");
        }

        public void ChangeInventoryById<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spInventory_Change", am, "AssisDB");
        }
    }
}
