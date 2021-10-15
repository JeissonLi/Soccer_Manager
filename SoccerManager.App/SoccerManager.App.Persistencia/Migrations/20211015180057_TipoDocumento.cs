using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerManager.App.Persistencia.Migrations
{
    public partial class TipoDocumento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Tipo_Documento_tipo_documentoId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_Documento",
                table: "Tipo_Documento");

            migrationBuilder.RenameTable(
                name: "Tipo_Documento",
                newName: "Tipos_Documentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_Documentos",
                table: "Tipos_Documentos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Tipos_Documentos_tipo_documentoId",
                table: "Personas",
                column: "tipo_documentoId",
                principalTable: "Tipos_Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Tipos_Documentos_tipo_documentoId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_Documentos",
                table: "Tipos_Documentos");

            migrationBuilder.RenameTable(
                name: "Tipos_Documentos",
                newName: "Tipo_Documento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_Documento",
                table: "Tipo_Documento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Tipo_Documento_tipo_documentoId",
                table: "Personas",
                column: "tipo_documentoId",
                principalTable: "Tipo_Documento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
