using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Persistence.Migrations
{
    public partial class Update10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pessoa_cidade_CidadeId",
                table: "pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cidade",
                table: "cidade");

            migrationBuilder.RenameTable(
                name: "cidade",
                newName: "cidades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cidades",
                table: "cidades",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "carros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome_carros = table.Column<string>(type: "text", nullable: true),
                    ano_carros = table.Column<int>(type: "integer", nullable: false),
                    modelo_carros = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carros", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_pessoa_cidades_CidadeId",
                table: "pessoa",
                column: "CidadeId",
                principalTable: "cidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pessoa_cidades_CidadeId",
                table: "pessoa");

            migrationBuilder.DropTable(
                name: "carros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cidades",
                table: "cidades");

            migrationBuilder.RenameTable(
                name: "cidades",
                newName: "cidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cidade",
                table: "cidade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pessoa_cidade_CidadeId",
                table: "pessoa",
                column: "CidadeId",
                principalTable: "cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
