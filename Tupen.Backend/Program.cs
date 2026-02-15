using Microsoft.EntityFrameworkCore;
using Tupen.Backend.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Tambahkan Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// --- TAMBAHKAN CORS DISINI ---
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin()   // Mengizinkan akses dari mana saja (termasuk Live Server kamu)
              .AllowAnyMethod()   // Mengizinkan GET, POST, PATCH, dll.
              .AllowAnyHeader();  // Mengizinkan semua header
    });
});
// -----------------------------

// 2. Daftarkan Koneksi Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 3. Konfigurasi Middleware (Urutan sangat penting!)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// --- AKTIFKAN CORS SEBELUM MAP CONTROLLERS ---
app.UseCors("AllowFrontend");
// --------------------------------------------

// Matikan sementara jika ada error "Failed to determine https port" di terminal
// app.UseHttpsRedirection(); 

app.UseAuthorization();
app.MapControllers();

app.Run();