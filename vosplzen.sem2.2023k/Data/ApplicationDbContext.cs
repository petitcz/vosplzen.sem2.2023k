using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vosplzen.sem2._2023k.Data.Model;

namespace vosplzen.sem2._2023k.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Station>()
                .HasIndex(u => u.Title)
                .IsUnique();


        }

        public DbSet<Station> Stations {  get; set; }

        public DbSet<Value> Values { get; set; }

    }
}