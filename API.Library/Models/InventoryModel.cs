using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Library.Models
{
    class InventoryModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string mobile2 { get; set; }
        public string mobile3 { get; set; }
        public bool operating { get; set; }
    }
}
