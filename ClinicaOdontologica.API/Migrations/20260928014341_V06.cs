using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaOdontologica.API.Migrations
{
    /// <inheritdoc />
    public partial class V06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_tratamiento",
                table: "DetalleCitas",
                type: "integer",
                nullable: true,
                defaultValue: null);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCitas_id_tratamiento",
                table: "DetalleCitas",
                column: "id_tratamiento");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleCitas_Tratamientos_id_tratamiento",
                table: "DetalleCitas",
                column: "id_tratamiento",
                principalTable: "Tratamientos",
                principalColumn: "IdTratamiento",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleCitas_Tratamientos_id_tratamiento",
                table: "DetalleCitas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleCitas_id_tratamiento",
                table: "DetalleCitas");

            migrationBuilder.DropColumn(
                name: "id_tratamiento",
                table: "DetalleCitas");
        }
    }
}
