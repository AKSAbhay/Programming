namespace MvcBinding.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int productID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}