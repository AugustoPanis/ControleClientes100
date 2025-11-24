using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleClientes.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "Localidade",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "OrdemServico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Localidade",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "OrdemServico",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
