using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_aspnetcore.Migrations
{
    public partial class A_Funcionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeEnd",
                table: "Funcionarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeEnd",
                table: "Funcionarios");
        }
    }
}
