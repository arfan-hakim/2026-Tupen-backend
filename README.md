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

4. ## API Endpoints

### 🏫 Ruangan (Rooms)
- `GET /api/Rooms` : Menampilkan seluruh daftar ruangan.

### 📅 Peminjaman (Bookings)
- `GET /api/Bookings` : Melihat semua riwayat pinjam (bisa filter ?roomName=...&date=...).
- `POST /api/Bookings` : Membuat pengajuan pinjam baru.
- `PATCH /api/Bookings/{id}/status` : Admin menyetujui/menolak pengajuan.
- `DELETE /api/Bookings/{id}` : Menghapus data (Soft Delete).





