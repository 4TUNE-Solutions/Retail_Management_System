using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R_M_S_API.Library.DataAccess;
using R_M_S_API.Library.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace R_M_S_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        // GET: api/<ArticlesController>
        [HttpGet]
        public List<ArticleModel> Get()
        {
            var data = new ArticleData();

            return data.GetArticles();
        }

        // GET api/<ArticlesController>/5
        [HttpGet("{id}")]
        public ArticleModel Get(int id)
        {
            var data = new ArticleData();

            return data.GetArticleById(id);
        }

        // POST api/<ArticlesController>
        [HttpPost]
        public void Post(string Barcode, string Barcode2, string Barcode3, string Barcode4,
            string ArticleName, int TaxId, string Description, string ArticleNote, DateTime ExpDate,
            int SupplierId, bool IsService, int Discount)
        {
            var data = new ArticleData();

            try
            {
                data.SetArticle(Barcode, Barcode2, Barcode3, Barcode4,
                    ArticleName, TaxId, Description, ArticleNote, ExpDate,
                    SupplierId, IsService, Discount);
            }
            catch (SqlTypeException)
            {
                data.SetArticle(Barcode, Barcode2, Barcode3, Barcode4,
                    ArticleName, TaxId, Description, ArticleNote, DateTime.Now,
                    SupplierId, IsService, Discount);
            }
            
        }

        // PUT api/<ArticlesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticlesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = new ArticleData();

            data.DeleteArticleById(id);
        }
    }
}
