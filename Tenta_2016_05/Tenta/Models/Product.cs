using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductText { get; set; }
        public int ProductNumber { get; set; }  
        public double Price { get; set; }
        public int ProductsInStock { get; set; }
        public int StoreId { get; set; }    
    }

}