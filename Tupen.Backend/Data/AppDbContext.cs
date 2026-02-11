using Microsoft.EntityFrameworkCore;
using Tupen.Backend.Models;

namespace Tupen.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Mendaftarkan tabel ke database
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}