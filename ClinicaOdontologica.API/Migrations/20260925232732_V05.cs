using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaOdontologica.API.Migrations
{
    /// <inheritdoc />
    public partial class V05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE citas CASCADE;");

            // Borramos la columna incompatible de tipo hora
            migrationBuilder.DropColumn(
                name: "fecha_cita",
                table: "citas");

            // Creamos la columna nueva con el tipo timestamp correcto
            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_cita",
                table: "citas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_cita",
                table: "citas",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}