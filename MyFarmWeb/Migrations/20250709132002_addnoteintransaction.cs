using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFarmWeb.Migrations
{
    /// <inheritdoc />
    public partial class addnoteintransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "VendorTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "SafeTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "CustomerTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "BankTransactions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "VendorTransactions");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "SafeTransactions");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "BankTransactions");
        }
    }
}
