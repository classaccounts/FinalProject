using FinalProjectWebServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectWebServerApp.Models
{
    public class AboutContext : DbContext
    {
        public AboutContext(DbContextOptions<AboutContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Hobby> Hobby { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Jack" },
                new Student { StudentId = 2, Name = "Alex" }
            );

        }
    }
}