# Changelog - Tupen Backend

Semua perubahan signifikan pada proyek ini akan dicatat dalam file ini.

## [1.0.0] - 2026-02-12
### Added
- Feature: Validation Rules (Pencegahan double booking pada jam yang sama).
- Feature: Status Management (Admin dapat mengubah status Approved/Rejected).
- Feature: Soft Delete (Implementasi kolom IsDeleted pada Booking).
- API: Rooms Controller (Menampilkan daftar 15 ruangan).
- Docs: Technical README (Panduan instalasi dan daftar endpoint).

## [0.2.0] - 2026-02-11
### Added
- Logic: Add Booking (Create pengajuan pinjam baru).
- Logic: Get All Bookings (Read daftar pinjam dengan relasi User & Room).
- Logic: Filter & Search Booking (Pencarian berdasarkan nama ruangan dan tanggal).
- Migration: Booking Migration (Relasi Foreign Key ke User dan Room).

## [0.1.0] - 2026-02-10
### Added
- Project Setup: Inisialisasi .NET 8 Web API.
- Database: Konfigurasi PostgreSQL dan AppDbContext.
- Models: Entitas User dan Room.
- Seeding: Data awal 15 ruangan (A.101 - C.301).