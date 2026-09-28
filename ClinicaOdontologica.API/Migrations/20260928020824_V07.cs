using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaOdontologica.API.Migrations
{
    /// <inheritdoc />
    public partial class V07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleCitas_Tratamientos_id_tratamiento",
                table: "DetalleCitas");

            migrationBuilder.AlterColumn<int>(
                name: "id_tratamiento",
                table: "DetalleCitas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleCitas_Tratamientos_id_tratamiento",
                table: "DetalleCitas",
                column: "id_tratamiento",
                principalTable: "Tratamientos",
                principalColumn: "IdTratamiento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleCitas_Tratamientos_id_tratamiento",
                table: "DetalleCitas");

            migrationBuilder.AlterColumn<int>(
                name: "id_tratamiento",
                table: "DetalleCitas",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleCitas_Tratamientos_id_tratamiento",
                table: "DetalleCitas",
                column: "id_tratamiento",
                principalTable: "Tratamientos",
                principalColumn: "IdTratamiento",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
