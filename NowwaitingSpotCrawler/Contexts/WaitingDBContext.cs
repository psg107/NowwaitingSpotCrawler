using Microsoft.EntityFrameworkCore;
using NowwaitingSpotCrawler.Entities;

namespace NowwaitingSpotCrawler.Contexts
{
    public class WaitingDBContext : DbContext
    {
        private readonly string connectionString;

        public WaitingDBContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }

        public DbSet<SpotEntity> Spots { get; set; }
    }
}
