using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormularioResgistrosWeb.Migrations
{
    /// <inheritdoc />
    public partial class DoctorPacientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorPacientes",
                columns: table => new
                {
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    pacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPacientes", x => new { x.doctorId, x.pacienteId });
                    table.ForeignKey(
                        name: "FK_DoctorPacientes_Doctores_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPacientes_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPacientes_pacienteId",
                table: "DoctorPacientes",
                column: "pacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorPacientes");
        }
    }
}
