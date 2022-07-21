using System;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class Route
    {
        public int RouteId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(30)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        [StringLength(30)]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter a starting point.")]
        [StringLength(30)]
        public string? StartPoint { get; set; }

        [Required(ErrorMessage = "Please enter a stopping point.")]
        [StringLength(30)]
        public string? StopPoint { get; set; }

        [Required(ErrorMessage = "Please enter a type.")]
        [StringLength(30)]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Please enter how many miles.")]
        [Range(0.1, 20.0, ErrorMessage = "Miles needs to be between 0.1 and 20.0.")]
        public double? Miles { get; set; }

        [Required(ErrorMessage = "Please enter date you went on route.")]
        [StringLength(30)]
        public string? Date { get; set; }

        [Required(ErrorMessage = "Please enter water level.")]
        [StringLength(30)]
        public string? Level { get; set; }

        [Required(ErrorMessage = "Please enter a rating. 1 being lowest and 5 being highest.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5. 1 being lowest and 5 being highest.")]
        public int? Rating { get; set; }



        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Location?.ToString();
    }
}

