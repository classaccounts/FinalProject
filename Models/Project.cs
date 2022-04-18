using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectWebServerApp.Models
{
    public class Project
    {   
        
        [Key]
        public int ProjectId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

    }
}