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

        public DbSet<Project> Project { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Jack" },
                new Student { StudentId = 2, Name = "Alex" }
            );

            //Jack model builders
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 11, Title = "Xtreme Robotics", Description = "Probably one of my favorite projects I did back in high school. Our team would build combat robots and fight them in competitions. We had a meager budget but did the best we could. I remember spending the countless sleepless night working on that robot days before the competition would start. Sometimes we would do very well; other times, we would fail. However, in my senior year, we built & machined our best combat robot. We made it to the final four, which is impressive considering the schools we had to face were trade schools. We even beat some colleges, including UC and Kent state. I made it back from the competition just in time for prom.", StudentId = 1 },
                new Project { ProjectId = 12, Title = "DavBot Project", Description = "The DavBot project, less affectionately known as the Davenport Aviation robot, is a microservice ecosystem that performs various aspects of business automation. I started the project back in 2018, and it has grown ever since. The most interesting module is the automatic web data aggregation service, which provides real-time statistics on the aviation industry and various markets. However, there are other exciting microservices attached to it as well.", StudentId = 1 }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyId = 11, Title = "Lifting", Description = "It might seem weird to put weightlifting as a hobby on this page, but I have a reasonable justification. I’ve been consistently lifting for the past two years. Why, might you ask? Because I honestly need a little endorphin boost in my life. It simply feels great to do. It’s also a fun challenge. It usually works if you plan your meals correctly, build a lifting program that meets your goals and stay dedicated to the routines. Finally, it’s gratifying to see your weight on the bar increase over time, showing you are stronger than you were the previous month (that might be an ego thing). My style of lifting is purely to move heavyweight like a caveman. I wish I had started earlier because I was always working out in high school. I was on the swim and water polo team, where I competed at the state level. I hated lifting back then because I was always so exhausted after practice. However, my mindset on that has changed, and now I enjoy it.", StudentId = 1 },
                new Hobby { HobbyId = 12, Title = "Drumming", Description = "I’m trying to keep up with my theme of not putting all my technical hobbies in here because that would seem redundant for a coding class. I enjoy spending at least 30 minutes a day playing the drums. I’ve played the bass since 4th grade, but I burnt out of that my first year. So the next logical step was to teach myself the drums. It’s a great stress reliever in the winter to bang out some songs when there’s nothing to do in the cold of Ohio. It keeps me in touch with the mind-body connection (I know that sounds weird).", StudentId = 1 }
            );


            //Alex model builders
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = 21,
                    Title = "Secret Santa Bot",
                    Description = "This discord bot I created was made to allow people in a server to select each other randomly for secret Santa. This way who a person received would not be known to a third party allowing for complete anonymity up until the secret Santa gathering.This bot holds a list of users in an array then randomly selects a person in the array excluding the person who called the command.",
                    StudentId = 2
                },
                new Project { ProjectId = 22, Title = "Blender Chess Set", Description = "I recently picked up learning 3d modeling in blender and as a project a made a 3d model of a chess set and board. Each piece was modeled separately then placed inside a new file containing the board where the chess scene presented in the picture above was created and rendered out into a PNG. This was done over a period of a few weeks in my spare time.", StudentId = 2 }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyId = 21, Title = "Video Games", Description = "In my free time I regularly play video games by myself or with my friends. I started playing video games when I was young, with my first console being the PlayStation 1. Over the years I've gotten more into playing video games especially ones that I can play online with my friends. There's not really a genre of game I typically stray away from but for some reason my favorite games are simulator games.", StudentId = 2 },
                new Hobby
                {
                    HobbyId = 22,
                    Title = "Biking",
                    Description = " When I want to take a break from sitting around playing games, I like to go biking. Every once in a while, I'll take a bike trip with my friends to East Fork or some park with a bike trail.If no one else is available, I like to just take my bike out and ride around my neighborhood while I listen to some music or a podcast.",
                    StudentId = 2
                }
            );

        }
    }
}