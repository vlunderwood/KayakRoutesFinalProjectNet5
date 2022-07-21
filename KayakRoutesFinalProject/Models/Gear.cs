using System;
using System.ComponentModel.DataAnnotations;

namespace KayakRoutesFinalProject.Models
{
    public class Gear
    {
        public int GearId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(30)]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(12)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter condition.")]
        [StringLength(30)]
        public string? Condition { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        [StringLength(50)]
        public string? Price { get; set; }

        public string Slug =>
            Contact?.Replace(' ', '-').ToLower() + '-' + Phone?.ToString();
    }
}
