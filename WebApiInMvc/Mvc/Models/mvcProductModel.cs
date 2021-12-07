using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class mvcProductModel
    {
        public int productId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}