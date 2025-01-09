using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Vijay Kishor", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "Ajay Monish", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Kabil", DisplayOrder = 3 });

        }
    }
}
