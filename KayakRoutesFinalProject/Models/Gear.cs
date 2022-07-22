using System;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class Gear
    {
        public int GearId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter condition.")]
        public string? Condition { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        public string? Price { get; set; }

        public string Slug =>
            Contact?.Replace(' ', '-').ToLower() + '-' + Phone?.ToString();
    }
}
