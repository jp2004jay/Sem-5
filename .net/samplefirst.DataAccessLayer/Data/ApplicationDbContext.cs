using Microsoft.EntityFrameworkCore;
using samplefirst.Models;

namespace samplefirst.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<TBL_Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
