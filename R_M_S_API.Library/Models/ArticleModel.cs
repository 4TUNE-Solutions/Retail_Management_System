using System;
using System.Collections.Generic;
using System.Text;

namespace R_M_S_API.Library.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Barcode2 { get; set; }
        public string Barcode3 { get; set; }
        public string Barcode4 { get; set; }
        public string Article_name { get; set; }
        public int Tax_id { get; set; }
        public string Description { get; set; }
        public string Article_note { get; set; }
        public DateTime Exp_date { get; set; }
        public int Supplier_id { get; set; }
        public bool Service { get; set; }
        public int Discount { get; set; }
    }
}
