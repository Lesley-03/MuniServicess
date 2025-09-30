using System;
using System.ComponentModel.DataAnnotations;

namespace MuniServices.Models
{
    public class Issue
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public string? MediaPath { get; set; }

        public string Status { get; set; } = "Received";

        public DateTime SubmittedAt { get; set; } = DateTime.Now;

        public string? Feedback { get; set; }

        public int? Rating { get; set; }
    }
}