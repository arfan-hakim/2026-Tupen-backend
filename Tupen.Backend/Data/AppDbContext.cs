using Microsoft.EntityFrameworkCore;
using Tupen.Backend.Models;

namespace Tupen.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tanggal statis agar tidak error saat migrasi (DoD Compliance)
            DateTime staticDate = new DateTime(2026, 2, 11, 0, 0, 0, DateTimeKind.Utc);

            // Menambahkan data awal untuk tabel Rooms (15 Ruangan)
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "A.101", Name = "Ruang Teori A1", Capacity = 40, Description = "Lantai 1, Gedung A", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 2, RoomNumber = "A.102", Name = "Ruang Teori A2", Capacity = 40, Description = "Lantai 1, Gedung A", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 3, RoomNumber = "A.201", Name = "Lab Komputer A1", Capacity = 30, Description = "Lantai 2, Gedung A", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 4, RoomNumber = "A.202", Name = "Lab Komputer A2", Capacity = 30, Description = "Lantai 2, Gedung A", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 5, RoomNumber = "A.301", Name = "Aula Mini Gedung A", Capacity = 60, Description = "Lantai 3, Gedung A", IsAvailable = true, CreatedAt = staticDate },

                new Room { Id = 6, RoomNumber = "B.101", Name = "Ruang Teori B1", Capacity = 40, Description = "Lantai 1, Gedung B", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 7, RoomNumber = "B.102", Name = "Ruang Teori B2", Capacity = 40, Description = "Lantai 1, Gedung B", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 8, RoomNumber = "B.201", Name = "Studio Gambar B1", Capacity = 25, Description = "Lantai 2, Gedung B", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 9, RoomNumber = "B.202", Name = "Studio Gambar B2", Capacity = 25, Description = "Lantai 2, Gedung B", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 10, RoomNumber = "B.305", Name = "Lab Komputer B3", Capacity = 35, Description = "Lantai 3, Gedung B", IsAvailable = true, CreatedAt = staticDate },

                new Room { Id = 11, RoomNumber = "C.101", Name = "Ruang Teori C1", Capacity = 45, Description = "Lantai 1, Gedung C", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 12, RoomNumber = "C.102", Name = "Ruang Teori C2", Capacity = 45, Description = "Lantai 1, Gedung C", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 13, RoomNumber = "C.201", Name = "Ruang Rapat C1", Capacity = 20, Description = "Lantai 2, Gedung C", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 14, RoomNumber = "C.202", Name = "Ruang Rapat C2", Capacity = 20, Description = "Lantai 2, Gedung C", IsAvailable = true, CreatedAt = staticDate },
                new Room { Id = 15, RoomNumber = "C.301", Name = "Aula Serbaguna", Capacity = 100, Description = "Lantai 3, Gedung C", IsAvailable = true, CreatedAt = staticDate }
            );
        }
    }
}