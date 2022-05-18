using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        // options is the connection string
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        // the Dbset property create a table in database with name "Products".
        public DbSet<Product> Products { get; set; }
    }
}

// Need to add this file to configureServices in STARUP.CS