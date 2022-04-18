using System;

namespace FinalProjectWebServerApp.Models
{
    public class Hobby
    {
        public int HobbyId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}