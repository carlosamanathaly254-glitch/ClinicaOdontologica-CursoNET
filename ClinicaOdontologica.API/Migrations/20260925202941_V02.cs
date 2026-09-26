using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaOdontologica.API.Migrations
{
    /// <inheritdoc />
    public partial class V02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistorialesMedicos_id_paciente",
                table: "HistorialesMedicos");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesMedicos_id_paciente",
                table: "HistorialesMedicos",
                column: "id_paciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistorialesMedicos_id_paciente",
                table: "HistorialesMedicos");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialesMedicos_id_paciente",
                table: "HistorialesMedicos",
                column: "id_paciente",
                unique: true);
        }
    }
}
