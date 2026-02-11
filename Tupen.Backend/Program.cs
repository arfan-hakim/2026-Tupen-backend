using Microsoft.EntityFrameworkCore;
using Tupen.Backend.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Tambahkan Services (Urutan itu penting)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 2. Daftarkan Koneksi Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 3. Konfigurasi Middleware (Pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Memunculkan UI Swagger di /swagger
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();