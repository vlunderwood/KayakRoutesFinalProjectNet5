using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace KayakRoutesFinalProject.Models
{
    public class Route
    {
        // EF will instruct the database to automatically generate this value
        public int RouteId { get; set; }

        [contactname]
        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]

        public string? Location { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        public string? StartPoint { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        public string? StopPoint { get; set; }

        [Required(ErrorMessage = "Please enter a type.")]
        public string? Type { get; set; }

        [Required(ErrorMessage = "Please enter how many miles.")]
        public double? Miles { get; set; }

        [Required(ErrorMessage = "Please enter date you went on route.")]
        public string? Date { get; set; }

        [Required(ErrorMessage = "Please enter water level.")]
        public string? Level { get; set; }

        [Required(ErrorMessage = "Please enter a rating. 1 being lowest and 5 being highest.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5. 1 being lowest and 5 being highest.")]
        public int? Rating { get; set; }
       




        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Location?.ToString();
    }
}

