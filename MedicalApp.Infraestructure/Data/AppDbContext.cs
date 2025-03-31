using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MedicalApp.Domain.Authentication;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infraestructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<Patient> Patients { get; set; }
        public DbSet<RefreshToken> RefreshTokens {get; set;}
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<HorarioConsulta> HorarioConsultas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Sustitucion> Sustituciones { get; set; }
        public DbSet<Vacacion> Vacaciones { get; set; }


    }
}
