using System;
using System.Collections.Generic;
using System.Text;

namespace R_M_S_API.Library.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string ArticleName { get; set; }
        public int TaxId { get; set; }
        public string Description { get; set; }
        public string ArticleNote { get; set; }
        public DateTime ExpDate { get; set; }
        public int SupplierId { get; set; }
        public bool Service { get; set; }
        public int Discount { get; set; }
    }
}
