using System.ComponentModel.DataAnnotations;

namespace Tupen.Backend.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomNumber { get; set; } = string.Empty; // Contoh: A.101

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; // Contoh: Ruang Teori 1

        public int Capacity { get; set; }

        public string Description { get; set; } = string.Empty;

        public bool IsAvailable { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}