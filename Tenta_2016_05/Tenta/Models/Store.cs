using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class Store
    {
        [Required]
        public int StoreId { get; set; }
        [Required, StringLength(maximumLength:50, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength:50, MinimumLength = 2)]
        public string Adress { get; set; }
        public List<Product> Products { get; set; }
    }
}