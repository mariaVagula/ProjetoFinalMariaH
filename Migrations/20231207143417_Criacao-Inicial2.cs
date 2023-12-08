using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalMariaH.Migrations
{
    public partial class CriacaoInicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "ProcedimentoRealizado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "ProcedimentoRealizado",
                type: "int",
                nullable: true);
        }
    }
}
