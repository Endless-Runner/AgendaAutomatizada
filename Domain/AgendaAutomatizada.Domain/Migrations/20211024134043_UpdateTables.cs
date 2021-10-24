using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaAutomatizada.Domain.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Agendas_AgendaId",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_Tandas_TandasId",
                table: "Horario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Horario",
                table: "Horario");

            migrationBuilder.DropIndex(
                name: "IX_Horario_AgendaId",
                table: "Horario");

            migrationBuilder.DropIndex(
                name: "IX_Horario_TandasId",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Horario");

            migrationBuilder.DropColumn(
                name: "TandasId",
                table: "Horario");

            migrationBuilder.RenameTable(
                name: "Horario",
                newName: "Horarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Horarios",
                table: "Horarios",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_IdAgenda",
                table: "Horarios",
                column: "IdAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_IdTanda",
                table: "Horarios",
                column: "IdTanda");

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Agendas_IdAgenda",
                table: "Horarios",
                column: "IdAgenda",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Tandas_IdTanda",
                table: "Horarios",
                column: "IdTanda",
                principalTable: "Tandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Agendas_IdAgenda",
                table: "Horarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Tandas_IdTanda",
                table: "Horarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Horarios",
                table: "Horarios");

            migrationBuilder.DropIndex(
                name: "IX_Horarios_IdAgenda",
                table: "Horarios");

            migrationBuilder.DropIndex(
                name: "IX_Horarios_IdTanda",
                table: "Horarios");

            migrationBuilder.RenameTable(
                name: "Horarios",
                newName: "Horario");

            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Horario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TandasId",
                table: "Horario",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Horario",
                table: "Horario",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_AgendaId",
                table: "Horario",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_TandasId",
                table: "Horario",
                column: "TandasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Agendas_AgendaId",
                table: "Horario",
                column: "AgendaId",
                principalTable: "Agendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_Tandas_TandasId",
                table: "Horario",
                column: "TandasId",
                principalTable: "Tandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
