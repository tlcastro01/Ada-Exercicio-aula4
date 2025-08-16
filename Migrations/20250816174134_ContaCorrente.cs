using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula4_exercicio.Migrations
{
    /// <inheritdoc />
    public partial class ContaCorrente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaCorrente",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AgenciaCGC = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Saldo = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaCorrente", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_ContaCorrente_Agencias_AgenciaCGC",
                        column: x => x.AgenciaCGC,
                        principalTable: "Agencias",
                        principalColumn: "CGC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaCorrente_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaCorrente_AgenciaCGC",
                table: "ContaCorrente",
                column: "AgenciaCGC");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCorrente_ClienteId",
                table: "ContaCorrente",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaCorrente");
        }
    }
}
