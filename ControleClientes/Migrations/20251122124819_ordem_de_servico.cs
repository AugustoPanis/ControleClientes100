using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleClientes.Migrations
{
    /// <inheritdoc />
    public partial class ordem_de_servico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "OsItens");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "OsItens",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
