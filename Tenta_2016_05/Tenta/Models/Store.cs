using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Product> Products { get; set; }
    }
}