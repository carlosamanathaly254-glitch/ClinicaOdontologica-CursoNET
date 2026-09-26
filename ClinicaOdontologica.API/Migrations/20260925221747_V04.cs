using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaOdontologica.API.Migrations
{
    /// <inheritdoc />
    public partial class V04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_cita",
                table: "citas",
                nullable: false,
                oldClrType: typeof(TimeOnly)
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "fecha_cita",
                table: "citas",
                nullable: false,
                oldClrType: typeof(DateTime)
                );
        }
    }
}
