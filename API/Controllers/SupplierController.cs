using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Library.DataAccess;
using API.Library.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        // GET: api/<SupplierController>
        [HttpGet]
        public List<SupplierModel> Get()
        {
            var data = new SupplierData();

            return data.GetSuppliers();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public SupplierModel Get(int id)
        {
            var data = new SupplierData();

            return data.GetSupplierById(id);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public void Post(SupplierModel supplier)
        {
            var data = new SupplierData();
            data.SetSupplier<SupplierModel>(supplier);
        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, SupplierModel am)
        {
            var data = new SupplierData();

            data.ChangeSupplierById<SupplierModel>(am);
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = new SupplierData();

            data.DeleteSupplierById(id);
        }
    }
}
