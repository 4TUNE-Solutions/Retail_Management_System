using API.Library.DataAccess;
using API.Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class CorpoBuyerController:ControllerBase
    {
        // GET: api/<CorpoBuyerController>
        [HttpGet]
        public List<CorpoBuyerModel> Get()
        {
            var data = new CorpoBuyerData();

            return data.GetCorpoBuyers();
        }

        // GET api/<CorpoBuyerController>/5
        [HttpGet("{id}")]
        public CorpoBuyerModel Get(int id)
        {
            var data = new CorpoBuyerData();

            return data.GetCorpoBuyerById(id);
        }

        // POST api/<CorpoBuyerController>
        [HttpPost]
        public void Post(CorpoBuyerModel CorpoBuyer)
        {
            var data = new CorpoBuyerData();
            data.SetCorpoBuyer<CorpoBuyerModel>(CorpoBuyer);
        }

        // PUT api/<CorpoBuyerController>/5
        [HttpPut("{id}")]
        public void Put(int id, CorpoBuyerModel cbm)
        {
            var data = new CorpoBuyerData();

            data.ChangeCorpoBuyerById<CorpoBuyerModel>(cbm);
        }

        // DELETE api/<CorpoBuyerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = new CorpoBuyerData();

            data.DeleteCorpoBuyerById(id);
        }
    }
}
