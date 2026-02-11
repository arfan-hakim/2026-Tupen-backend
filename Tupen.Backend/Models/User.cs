using System.ComponentModel.DataAnnotations;

namespace Tupen.Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = "Mahasiswa"; // Contoh: Mahasiswa atau Admin

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}