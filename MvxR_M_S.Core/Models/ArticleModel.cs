using System;

namespace MvxR_M_S.Core.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Barcode2 { get; set; }
        public string Barcode3 { get; set; }
        public string Barcode4 { get; set; }
        public string ArticleName { get; set; }
        public int TaxId { get; set; }
        public string Description { get; set; }
        public string ArticleNote { get; set; }
        public DateTime ExpDate { get; set; }
        public int SupplierId { get; set; }
        public bool IsService { get; set; }
        public int Discount { get; set; }
    }
}
