using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Infra.Config;

public class DbConfig:DbContext
{
    public DbConfig(DbContextOptions<DbConfig> options) : base(options) { }

    public DbSet<Emotional> Emotionals { get; set; }
    public DbSet<Patient> Patients { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Patient>()
            .HasMany(p => p.Emotional)
            .WithOne(e => e.Patient)
            .HasForeignKey(e => e.PatientId);

    }
}
