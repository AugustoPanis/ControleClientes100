using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleClientes.Migrations
{
    /// <inheritdoc />
    public partial class clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    UF = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeOs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeOs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CidadeId = table.Column<int>(type: "integer", nullable: false),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Localidade = table.Column<string>(type: "text", nullable: false),
                    Uf = table.Column<string>(type: "text", nullable: false),
                    estadocivil = table.Column<int>(type: "integer", nullable: false),
                    Genero = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValorTotalGeral = table.Column<decimal>(type: "numeric", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Localidade = table.Column<string>(type: "text", nullable: false),
                    Uf = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    statusOs = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OsItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorTotalItem = table.Column<decimal>(type: "numeric", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    OsId = table.Column<int>(type: "integer", nullable: false),
                    TipoOsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OsItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OsItens_OrdemServico_OsId",
                        column: x => x.OsId,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OsItens_TiposDeOs_TipoOsId",
                        column: x => x.TipoOsId,
                        principalTable: "TiposDeOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CidadeId",
                table: "Clientes",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_ClienteId",
                table: "OrdemServico",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_OsItens_OsId",
                table: "OsItens",
                column: "OsId");

            migrationBuilder.CreateIndex(
                name: "IX_OsItens_TipoOsId",
                table: "OsItens",
                column: "TipoOsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OsItens");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "TiposDeOs");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}
