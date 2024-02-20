using Bulky.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bulky.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var villasForSeed = new List<Villa>() { new Villa()
                                                   {
                                                      Id=1,
                                                      Name="Sky",
                                                      Description="Full of option",
                                                      ImageUrl="https://placehold.co/600*401",
                                                      Occupancy=4,
                                                      Price=200,
                                                      Sqft=550
                                                   },
                                                   new Villa
                                                   {
                                                      Id=2,
                                                      Name="Blue Sky",
                                                      Description="Full of option",
                                                      ImageUrl="https://placehold.co/600*401",
                                                      Occupancy=4,
                                                      Price=300,
                                                      Sqft=550
                                                   }

            };
            modelBuilder.Entity<Villa>().HasData(villasForSeed);
        }

        public DbSet<Villa> Villas { get; set; }
    }
}
