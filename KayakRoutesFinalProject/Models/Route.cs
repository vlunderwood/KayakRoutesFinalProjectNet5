using System;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class Route
    {
        // EF will instruct the database to automatically generate this value
        public int RouteId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter water level.")]
        public string? Level { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }



        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Location?.ToString();
    }
}

