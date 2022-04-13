using System;

namespace FinalProjectWebServerApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Student Student { get; set; }

    }
}