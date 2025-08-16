using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula4_exercicio.Migrations
{
    /// <inheritdoc />
    public partial class CGCPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cgc",
                table: "Agencias",
                newName: "CGC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CGC",
                table: "Agencias",
                newName: "cgc");
        }
    }
}
