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

}
