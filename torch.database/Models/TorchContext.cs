using System;
using Microsoft.EntityFrameworkCore;


namespace torch.database.Models
{
    public class TorchContext : DbContext
    {
        public TorchContext(DbContextOptions<TorchContext> options) :  base(options)
        {
            
        }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>(e =>
            {
                e.HasKey(x => x.id).IsClustered(false);

                e.HasIndex(x => x.clusterId).IsUnique(true).IsClustered(true);
            });
        }

    }
}
