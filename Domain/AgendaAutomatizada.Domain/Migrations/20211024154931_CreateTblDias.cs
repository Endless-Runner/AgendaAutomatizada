using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaAutomatizada.Domain.Migrations
{
    public partial class CreateTblDias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idDia",
                table: "Horarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_idDia",
                table: "Horarios",
                column: "idDia");

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Dias_idDia",
                table: "Horarios",
                column: "idDia",
                principalTable: "Dias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Dias_idDia",
                table: "Horarios");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropIndex(
                name: "IX_Horarios_idDia",
                table: "Horarios");

            migrationBuilder.DropColumn(
                name: "idDia",
                table: "Horarios");
        }
    }
}
