using System;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class GroupFloat
    {
        [Key]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "Please enter a name of contact.")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter starting point.")]
        public string? StartPoint { get; set; }

        [Required(ErrorMessage = "Please enter starting point.")]
        public string? StopPoint { get; set; }

        [Required(ErrorMessage = "Please enter starting point.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter a date.")]
        public string? Date { get; set; }

        [Required(ErrorMessage = "Please enter a time.")]
        public string? Time { get; set; }

        public string Slug =>
            Contact?.Replace(' ', '-').ToLower() + '-' + Location?.ToString();

    }
}