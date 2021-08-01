using API.Library.Internal.DataAccess;
using API.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Library.DataAccess
{
    public class SupplierData
    {
        public List<SupplierModel> GetSuppliers()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<SupplierModel, dynamic>("dbo.spSupplier_GetAll", new { }, "AssisDB");

            return output;
        }

        public void SetSupplier<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spSupplier_New", am, "AssisDB");
        }

        public SupplierModel GetSupplierById(int SupplierID)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<SupplierModel, dynamic>("dbo.spSupplier_GetById", new { Id = SupplierID }, "AssisDB").FirstOrDefault();

            return output;
        }

        public void DeleteSupplierById(int SupplierId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.DeleteData<dynamic>("dbo.spSupplier_Delete", new { Id = SupplierId }, "AssisDB");
        }

        public void ChangeSupplierById<T>(T am)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SetData<T>("dbo.spSupplier_Change", am, "AssisDB");
        }
    }
}
