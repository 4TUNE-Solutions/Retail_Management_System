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
        public void Post(ArticleModel article)
        {
            var data = new ArticleData();

            try
            {
                data.SetArticle<ArticleModel>(article);
            }
            catch (SqlTypeException)
            {
                article.exp_date = DateTime.Now;
                data.SetArticle<ArticleModel>(article);
            }
            
        }

        // PUT api/<ArticlesController>/5
        [HttpPut("{id}")]
        public void Put(int id, ArticleModel am)
        {
            var data = new ArticleData();

            data.ChangeArticleById<ArticleModel>(am);
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
