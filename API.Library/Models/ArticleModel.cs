using System;

namespace API.Library.Models
{
    public class ArticleModel
    {
        public int id { get; set; }
        public string barcode { get; set; }
        public string barcode2 { get; set; }
        public string barcode3 { get; set; }
        public string barcode4 { get; set; }
        public string article_name { get; set; }
        public int tax_id { get; set; }
        public string article_description { get; set; }
        public string article_note { get; set; }
        public DateTime exp_date { get; set; }
        public int supplier_id { get; set; }
        public bool is_service { get; set; }
        public int discount { get; set; }
    }
}
