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

        // GET: api/Bookings?roomName=A1&date=2026-02-11
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingResponse>>> GetBookings(
            [FromQuery] string? roomName = null,
            [FromQuery] DateTime? date = null)
        {
            // 1. Mulai dengan Queryable (Data belum ditarik dari DB)
            var query = _context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room)
                .AsQueryable();

            // 2. Filter berdasarkan Nama Ruangan (jika diisi)
            if (!string.IsNullOrEmpty(roomName))
            {
                query = query.Where(b => b.Room!.Name.Contains(roomName));
            }

            // 3. Filter berdasarkan Tanggal (jika diisi)
            if (date.HasValue)
            {
                var searchDate = DateTime.SpecifyKind(date.Value.Date, DateTimeKind.Utc);
                query = query.Where(b => b.StartTime.Date == searchDate);
            }

            // 4. Eksekusi Query dan Mapping ke DTO
            var results = await query
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

            return Ok(results);
        }
    }
}