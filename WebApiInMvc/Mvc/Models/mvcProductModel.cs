using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class mvcProductModel
    {
        public int productId { get; set; }
        [Required(ErrorMessage ="This Field is required !")]
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}