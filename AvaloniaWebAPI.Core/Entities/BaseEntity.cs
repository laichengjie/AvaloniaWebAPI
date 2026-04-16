using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaloniaWebAPI.Core.Entities
{
    public abstract class BaseEntity
    {
        [NotMapped]
        public DateTime CreatedAt { get; set; }

        [NotMapped]
        public DateTime? UpdatedAt { get; set; }

        [NotMapped]
        public bool IsDeleted { get; set; }
    }
}