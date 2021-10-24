using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaAutomatizada.Domain.Migrations
{
    public partial class CreateTblHorario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTanda = table.Column<int>(type: "int", nullable: false),
                    IdAgenda = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TandasId = table.Column<int>(type: "int", nullable: true),
                    AgendaId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horario_Agendas_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Horario_Tandas_TandasId",
                        column: x => x.TandasId,
                        principalTable: "Tandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horario_AgendaId",
                table: "Horario",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_TandasId",
                table: "Horario",
                column: "TandasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horario");
        }
    }
}
