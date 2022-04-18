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

        public DbSet<Hobby> Project { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Jack" },
                new Student { StudentId = 2, Name = "Alex" }
            );

            //Jack model builders
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 11 , Title = "JACK", Description = "JACK", StudentId = 1 },
                new Project { ProjectId = 12 , Title = "JACK", Description = "JACK", StudentId = 1 }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyId = 11 , Title = "JACK", Description = "JACK", StudentId = 1 },
                new Hobby { HobbyId = 12 , Title = "JACK", Description = "JACK", StudentId = 1 }
            );


            //Alex model builders
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 21 , Title = "ALEX", Description = "ALEX", StudentId = 2 },
                new Project { ProjectId = 22 , Title = "ALEX", Description = "ALEX", StudentId = 2 }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyId = 21 , Title = "ALEX", Description = "ALEX", StudentId = 2 },
                new Hobby { HobbyId = 22 , Title = "ALEX", Description = "ALEX", StudentId = 2 }
            );

        }
    }
}