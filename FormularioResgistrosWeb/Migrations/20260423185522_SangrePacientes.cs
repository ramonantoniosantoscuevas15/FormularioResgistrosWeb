using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormularioResgistrosWeb.Migrations
{
    /// <inheritdoc />
    public partial class SangrePacientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SangrePacientes",
                columns: table => new
                {
                    pacienteId = table.Column<int>(type: "int", nullable: false),
                    sangreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SangrePacientes", x => new { x.pacienteId, x.sangreId });
                    table.ForeignKey(
                        name: "FK_SangrePacientes_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SangrePacientes_TipoSaguineos_sangreId",
                        column: x => x.sangreId,
                        principalTable: "TipoSaguineos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SangrePacientes_sangreId",
                table: "SangrePacientes",
                column: "sangreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SangrePacientes");
        }
    }
}
