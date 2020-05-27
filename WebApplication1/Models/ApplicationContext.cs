using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //Database.Migrate();
        }

        public DbSet<HistorySale> HistorySales { get; set; }
    }
}