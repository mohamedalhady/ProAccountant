using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFarmWeb.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    AccountTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTypeName = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataGridSettingModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GridId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Setting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsExpand = table.Column<bool>(type: "bit", nullable: false),
                    ColumnsFrozen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataGridSettingModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FarmTransactionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmTransactionDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FarmTypes",
                columns: table => new
                {
                    FarmTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FameTypeName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmTypes", x => x.FarmTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FatteningPerformanceRate",
                columns: table => new
                {
                    Age = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    WeightGain = table.Column<float>(type: "real", nullable: false),
                    DailyFeedConsumption = table.Column<float>(type: "real", nullable: false),
                    CumulativeFeedConsumption = table.Column<float>(type: "real", nullable: false),
                    ConversionFactor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FatteningPerformanceRate", x => x.Age);
                });

            migrationBuilder.CreateTable(
                name: "Governorate",
                columns: table => new
                {
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernorateName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorate", x => x.GovernorateId);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Type = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreMovementTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreMovementTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataGridColumnsFrozen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GridId = table.Column<int>(type: "int", nullable: false),
                    ColumnsFrozenSetting = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataGridColumnsFrozen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataGridColumnsFrozen_DataGridSettingModel_GridId",
                        column: x => x.GridId,
                        principalTable: "DataGridSettingModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FarmAgeStandards",
                columns: table => new
                {
                    FarmAgeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmTypeId = table.Column<int>(type: "int", nullable: false),
                    StandardAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmAgeStandards", x => x.FarmAgeId);
                    table.ForeignKey(
                        name: "FK_FarmAgeStandards_FarmTypes_FarmTypeId",
                        column: x => x.FarmTypeId,
                        principalTable: "FarmTypes",
                        principalColumn: "FarmTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Governorate_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorate",
                        principalColumn: "GovernorateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "_Years",
                columns: table => new
                {
                    Year = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearName = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Years", x => x.Year);
                    table.ForeignKey(
                        name: "FK__Years_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BankNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                    table.ForeignKey(
                        name: "FK_Banks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerGroups",
                columns: table => new
                {
                    CustomerGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerGroupName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerGroups", x => x.CustomerGroupId);
                    table.ForeignKey(
                        name: "FK_CustomerGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseGroups",
                columns: table => new
                {
                    ExpenseGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseGroupName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseGroups", x => x.ExpenseGroupId);
                    table.ForeignKey(
                        name: "FK_ExpenseGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    FarmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FarmTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.FarmId);
                    table.ForeignKey(
                        name: "FK_Farms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Farms_FarmTypes_FarmTypeId",
                        column: x => x.FarmTypeId,
                        principalTable: "FarmTypes",
                        principalColumn: "FarmTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncomesGroups",
                columns: table => new
                {
                    IncomeGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeGroupName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomesGroups", x => x.IncomeGroupId);
                    table.ForeignKey(
                        name: "FK_IncomesGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemsGroups",
                columns: table => new
                {
                    ItemGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemGroupName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsGroups", x => x.ItemGroupId);
                    table.ForeignKey(
                        name: "FK_ItemsGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Safes",
                columns: table => new
                {
                    SafeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SafeName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Safes", x => x.SafeId);
                    table.ForeignKey(
                        name: "FK_Safes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_Stores_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_Units_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorsGroup",
                columns: table => new
                {
                    VendorGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorGroupName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorsGroup", x => x.VendorGroupId);
                    table.ForeignKey(
                        name: "FK_VendorsGroup_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreMovementHeader",
                columns: table => new
                {
                    MovementId = table.Column<int>(type: "int", nullable: false),
                    MovementDocumentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: true),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreMovementHeader", x => x.MovementId);
                    table.ForeignKey(
                        name: "FK_StoreMovementHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreMovementHeader_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreMovementHeader_StoreMovementTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "StoreMovementTypes",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreMovementHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTransactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankTransactions_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankTransactions_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankTransactions__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentBankHeader",
                columns: table => new
                {
                    PaymentBankId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentBankHeader", x => x.PaymentBankId);
                    table.ForeignKey(
                        name: "FK_PaymentBankHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentBankHeader_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentBankHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptBankHeader",
                columns: table => new
                {
                    ReceiptBankId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptBankHeader", x => x.ReceiptBankId);
                    table.ForeignKey(
                        name: "FK_ReceiptBankHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptBankHeader_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptBankHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CustomerGroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerGroups_CustomerGroupId",
                        column: x => x.CustomerGroupId,
                        principalTable: "CustomerGroups",
                        principalColumn: "CustomerGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ExpenseGroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseGroups_ExpenseGroupId",
                        column: x => x.ExpenseGroupId,
                        principalTable: "ExpenseGroups",
                        principalColumn: "ExpenseGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferBetweenFarmsHeader",
                columns: table => new
                {
                    TransferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FarmIdFrom = table.Column<int>(type: "int", nullable: false),
                    FarmIdTo = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    _YearYear = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferBetweenFarmsHeader", x => x.TransferId);
                    table.ForeignKey(
                        name: "FK_TransferBetweenFarmsHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferBetweenFarmsHeader_Farms_FarmIdFrom",
                        column: x => x.FarmIdFrom,
                        principalTable: "Farms",
                        principalColumn: "FarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferBetweenFarmsHeader_Farms_FarmIdTo",
                        column: x => x.FarmIdTo,
                        principalTable: "Farms",
                        principalColumn: "FarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferBetweenFarmsHeader__Years__YearYear",
                        column: x => x._YearYear,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    IncomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IncomeGroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.IncomeId);
                    table.ForeignKey(
                        name: "FK_Incomes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incomes_IncomesGroups_IncomeGroupId",
                        column: x => x.IncomeGroupId,
                        principalTable: "IncomesGroups",
                        principalColumn: "IncomeGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSafeHeader",
                columns: table => new
                {
                    PaymentSafeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SafeId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSafeHeader", x => x.PaymentSafeId);
                    table.ForeignKey(
                        name: "FK_PaymentSafeHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentSafeHeader_Safes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "Safes",
                        principalColumn: "SafeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentSafeHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptSafeHeader",
                columns: table => new
                {
                    ReceiptSafeId = table.Column<int>(type: "int", nullable: false),
                    SafeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptSafeHeader", x => x.ReceiptSafeId);
                    table.ForeignKey(
                        name: "FK_ReceiptSafeHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptSafeHeader_Safes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "Safes",
                        principalColumn: "SafeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptSafeHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SafeTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SafeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafeTransactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SafeTransactions_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SafeTransactions_Safes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "Safes",
                        principalColumn: "SafeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SafeTransactions__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeHeader",
                columns: table => new
                {
                    ExchangeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeHeader", x => x.ExchangeId);
                    table.ForeignKey(
                        name: "FK_ExchangeHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExchangeHeader_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExchangeHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplyHeader",
                columns: table => new
                {
                    SupplyId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyHeader", x => x.SupplyId);
                    table.ForeignKey(
                        name: "FK_SupplyHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyHeader_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ItemGroupId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    SalesPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_ItemsGroups_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemsGroups",
                        principalColumn: "ItemGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitsConverters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitMainId = table.Column<int>(type: "int", nullable: false),
                    UnitSubId = table.Column<int>(type: "int", nullable: false),
                    ConversionFactor = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsConverters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitsConverters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitsConverters_Units_UnitMainId",
                        column: x => x.UnitMainId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitsConverters_Units_UnitSubId",
                        column: x => x.UnitSubId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    VendorGroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendors_VendorsGroup_VendorGroupId",
                        column: x => x.VendorGroupId,
                        principalTable: "VendorsGroup",
                        principalColumn: "VendorGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerTransactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerTransactions_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerTransactions_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerTransactions__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectExpenseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectExpenseId = table.Column<int>(type: "int", nullable: false),
                    ExpenseId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectExpenseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectExpenseDetails_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "ExpenseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectIncomeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectIncomeId = table.Column<int>(type: "int", nullable: false),
                    IncomeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectIncomeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectIncomeDetails_Incomes_IncomeId",
                        column: x => x.IncomeId,
                        principalTable: "Incomes",
                        principalColumn: "IncomeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeId = table.Column<int>(type: "int", nullable: false),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExchangeDetails_ExchangeHeader_ExchangeId",
                        column: x => x.ExchangeId,
                        principalTable: "ExchangeHeader",
                        principalColumn: "ExchangeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExchangeDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExchangeDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreMovementDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovementId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreMovementDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreMovementDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreMovementDetails_StoreMovementHeader_MovementId",
                        column: x => x.MovementId,
                        principalTable: "StoreMovementHeader",
                        principalColumn: "MovementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreMovementDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreMovementDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyId = table.Column<int>(type: "int", nullable: false),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplyDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyDetails_SupplyHeader_SupplyId",
                        column: x => x.SupplyId,
                        principalTable: "SupplyHeader",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferBetweenFarmsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferBetweenFarmsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferBetweenFarmsDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewFarms",
                columns: table => new
                {
                    NewFarmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    DateEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FeedVendor = table.Column<int>(type: "int", nullable: false),
                    ChickenVendor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewFarms", x => x.NewFarmId);
                    table.ForeignKey(
                        name: "FK_NewFarms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewFarms_Farms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "Farms",
                        principalColumn: "FarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewFarms_Vendors_ChickenVendor",
                        column: x => x.ChickenVendor,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewFarms_Vendors_FeedVendor",
                        column: x => x.FeedVendor,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewFarms__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentBankDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    PaymentBankId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentBankDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentBankDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentBankDetails_PaymentBankHeader_PaymentBankId",
                        column: x => x.PaymentBankId,
                        principalTable: "PaymentBankHeader",
                        principalColumn: "PaymentBankId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentBankDetails_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSafeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    PaymentSafeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSafeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSafeDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentSafeDetails_PaymentSafeHeader_PaymentSafeId",
                        column: x => x.PaymentSafeId,
                        principalTable: "PaymentSafeHeader",
                        principalColumn: "PaymentSafeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentSafeDetails_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptBankDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ReceiptBankId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptBankDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptBankDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptBankDetails_ReceiptBankHeader_ReceiptBankId",
                        column: x => x.ReceiptBankId,
                        principalTable: "ReceiptBankHeader",
                        principalColumn: "ReceiptBankId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptBankDetails_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptSafeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ReceiptSafeId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptSafeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptSafeDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptSafeDetails_ReceiptSafeHeader_ReceiptSafeId",
                        column: x => x.ReceiptSafeId,
                        principalTable: "ReceiptSafeHeader",
                        principalColumn: "ReceiptSafeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiptSafeDetails_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorTransactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorTransactions_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorTransactions_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorTransactions__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deads",
                columns: table => new
                {
                    DeadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    _YearYear = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deads", x => x.DeadId);
                    table.ForeignKey(
                        name: "FK_Deads_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deads_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deads__Years__YearYear",
                        column: x => x._YearYear,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectExpenseHeader",
                columns: table => new
                {
                    DirectExpenseId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectExpenseHeader", x => x.DirectExpenseId);
                    table.ForeignKey(
                        name: "FK_DirectExpenseHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DirectExpenseHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DirectExpenseHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectIncomeHeader",
                columns: table => new
                {
                    DirectIncomeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectIncomeHeader", x => x.DirectIncomeId);
                    table.ForeignKey(
                        name: "FK_DirectIncomeHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DirectIncomeHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DirectIncomeHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FarmTransactionHeader",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmTransactionHeader", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_FarmTransactionHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FarmTransactionHeader_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FarmTransactionHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FarmTransactionHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceHeader",
                columns: table => new
                {
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    PurchaseInvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceHeader", x => x.PurchaseInvoiceId);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReverseHeader",
                columns: table => new
                {
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    PurchaseInvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: true),
                    Reference = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReverseHeader", x => x.PurchaseInvoiceId);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseHeader_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceHeader",
                columns: table => new
                {
                    SalesInvoiceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SalesInvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceHeader", x => x.SalesInvoiceId);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesReverseHeader",
                columns: table => new
                {
                    SalesInvoiceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SalesInvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: true),
                    Reference = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReverseHeader", x => x.SalesInvoiceId);
                    table.ForeignKey(
                        name: "FK_SalesReverseHeader_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReverseHeader_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReverseHeader_NewFarms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "NewFarms",
                        principalColumn: "NewFarmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReverseHeader__Years_Year",
                        column: x => x.Year,
                        principalTable: "_Years",
                        principalColumn: "Year",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    ConvertedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceDetails_PurchaseInvoiceHeader_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoiceHeader",
                        principalColumn: "PurchaseInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReverseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    ConvertedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReverseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseDetails_PurchaseReverseHeader_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseReverseHeader",
                        principalColumn: "PurchaseInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReverseDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDetails_SalesInvoiceHeader_SalesInvoiceId",
                        column: x => x.SalesInvoiceId,
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "SalesInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesReverseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Moslsel = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ConvertedQuantity = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    UnitIdMain = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvertedUnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ItemNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReverseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReverseDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReverseDetails_SalesReverseHeader_SalesInvoiceId",
                        column: x => x.SalesInvoiceId,
                        principalTable: "SalesReverseHeader",
                        principalColumn: "SalesInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReverseDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReverseDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "AccountTypeId", "AccountTypeName" },
                values: new object[,]
                {
                    { 1, "عميل" },
                    { 2, "مورد" },
                    { 3, "حساب" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeId", "DocumentTypeName" },
                values: new object[,]
                {
                    { 1, "فاتورة بيع" },
                    { 2, "فاتورة مشتريات" },
                    { 3, "مصروف" },
                    { 4, "ايراد" },
                    { 5, "توريد مخزنى" },
                    { 6, "صرف مخزني" },
                    { 7, "مقبوض نقدي" },
                    { 8, "مدفوع نقدي" },
                    { 9, "مرتجع مبيعات" },
                    { 10, "مرتجع مشتريات" },
                    { 11, "مقبوض بنكي" },
                    { 12, "مدفوع بنكي" }
                });

            migrationBuilder.InsertData(
                table: "FarmTypes",
                columns: new[] { "FarmTypeId", "FameTypeName" },
                values: new object[,]
                {
                    { 1, "تسمين ابيض" },
                    { 2, "تسمين ساسو" },
                    { 3, "تسمين بلدي" }
                });

            migrationBuilder.InsertData(
                table: "Governorate",
                columns: new[] { "GovernorateId", "GovernorateName" },
                values: new object[] { 1, "الشرقية" });

            migrationBuilder.InsertData(
                table: "StoreMovementTypes",
                columns: new[] { "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "وارد" },
                    { 2, "منصرف" }
                });

            migrationBuilder.InsertData(
                table: "FarmAgeStandards",
                columns: new[] { "FarmAgeId", "FarmTypeId", "StandardAge" },
                values: new object[,]
                {
                    { 1, 1, 40 },
                    { 2, 2, 65 },
                    { 3, 3, 40 }
                });

            migrationBuilder.CreateIndex(
                name: "IX__Years_UserId",
                table: "_Years",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GovernorateId",
                table: "AspNetUsers",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_UserId",
                table: "Banks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_BankId",
                table: "BankTransactions",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_DocumentTypeId",
                table: "BankTransactions",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_UserId",
                table: "BankTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_Year",
                table: "BankTransactions",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerGroups_UserId",
                table: "CustomerGroups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerGroupId",
                table: "Customers",
                column: "CustomerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_CustomerId",
                table: "CustomerTransactions",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_DocumentTypeId",
                table: "CustomerTransactions",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_UserId",
                table: "CustomerTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_Year",
                table: "CustomerTransactions",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_DataGridColumnsFrozen_GridId",
                table: "DataGridColumnsFrozen",
                column: "GridId");

            migrationBuilder.CreateIndex(
                name: "IX_Deads__YearYear",
                table: "Deads",
                column: "_YearYear");

            migrationBuilder.CreateIndex(
                name: "IX_Deads_FarmId",
                table: "Deads",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Deads_UserId",
                table: "Deads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectExpenseDetails_ExpenseId",
                table: "DirectExpenseDetails",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectExpenseHeader_FarmId",
                table: "DirectExpenseHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectExpenseHeader_UserId",
                table: "DirectExpenseHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectExpenseHeader_Year",
                table: "DirectExpenseHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_DirectIncomeDetails_IncomeId",
                table: "DirectIncomeDetails",
                column: "IncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectIncomeHeader_FarmId",
                table: "DirectIncomeHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectIncomeHeader_UserId",
                table: "DirectIncomeHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectIncomeHeader_Year",
                table: "DirectIncomeHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeDetails_ExchangeId",
                table: "ExchangeDetails",
                column: "ExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeDetails_ItemId",
                table: "ExchangeDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeDetails_UnitId",
                table: "ExchangeDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeHeader_StoreId",
                table: "ExchangeHeader",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeHeader_UserId",
                table: "ExchangeHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeHeader_Year",
                table: "ExchangeHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseGroups_UserId",
                table: "ExpenseGroups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseGroupId",
                table: "Expenses",
                column: "ExpenseGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmAgeStandards_FarmTypeId",
                table: "FarmAgeStandards",
                column: "FarmTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_FarmTypeId",
                table: "Farms",
                column: "FarmTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_UserId",
                table: "Farms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmTransactionHeader_DocumentTypeId",
                table: "FarmTransactionHeader",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmTransactionHeader_FarmId",
                table: "FarmTransactionHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmTransactionHeader_UserId",
                table: "FarmTransactionHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmTransactionHeader_Year",
                table: "FarmTransactionHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_IncomeGroupId",
                table: "Incomes",
                column: "IncomeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomesGroups_UserId",
                table: "IncomesGroups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemGroupId",
                table: "Items",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StoreId",
                table: "Items",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UnitId",
                table: "Items",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserId",
                table: "Items",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsGroups_UserId",
                table: "ItemsGroups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewFarms_ChickenVendor",
                table: "NewFarms",
                column: "ChickenVendor");

            migrationBuilder.CreateIndex(
                name: "IX_NewFarms_FarmId",
                table: "NewFarms",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_NewFarms_FeedVendor",
                table: "NewFarms",
                column: "FeedVendor");

            migrationBuilder.CreateIndex(
                name: "IX_NewFarms_UserId",
                table: "NewFarms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewFarms_Year",
                table: "NewFarms",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBankDetails_CustomerId",
                table: "PaymentBankDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBankDetails_PaymentBankId",
                table: "PaymentBankDetails",
                column: "PaymentBankId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBankDetails_VendorId",
                table: "PaymentBankDetails",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBankHeader_BankId",
                table: "PaymentBankHeader",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBankHeader_UserId",
                table: "PaymentBankHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBankHeader_Year",
                table: "PaymentBankHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSafeDetails_CustomerId",
                table: "PaymentSafeDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSafeDetails_PaymentSafeId",
                table: "PaymentSafeDetails",
                column: "PaymentSafeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSafeDetails_VendorId",
                table: "PaymentSafeDetails",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSafeHeader_SafeId",
                table: "PaymentSafeHeader",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSafeHeader_UserId",
                table: "PaymentSafeHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSafeHeader_Year",
                table: "PaymentSafeHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceDetails_ItemId",
                table: "PurchaseInvoiceDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceDetails_PurchaseInvoiceId",
                table: "PurchaseInvoiceDetails",
                column: "PurchaseInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceDetails_StoreId",
                table: "PurchaseInvoiceDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceDetails_UnitId",
                table: "PurchaseInvoiceDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_FarmId",
                table: "PurchaseInvoiceHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_UserId",
                table: "PurchaseInvoiceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_VendorId",
                table: "PurchaseInvoiceHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_Year",
                table: "PurchaseInvoiceHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseDetails_ItemId",
                table: "PurchaseReverseDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseDetails_PurchaseInvoiceId",
                table: "PurchaseReverseDetails",
                column: "PurchaseInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseDetails_StoreId",
                table: "PurchaseReverseDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseDetails_UnitId",
                table: "PurchaseReverseDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseHeader_FarmId",
                table: "PurchaseReverseHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseHeader_UserId",
                table: "PurchaseReverseHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseHeader_VendorId",
                table: "PurchaseReverseHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReverseHeader_Year",
                table: "PurchaseReverseHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptBankDetails_CustomerId",
                table: "ReceiptBankDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptBankDetails_ReceiptBankId",
                table: "ReceiptBankDetails",
                column: "ReceiptBankId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptBankDetails_VendorId",
                table: "ReceiptBankDetails",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptBankHeader_BankId",
                table: "ReceiptBankHeader",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptBankHeader_UserId",
                table: "ReceiptBankHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptBankHeader_Year",
                table: "ReceiptBankHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptSafeDetails_CustomerId",
                table: "ReceiptSafeDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptSafeDetails_ReceiptSafeId",
                table: "ReceiptSafeDetails",
                column: "ReceiptSafeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptSafeDetails_VendorId",
                table: "ReceiptSafeDetails",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptSafeHeader_SafeId",
                table: "ReceiptSafeHeader",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptSafeHeader_UserId",
                table: "ReceiptSafeHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptSafeHeader_Year",
                table: "ReceiptSafeHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_Safes_UserId",
                table: "Safes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeTransactions_DocumentTypeId",
                table: "SafeTransactions",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeTransactions_SafeId",
                table: "SafeTransactions",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeTransactions_UserId",
                table: "SafeTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SafeTransactions_Year",
                table: "SafeTransactions",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDetails_ItemId",
                table: "SalesInvoiceDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDetails_SalesInvoiceId",
                table: "SalesInvoiceDetails",
                column: "SalesInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDetails_StoreId",
                table: "SalesInvoiceDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceDetails_UnitId",
                table: "SalesInvoiceDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_CustomerId",
                table: "SalesInvoiceHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_FarmId",
                table: "SalesInvoiceHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_UserId",
                table: "SalesInvoiceHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_Year",
                table: "SalesInvoiceHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseDetails_ItemId",
                table: "SalesReverseDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseDetails_SalesInvoiceId",
                table: "SalesReverseDetails",
                column: "SalesInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseDetails_StoreId",
                table: "SalesReverseDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseDetails_UnitId",
                table: "SalesReverseDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseHeader_CustomerId",
                table: "SalesReverseHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseHeader_FarmId",
                table: "SalesReverseHeader",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseHeader_UserId",
                table: "SalesReverseHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReverseHeader_Year",
                table: "SalesReverseHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementDetails_ItemId",
                table: "StoreMovementDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementDetails_MovementId",
                table: "StoreMovementDetails",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementDetails_StoreId",
                table: "StoreMovementDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementDetails_UnitId",
                table: "StoreMovementDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementHeader_DocumentTypeId",
                table: "StoreMovementHeader",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementHeader_TypeId",
                table: "StoreMovementHeader",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementHeader_UserId",
                table: "StoreMovementHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreMovementHeader_Year",
                table: "StoreMovementHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_UserId",
                table: "Stores",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyDetails_ItemId",
                table: "SupplyDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyDetails_SupplyId",
                table: "SupplyDetails",
                column: "SupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyDetails_UnitId",
                table: "SupplyDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyHeader_StoreId",
                table: "SupplyHeader",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyHeader_UserId",
                table: "SupplyHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyHeader_Year",
                table: "SupplyHeader",
                column: "Year");

            migrationBuilder.CreateIndex(
                name: "IX_TransferBetweenFarmsDetails_ItemId",
                table: "TransferBetweenFarmsDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferBetweenFarmsHeader__YearYear",
                table: "TransferBetweenFarmsHeader",
                column: "_YearYear");

            migrationBuilder.CreateIndex(
                name: "IX_TransferBetweenFarmsHeader_FarmIdFrom",
                table: "TransferBetweenFarmsHeader",
                column: "FarmIdFrom");

            migrationBuilder.CreateIndex(
                name: "IX_TransferBetweenFarmsHeader_FarmIdTo",
                table: "TransferBetweenFarmsHeader",
                column: "FarmIdTo");

            migrationBuilder.CreateIndex(
                name: "IX_TransferBetweenFarmsHeader_UserId",
                table: "TransferBetweenFarmsHeader",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_UserId",
                table: "Units",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsConverters_UnitMainId",
                table: "UnitsConverters",
                column: "UnitMainId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsConverters_UnitSubId",
                table: "UnitsConverters",
                column: "UnitSubId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsConverters_UserId",
                table: "UnitsConverters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_UserId",
                table: "Vendors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorGroupId",
                table: "Vendors",
                column: "VendorGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorsGroup_UserId",
                table: "VendorsGroup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorTransactions_DocumentTypeId",
                table: "VendorTransactions",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorTransactions_UserId",
                table: "VendorTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorTransactions_VendorId",
                table: "VendorTransactions",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorTransactions_Year",
                table: "VendorTransactions",
                column: "Year");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BankTransactions");

            migrationBuilder.DropTable(
                name: "CustomerTransactions");

            migrationBuilder.DropTable(
                name: "DataGridColumnsFrozen");

            migrationBuilder.DropTable(
                name: "Deads");

            migrationBuilder.DropTable(
                name: "DirectExpenseDetails");

            migrationBuilder.DropTable(
                name: "DirectExpenseHeader");

            migrationBuilder.DropTable(
                name: "DirectIncomeDetails");

            migrationBuilder.DropTable(
                name: "DirectIncomeHeader");

            migrationBuilder.DropTable(
                name: "ExchangeDetails");

            migrationBuilder.DropTable(
                name: "FarmAgeStandards");

            migrationBuilder.DropTable(
                name: "FarmTransactionDetails");

            migrationBuilder.DropTable(
                name: "FarmTransactionHeader");

            migrationBuilder.DropTable(
                name: "FatteningPerformanceRate");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "PaymentBankDetails");

            migrationBuilder.DropTable(
                name: "PaymentSafeDetails");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceDetails");

            migrationBuilder.DropTable(
                name: "PurchaseReverseDetails");

            migrationBuilder.DropTable(
                name: "ReceiptBankDetails");

            migrationBuilder.DropTable(
                name: "ReceiptSafeDetails");

            migrationBuilder.DropTable(
                name: "SafeTransactions");

            migrationBuilder.DropTable(
                name: "SalesInvoiceDetails");

            migrationBuilder.DropTable(
                name: "SalesReverseDetails");

            migrationBuilder.DropTable(
                name: "StoreMovementDetails");

            migrationBuilder.DropTable(
                name: "SupplyDetails");

            migrationBuilder.DropTable(
                name: "TransferBetweenFarmsDetails");

            migrationBuilder.DropTable(
                name: "TransferBetweenFarmsHeader");

            migrationBuilder.DropTable(
                name: "UnitsConverters");

            migrationBuilder.DropTable(
                name: "VendorTransactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DataGridSettingModel");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "ExchangeHeader");

            migrationBuilder.DropTable(
                name: "PaymentBankHeader");

            migrationBuilder.DropTable(
                name: "PaymentSafeHeader");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceHeader");

            migrationBuilder.DropTable(
                name: "PurchaseReverseHeader");

            migrationBuilder.DropTable(
                name: "ReceiptBankHeader");

            migrationBuilder.DropTable(
                name: "ReceiptSafeHeader");

            migrationBuilder.DropTable(
                name: "SalesInvoiceHeader");

            migrationBuilder.DropTable(
                name: "SalesReverseHeader");

            migrationBuilder.DropTable(
                name: "StoreMovementHeader");

            migrationBuilder.DropTable(
                name: "SupplyHeader");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ExpenseGroups");

            migrationBuilder.DropTable(
                name: "IncomesGroups");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Safes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "NewFarms");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "StoreMovementTypes");

            migrationBuilder.DropTable(
                name: "ItemsGroups");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "CustomerGroups");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "_Years");

            migrationBuilder.DropTable(
                name: "FarmTypes");

            migrationBuilder.DropTable(
                name: "VendorsGroup");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Governorate");
        }
    }
}
