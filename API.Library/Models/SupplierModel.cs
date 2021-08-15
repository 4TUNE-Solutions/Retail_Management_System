using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Library.Models
{
    public class SupplierModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string fax { get; set; }
        public string website { get; set; }
        public string contact_person { get; set; }
        public string bank_account_number1 { get; set; }
        public string bank_account_number2 { get; set; }
        public string TIN { get; set; }
        public string UCID { get; set;}
        public bool taxpayer { get; set; }
    }
}
