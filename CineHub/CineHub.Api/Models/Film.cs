using System.ComponentModel.DataAnnotations;

namespace CineHub.Api.Models
{
    public class Film : EntityBase
    {
        [Required(ErrorMessage = "The title is mandatory")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The genre is mandatory")]
        [MaxLength(50, ErrorMessage = "The genre cannot exceed 50 characters.")]
        public string Genre { get; set; }

        [Required]
        [Range(70, 600)]
        public int DurationInMinutes { get; set; }
        
    }
}
