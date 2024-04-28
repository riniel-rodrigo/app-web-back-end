using Microsoft.EntityFrameworkCore;

namespace mf_dev_back_end.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<Vehicle> Vehicles { get; set; }

    }
}