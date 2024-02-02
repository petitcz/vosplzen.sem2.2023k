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
        public DbSet<Station> Stations {  get; set; }

        public DbSet<Value> Values { get; set; }

    }
}