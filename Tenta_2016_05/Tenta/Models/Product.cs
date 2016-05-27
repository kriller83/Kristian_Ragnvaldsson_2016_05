using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
        [Required, StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength: 200, MinimumLength = 5)]
        public string ProductText { get; set; }
        [Required, CheckAttributeInStore]
        public string ProductNumber { get; set; }
        [Required, Range(0, 20000)]
        public double Price { get; set; }
        [Required, Range(0,2000)]
        public int ProductsInStock { get; set; }
        public int StoreId { get; set; }    
    }
    public class CheckAttributeInStore : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            var checkWord = value.ToString().ToLower();
            return !checkWord.Contains("p-");
            //if(!value == "p-")
            //    throw new ValidationException("Must start with 'p-' ");
        }

        public override string FormatErrorMessage(string field)
        {
            return "The productnumber must start with 'p-' and then 3-5 digits";
        }
    }
}