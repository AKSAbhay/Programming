namespace MvcBinding.Models
{
    using System.Data.Entity;
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("ProductsConnection")
        {

        }
        public DbSet<Product> productsTable { get; set; }
    }
}