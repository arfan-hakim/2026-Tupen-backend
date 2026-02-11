using System.ComponentModel.DataAnnotations;

namespace Tupen.Backend.DTOs
{
    public class BookingRequest
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public string Purpose { get; set; } = string.Empty;
    }
}