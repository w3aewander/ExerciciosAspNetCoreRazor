using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaAppSqlite.Migrations
{
    /// <inheritdoc />
    public partial class AdicioneiCampoQtdeEstoque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Estoque",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Estoque");
        }
    }
}
