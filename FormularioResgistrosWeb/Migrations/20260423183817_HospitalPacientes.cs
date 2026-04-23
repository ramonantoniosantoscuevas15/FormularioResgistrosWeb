using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormularioResgistrosWeb.Migrations
{
    /// <inheritdoc />
    public partial class HospitalPacientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalPacientes",
                columns: table => new
                {
                    pacienteId = table.Column<int>(type: "int", nullable: false),
                    hospitalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalPacientes", x => new { x.hospitalId, x.pacienteId });
                    table.ForeignKey(
                        name: "FK_HospitalPacientes_Hospitales_hospitalId",
                        column: x => x.hospitalId,
                        principalTable: "Hospitales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalPacientes_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalPacientes_pacienteId",
                table: "HospitalPacientes",
                column: "pacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalPacientes");
        }
    }
}
