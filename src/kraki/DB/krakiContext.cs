using Microsoft.EntityFrameworkCore;
using kraki.Models;
using System.Linq;
using kraki.Extensions;

namespace kraki
{
    public class krakiContext : DbContext
    {
        public krakiContext(DbContextOptions<krakiContext> options) :base(options)
        {
               //constructor
        }
        public DbSet<City> Cities {get; set;}
        public DbSet<Appointment> Appointments {get; set;}
        public DbSet<Doctor> Doctors {get; set;}
        public DbSet<Examination> Examinations {get; set;}
        public DbSet<Hospital> Hospitals {get; set;}
        public DbSet<Patient> Patients {get; set;}

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // ...

    var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        .SelectMany(t => t.GetForeignKeys())
        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

    foreach (var fk in cascadeFKs)
        fk.DeleteBehavior = DeleteBehavior.Restrict;

    base.OnModelCreating(modelBuilder);
    modelBuilder.Seed();
} } }
