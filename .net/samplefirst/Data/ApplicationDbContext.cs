using Microsoft.EntityFrameworkCore;
using samplefirst.Models;

namespace samplefirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
