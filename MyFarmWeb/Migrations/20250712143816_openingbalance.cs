using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFarmWeb.Migrations
{
    /// <inheritdoc />
    public partial class openingbalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankOpeningBalanceHeader",
                columns: table => new
                {
                    BankBalanceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankOpeningBalanceHeader", x => x.BankBalanceId);
                    table.ForeignKey(
                        name: "FK_BankOpeningBalanceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankOpeningBalanceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOpeningBalanceHeader",
                columns: table => new
                {
                    CustomerBalanceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOpeningBalanceHeader", x => x.CustomerBalanceId);
                    table.ForeignKey(
                        name: "FK_CustomerOpeningBalanceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerOpeningBalanceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemOpeningBalanceHeader",
                columns: table => new
                {
                    ItemBalanceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOpeningBalanceHeader", x => x.ItemBalanceId);
                    table.ForeignKey(
                        name: "FK_ItemOpeningBalanceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOpeningBalanceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SafeOpeningBalanceHeader",
                columns: table => new
                {
                    SafeBalanceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeOpeningBalanceHeader", x => x.SafeBalanceId);
                    table.ForeignKey(
                        name: "FK_SafeOpeningBalanceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SafeOpeningBalanceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorOpeningBalanceHeader",
                columns: table => new
                {
                    VendorBalanceId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorOpeningBalanceHeader", x => x.VendorBalanceId);
                    table.ForeignKey(
                        name: "FK_VendorOpeningBalanceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorOpeningBalanceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankOpeningBalanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    BankBalanceId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankOpeningBalanceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankOpeningBalanceDetails_BankOpeningBalanceHeader_BankBalanceId",
                        column: x => x.BankBalanceId,
                        principalTable: "BankOpeningBalanceHeader",
                        principalColumn: "BankBalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankOpeningBalanceDetails_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOpeningBalanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    CustomerBalanceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOpeningBalanceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOpeningBalanceDetails_CustomerOpeningBalanceHeader_CustomerBalanceId",
                        column: x => x.CustomerBalanceId,
                        principalTable: "CustomerOpeningBalanceHeader",
                        principalColumn: "CustomerBalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerOpeningBalanceDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemOpeningBalanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemBalanceId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOpeningBalanceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemOpeningBalanceDetails_ItemOpeningBalanceHeader_ItemBalanceId",
                        column: x => x.ItemBalanceId,
                        principalTable: "ItemOpeningBalanceHeader",
                        principalColumn: "ItemBalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOpeningBalanceDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOpeningBalanceDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemOpeningBalanceDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SafeOpeningBalanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    SafeBalanceId = table.Column<int>(type: "int", nullable: false),
                    SafeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeOpeningBalanceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafeOpeningBalanceDetails_SafeOpeningBalanceHeader_SafeBalanceId",
                        column: x => x.SafeBalanceId,
                        principalTable: "SafeOpeningBalanceHeader",
                        principalColumn: "SafeBalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SafeOpeningBalanceDetails_Safes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "Safes",
                        principalColumn: "SafeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorOpeningBalanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    VendorBalanceId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorOpeningBalanceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorOpeningBalanceDetails_VendorOpeningBalanceHeader_VendorBalanceId",
                        column: x => x.VendorBalanceId,
                        principalTable: "VendorOpeningBalanceHeader",
                        principalColumn: "VendorBalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorOpeningBalanceDetails_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeId", "DocumentTypeName" },
                values: new object[] { 13, "رصيد افتتاحي" });

            migrationBuilder.CreateIndex(
                name: "IX_BankOpeningBalanceDetails_BankBalanceId",
                table: "BankOpeningBalanceDetails",
                column: "BankBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_BankOpeningBalanceDetails_BankId",
                table: "BankOpeningBalanceDetails",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankOpeningBalanceHeader_UserId",
                table: "BankOpeningBalanceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BankOpeningBalanceHeader_Year",
                table: "BankOpeningBalanceHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOpeningBalanceDetails_CustomerBalanceId",
                table: "CustomerOpeningBalanceDetails",
                column: "CustomerBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOpeningBalanceDetails_CustomerId",
                table: "CustomerOpeningBalanceDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOpeningBalanceHeader_UserId",
                table: "CustomerOpeningBalanceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOpeningBalanceHeader_Year",
                table: "CustomerOpeningBalanceHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOpeningBalanceDetails_ItemBalanceId",
                table: "ItemOpeningBalanceDetails",
                column: "ItemBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOpeningBalanceDetails_ItemId",
                table: "ItemOpeningBalanceDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOpeningBalanceDetails_StoreId",
                table: "ItemOpeningBalanceDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOpeningBalanceDetails_UnitId",
                table: "ItemOpeningBalanceDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOpeningBalanceHeader_UserId",
                table: "ItemOpeningBalanceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOpeningBalanceHeader_Year",
                table: "ItemOpeningBalanceHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_SafeOpeningBalanceDetails_SafeBalanceId",
                table: "SafeOpeningBalanceDetails",
                column: "SafeBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeOpeningBalanceDetails_SafeId",
                table: "SafeOpeningBalanceDetails",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeOpeningBalanceHeader_UserId",
                table: "SafeOpeningBalanceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeOpeningBalanceHeader_Year",
                table: "SafeOpeningBalanceHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_VendorOpeningBalanceDetails_VendorBalanceId",
                table: "VendorOpeningBalanceDetails",
                column: "VendorBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorOpeningBalanceDetails_VendorId",
                table: "VendorOpeningBalanceDetails",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorOpeningBalanceHeader_UserId",
                table: "VendorOpeningBalanceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorOpeningBalanceHeader_Year",
                table: "VendorOpeningBalanceHeader",
                column: "Year");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankOpeningBalanceDetails");

            migrationBuilder.DropTable(
                name: "CustomerOpeningBalanceDetails");

            migrationBuilder.DropTable(
                name: "ItemOpeningBalanceDetails");

            migrationBuilder.DropTable(
                name: "SafeOpeningBalanceDetails");

            migrationBuilder.DropTable(
                name: "VendorOpeningBalanceDetails");

            migrationBuilder.DropTable(
                name: "BankOpeningBalanceHeader");

            migrationBuilder.DropTable(
                name: "CustomerOpeningBalanceHeader");

            migrationBuilder.DropTable(
                name: "ItemOpeningBalanceHeader");

            migrationBuilder.DropTable(
                name: "SafeOpeningBalanceHeader");

            migrationBuilder.DropTable(
                name: "VendorOpeningBalanceHeader");

            migrationBuilder.DeleteData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeId",
                keyValue: 13);
        }
    }
}
