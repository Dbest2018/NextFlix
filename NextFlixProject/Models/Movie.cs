using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace NextFlixProject.Models
{
    public class Movie
    {
        //Primary Key
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string MovieName { get; set; } = string.Empty;

        [Required(ErrorMessage ="Enter a year")]
        [Range(1900, 2025, ErrorMessage ="Year must be between 1900 and 2025")]
        public int? Year { get; set; }

        [Required(ErrorMessage ="Pleae enter a rating")]
        [Range(1,5, ErrorMessage ="Rating must be between 1 and 5")]
        public int? Rating { get; set; }

        //Read-only property for the slug
        public string Slug => MovieName?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();

        // Foreign Key Property
        //Your entity classes are easier to work with if you add Fk properties that refer to the PK in the related entity class.
        [Required(ErrorMessage = "Please enter a genre")]
        public string GenreId { get; set; } = string.Empty;

        //Validation Property
        [ValidateNever]
        public Genre Genre { get; set; } = null!;
    }
}
