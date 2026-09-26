using Microsoft.EntityFrameworkCore;

public class ClinicaOdontologicaAPIContext(DbContextOptions<ClinicaOdontologicaAPIContext> options) : DbContext(options)
{
    public DbSet<ClinicaOdontologicaModelos.Cita> Citas { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Consultorio> Consultorios { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.DetalleCita> DetalleCitas { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Especialidad> Especialidades { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Factura> Facturas { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.HistorialMedico> HistorialMedicos { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Odontologo> Odontologos { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Paciente> Pacientes { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Receta> Recetas { get; set; } = default!;
    public DbSet<ClinicaOdontologicaModelos.Tratamiento> Tratamientos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Fuerza a que la fecha de la cita se mapee correctamente evitando conflictos con 'time without time zone'
        modelBuilder.Entity<ClinicaOdontologicaModelos.Cita>()
            .Property(c => c.FechaCita)
            .HasColumnType("timestamp without time zone");
    }

}
