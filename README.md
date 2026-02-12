# Tupen Backend - Room Booking System

Sistem backend untuk peminjaman ruangan menggunakan .NET 8 dan PostgreSQL.

## Cara Menjalankan Aplikasi
1. **Persiapan Database**:
   - Pastikan PostgreSQL sudah berjalan.
   - Buat database baru bernama `tupen_db` (atau sesuai konfigurasi di `appsettings.json`).
   
2. **Update Database**:
   Jalankan perintah berikut untuk menerapkan migrasi:
   ```bash
   dotnet ef database update

3. **menjalankan aplikasi**
    jalanjkan aplikasi dengan perintah**:
    dotnet run pada terminal atau tekan f5

4. **Daftar Endpoint API Utama**
    GET /api/Rooms - Mendapatkan daftar 15 ruangan.
    GET /api/Rooms/{id} - Mendapatkan detail ruangan tertentu.

    GET /api/Bookings - Menampilkan daftar pinjam (Support Filter roomName & date).
    POST /api/Bookings - Membuat pengajuan peminjaman baru (Validation included).
    PATCH /api/Bookings/{id}/status - Update status (Approved/Rejected) oleh Admin.
    PUT /api/Bookings/{id} - Update data peminjaman.
    DELETE /api/Bookings/{id} - Menghapus data (Soft Delete).

    



