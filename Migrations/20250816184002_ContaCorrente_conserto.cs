using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula4_exercicio.Migrations
{
    /// <inheritdoc />
    public partial class ContaCorrente_conserto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContaCorrente_Agencias_AgenciaCGC",
                table: "ContaCorrente");

            migrationBuilder.DropForeignKey(
                name: "FK_ContaCorrente_Clientes_ClienteId",
                table: "ContaCorrente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContaCorrente",
                table: "ContaCorrente");

            migrationBuilder.RenameTable(
                name: "ContaCorrente",
                newName: "ContasCorrentes");

            migrationBuilder.RenameIndex(
                name: "IX_ContaCorrente_ClienteId",
                table: "ContasCorrentes",
                newName: "IX_ContasCorrentes_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_ContaCorrente_AgenciaCGC",
                table: "ContasCorrentes",
                newName: "IX_ContasCorrentes_AgenciaCGC");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContasCorrentes",
                table: "ContasCorrentes",
                column: "Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_Agencias_AgenciaCGC",
                table: "ContasCorrentes",
                column: "AgenciaCGC",
                principalTable: "Agencias",
                principalColumn: "CGC",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_Clientes_ClienteId",
                table: "ContasCorrentes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_Agencias_AgenciaCGC",
                table: "ContasCorrentes");

            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_Clientes_ClienteId",
                table: "ContasCorrentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContasCorrentes",
                table: "ContasCorrentes");

            migrationBuilder.RenameTable(
                name: "ContasCorrentes",
                newName: "ContaCorrente");

            migrationBuilder.RenameIndex(
                name: "IX_ContasCorrentes_ClienteId",
                table: "ContaCorrente",
                newName: "IX_ContaCorrente_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_ContasCorrentes_AgenciaCGC",
                table: "ContaCorrente",
                newName: "IX_ContaCorrente_AgenciaCGC");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContaCorrente",
                table: "ContaCorrente",
                column: "Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_ContaCorrente_Agencias_AgenciaCGC",
                table: "ContaCorrente",
                column: "AgenciaCGC",
                principalTable: "Agencias",
                principalColumn: "CGC",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContaCorrente_Clientes_ClienteId",
                table: "ContaCorrente",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
