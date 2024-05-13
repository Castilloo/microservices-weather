using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudWeather.Temperature.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CloudWeather.Report.DataAccess
{
    public class WeatherReportDbContext :DbContext
    {
        public WeatherReportDbContext() { }
        public WeatherReportDbContext(DbContextOptions<WeatherReportDbContext> opts) : base(opts) { }
        public DbSet<WeatherReport> WeatherReport { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableNames(modelBuilder);
        }

        public static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherReport>(b => { b.ToTable("weather_report"); });
        }
    }
}