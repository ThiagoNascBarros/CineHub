using System.ComponentModel.DataAnnotations;

namespace CineHub.Api.Models
{
    public abstract class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
