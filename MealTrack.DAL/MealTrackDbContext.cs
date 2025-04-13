using MealTrack.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MealTrack.DAL
{
    /// <summary>
    /// Entity Framework Core ile SQLite veritabanı bağlantı noktası.
    /// </summary>
    public class MealTrackDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<MealLog> MealLogs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mealtrack.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        public MealTrackDbContext()
        {
            Database.EnsureCreated(); // Veritabanı ve tabloyu otomatik oluşturur
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Öğrenci numarası benzersiz olsun
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.StudentNo)
                .IsUnique();

            // RFID Code da benzersiz olabilir
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.RFIDCode)
                .IsUnique();

            // İlk admin kullanıcısı
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "1234",
                    Role = "Admin"
                });
        }
    }
}