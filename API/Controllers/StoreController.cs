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
    public class StoreController : ControllerBase
    {
        [HttpGet]
        public List<StoreModel> Get()
        {
            var data = new StoreData();

            return data.GetStores();
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public StoreModel Get(int id)
        {
            var data = new StoreData();

            return data.GetStoreById(id);
        }

        // POST api/<StoreController>
        [HttpPost]
        public void Post(StoreModel store)
        {
            var data = new StoreData();

            data.SetStore<StoreModel>(store);
        }

        // PUT api/<StoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, StoreModel am)
        {
            var data = new StoreData();

            data.ChangeStoreById<StoreModel>(am);
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = new StoreData();

            data.DeleteStoreById(id);
        }
    }
}
