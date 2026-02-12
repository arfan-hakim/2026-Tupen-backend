using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tupen.Backend.Data;
using Tupen.Backend.Models;

namespace Tupen.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RoomsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            // Mengambil semua daftar ruangan dari database
            return await _context.Rooms.OrderBy(r => r.RoomNumber).ToListAsync();
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);

            if (room == null)
            {
                return NotFound(new { message = "Ruangan tidak ditemukan." });
            }

            return room;
        }
    }
}