using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Library.DataAccess;
using API.Library.Models;
using System.Data.SqlTypes;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        [HttpGet]
        public List<InventoryModel> Get()
        {
            var data = new InventoryData();

            return data.GetInventories();
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public InventoryModel Get(int id)
        {
            var data = new InventoryData();

            return data.GetInventoryById(id);
        }

        // POST api/<InventoryController>
        [HttpPost]
        public void Post(InventoryModel inventory)
        {
            var data = new InventoryData();

            data.SetInventory<InventoryModel>(inventory);
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, InventoryModel am)
        {
            var data = new InventoryData();

            data.ChangeInventoryById<InventoryModel>(am);
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = new InventoryData();

            data.DeleteInventoryById(id);
        }
    }
}
