using System;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class GroupFloat
    {
        [Key]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "Please enter a name of contact.")]
        [StringLength(30)]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(12)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        [StringLength(30)]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter starting point.")]
        [StringLength(30)]
        public string? StartPoint { get; set; }

        [Required(ErrorMessage = "Please enter stopping point.")]
        [StringLength(30)]
        public string? StopPoint { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter a date.")]
        [StringLength(30)]
        public string? Date { get; set; }

        [Required(ErrorMessage = "Please enter a time.")]
        [StringLength(30)]
        public string? Time { get; set; }

        public string Slug =>
            Contact?.Replace(' ', '-').ToLower() + '-' + Location?.ToString();

    }
}
