using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceiptTracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Purchasedate",
                table: "Receipt",
                newName: "purchaseDate");

            migrationBuilder.AlterColumn<int>(
                name: "warrantyEnd",
                table: "Receipt",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Receipt",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "purchaseDate",
                table: "Receipt",
                newName: "Purchasedate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "warrantyEnd",
                table: "Receipt",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Receipt",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
