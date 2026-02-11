using Microsoft.AspNetCore.Mvc;
using Tupen.Backend.Data;
using Tupen.Backend.Models;
using Tupen.Backend.DTOs;

namespace Tupen.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Bookings
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(BookingRequest request)
        {
            // 1. Map DTO ke Entity
            var booking = new Booking
            {
                UserId = request.UserId,
                RoomId = request.RoomId,
                StartTime = request.StartTime.ToUniversalTime(),
                EndTime = request.EndTime.ToUniversalTime(),
                Purpose = request.Purpose,
                Status = "Pending",
                CreatedAt = DateTime.UtcNow
            };

            // 2. Simpan ke Database
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostBooking), new { id = booking.Id }, booking);
        }
    }
}