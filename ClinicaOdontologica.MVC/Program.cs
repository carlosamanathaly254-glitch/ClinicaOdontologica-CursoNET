using ClinicaOdontologica.Consumer;
using ClinicaOdontologicaModelos;
using Microsoft.EntityFrameworkCore;

public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            
            CRUD<Cita>.Endpoint = "https://localhost:7294/api/Citas";
            CRUD<Consultorio>.Endpoint = "https://localhost:7294/api/Consultorios";
            CRUD<DetalleCita>.Endpoint = "https://localhost:7294/api/DetalleCitas";
            CRUD<Especialidad>.Endpoint = "https://localhost:7294/api/Especialidades";
            CRUD<Factura>.Endpoint = "https://localhost:7294/api/Facturas";
            CRUD<HistorialMedico>.Endpoint = "https://localhost:7294/api/HistorialMedicos";
            CRUD<Odontologo>.Endpoint = "https://localhost:7294/api/Odontologos";
            CRUD<Paciente>.Endpoint = "https://localhost:7294/api/Pacientes";
            CRUD<Receta>.Endpoint = "https://localhost:7294/api/Recetas";
            CRUD<Tratamiento>.Endpoint = "https://localhost:7294/api/Tratamientos";


        // Add services to the container.
        builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }

