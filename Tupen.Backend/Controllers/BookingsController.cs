using Microsoft.AspNetCore.Mvc;
using Tupen.Backend.Data;
using Tupen.Backend.Models;
using Tupen.Backend.DTOs;
using Microsoft.EntityFrameworkCore;

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

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingResponse>>> GetBookings()
        {
            var bookings = await _context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room)
                .OrderByDescending(b => b.CreatedAt)
                .Select(b => new BookingResponse
                {
                    Id = b.Id,
                    RoomName = b.Room != null ? b.Room.Name : "N/A",
                    UserName = b.User != null ? b.User.FullName : "N/A",
                    StartTime = b.StartTime,
                    EndTime = b.EndTime,
                    Status = b.Status
                })
                .ToListAsync();

            return Ok(bookings);
        }
    }
}