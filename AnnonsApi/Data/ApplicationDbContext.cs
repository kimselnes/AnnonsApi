using AnnonsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnnonsApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {            
        }

        public DbSet<Ad> Ads { get; set; }
    }
}
