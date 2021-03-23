using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EscuelaPeñaNieto.Models
{
    public class ControlDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-MARTIN; initial catalog=DB_Escuela; integrated security=true")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(loggerFactory);
        }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) =>
            category == DbLoggerCategory.Database.Command.Name &&
            level == LogLevel.Information).AddConsole();
        });

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Alumno> Alumno { get; set; }

    }
}
