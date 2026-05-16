using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaAppSqlite.Migrations
{
    /// <inheritdoc />
    public partial class AcrescenteiDataVendaEmVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataVenda",
                table: "Vendas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataVenda",
                table: "Vendas");
        }
    }
}
