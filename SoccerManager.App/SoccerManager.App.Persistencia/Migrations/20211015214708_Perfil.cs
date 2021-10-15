using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerManager.App.Persistencia.Migrations
{
    public partial class Perfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Perfil_perfilId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.RenameTable(
                name: "Perfil",
                newName: "Perfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfiles",
                table: "Perfiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Perfiles_perfilId",
                table: "Personas",
                column: "perfilId",
                principalTable: "Perfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Perfiles_perfilId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfiles",
                table: "Perfiles");

            migrationBuilder.RenameTable(
                name: "Perfiles",
                newName: "Perfil");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Perfil_perfilId",
                table: "Personas",
                column: "perfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
