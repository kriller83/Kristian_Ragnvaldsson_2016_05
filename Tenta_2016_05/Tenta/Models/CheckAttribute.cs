using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class CheckAttribute
    {
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
            }

            public override string FormatErrorMessage(string field)
            {
                return "The productnumber must start with 'p-";
            }
        }
    }
}