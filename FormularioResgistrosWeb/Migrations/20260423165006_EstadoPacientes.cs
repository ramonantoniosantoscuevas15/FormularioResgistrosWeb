using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormularioResgistrosWeb.Migrations
{
    /// <inheritdoc />
    public partial class EstadoPacientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoPacientes",
                columns: table => new
                {
                    pacienteId = table.Column<int>(type: "int", nullable: false),
                    estadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPacientes", x => new { x.pacienteId, x.estadoId });
                    table.ForeignKey(
                        name: "FK_EstadoPacientes_Estados_estadoId",
                        column: x => x.estadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstadoPacientes_Pacientes_pacienteId",
                        column: x => x.pacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstadoPacientes_estadoId",
                table: "EstadoPacientes",
                column: "estadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoPacientes");
        }
    }
}
