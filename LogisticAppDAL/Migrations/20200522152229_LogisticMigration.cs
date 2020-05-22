using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogisticAppDAL.Migrations
{
    public partial class LogisticMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    C_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    C_Name = table.Column<string>(nullable: false),
                    C_Address = table.Column<string>(nullable: true),
                    C_Contact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.C_ID);
                });

            migrationBuilder.CreateTable(
                name: "Item_Category",
                columns: table => new
                {
                    IC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Category", x => x.IC_ID);
                });

            migrationBuilder.CreateTable(
                name: "Venders",
                columns: table => new
                {
                    V_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    Contact = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venders", x => x.V_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employe",
                columns: table => new
                {
                    E_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    E_Name = table.Column<string>(nullable: true),
                    E_Contact = table.Column<string>(nullable: true),
                    Company_ID = table.Column<int>(nullable: false),
                    companyC_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employe", x => x.E_ID);
                    table.ForeignKey(
                        name: "FK_Employe_Companies_companyC_ID",
                        column: x => x.companyC_ID,
                        principalTable: "Companies",
                        principalColumn: "C_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    Q_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Q_No = table.Column<string>(nullable: true),
                    Q_Date = table.Column<DateTime>(nullable: false),
                    Company_ID = table.Column<int>(nullable: false),
                    companyC_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.Q_ID);
                    table.ForeignKey(
                        name: "FK_Quotations_Companies_companyC_ID",
                        column: x => x.companyC_ID,
                        principalTable: "Companies",
                        principalColumn: "C_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    I_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    IC_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.I_ID);
                    table.ForeignKey(
                        name: "FK_Items_Item_Category_IC_ID",
                        column: x => x.IC_ID,
                        principalTable: "Item_Category",
                        principalColumn: "IC_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POs",
                columns: table => new
                {
                    PO_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PO_No = table.Column<string>(nullable: false),
                    PO_Date = table.Column<DateTime>(nullable: false),
                    Q_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POs", x => x.PO_ID);
                    table.ForeignKey(
                        name: "FK_POs_Quotations_Q_ID",
                        column: x => x.Q_ID,
                        principalTable: "Quotations",
                        principalColumn: "Q_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotation_Items",
                columns: table => new
                {
                    QI_Item_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Q_ID = table.Column<int>(nullable: false),
                    Item_ID = table.Column<int>(nullable: false),
                    Quoted_Amount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    itemI_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotation_Items", x => x.QI_Item_ID);
                    table.ForeignKey(
                        name: "FK_Quotation_Items_Quotations_Q_ID",
                        column: x => x.Q_ID,
                        principalTable: "Quotations",
                        principalColumn: "Q_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotation_Items_Items_itemI_ID",
                        column: x => x.itemI_ID,
                        principalTable: "Items",
                        principalColumn: "I_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Chalans",
                columns: table => new
                {
                    DC_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DC_No = table.Column<string>(nullable: true),
                    Company_ID = table.Column<int>(nullable: false),
                    PO_ID = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    companyC_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Chalans", x => x.DC_ID);
                    table.ForeignKey(
                        name: "FK_Delivery_Chalans_POs_PO_ID",
                        column: x => x.PO_ID,
                        principalTable: "POs",
                        principalColumn: "PO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Delivery_Chalans_Companies_companyC_ID",
                        column: x => x.companyC_ID,
                        principalTable: "Companies",
                        principalColumn: "C_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PO_Items",
                columns: table => new
                {
                    PO_Item_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PO_ID = table.Column<int>(nullable: false),
                    Item_ID = table.Column<int>(nullable: false),
                    PO_Amount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    itemI_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PO_Items", x => x.PO_Item_ID);
                    table.ForeignKey(
                        name: "FK_PO_Items_POs_PO_ID",
                        column: x => x.PO_ID,
                        principalTable: "POs",
                        principalColumn: "PO_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PO_Items_Items_itemI_ID",
                        column: x => x.itemI_ID,
                        principalTable: "Items",
                        principalColumn: "I_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Bills",
                columns: table => new
                {
                    PB_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    V_ID = table.Column<int>(nullable: false),
                    PO_ID = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Bills", x => x.PB_ID);
                    table.ForeignKey(
                        name: "FK_Purchase_Bills_POs_PO_ID",
                        column: x => x.PO_ID,
                        principalTable: "POs",
                        principalColumn: "PO_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchase_Bills_Venders_V_ID",
                        column: x => x.V_ID,
                        principalTable: "Venders",
                        principalColumn: "V_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Chalan_Items",
                columns: table => new
                {
                    DC_Item_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DC_ID = table.Column<int>(nullable: false),
                    Item_ID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    itemI_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Chalan_Items", x => x.DC_Item_ID);
                    table.ForeignKey(
                        name: "FK_Delivery_Chalan_Items_Delivery_Chalans_DC_ID",
                        column: x => x.DC_ID,
                        principalTable: "Delivery_Chalans",
                        principalColumn: "DC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivery_Chalan_Items_Items_itemI_ID",
                        column: x => x.itemI_ID,
                        principalTable: "Items",
                        principalColumn: "I_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    I_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    I_No = table.Column<string>(nullable: true),
                    PO_ID = table.Column<int>(nullable: true),
                    DC_ID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.I_ID);
                    table.ForeignKey(
                        name: "FK_Invoices_Delivery_Chalans_DC_ID",
                        column: x => x.DC_ID,
                        principalTable: "Delivery_Chalans",
                        principalColumn: "DC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_POs_PO_ID",
                        column: x => x.PO_ID,
                        principalTable: "POs",
                        principalColumn: "PO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Bill_Items",
                columns: table => new
                {
                    PB_Item_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PB_ID = table.Column<int>(nullable: false),
                    Item_ID = table.Column<int>(nullable: false),
                    Purchase_Amount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    itemI_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Bill_Items", x => x.PB_Item_ID);
                    table.ForeignKey(
                        name: "FK_Purchase_Bill_Items_Purchase_Bills_PB_ID",
                        column: x => x.PB_ID,
                        principalTable: "Purchase_Bills",
                        principalColumn: "PB_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Bill_Items_Items_itemI_ID",
                        column: x => x.itemI_ID,
                        principalTable: "Items",
                        principalColumn: "I_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_Items",
                columns: table => new
                {
                    I_Item_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Invoice_ID = table.Column<int>(nullable: false),
                    Item_ID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    itemI_ID = table.Column<int>(nullable: true),
                    invoiceI_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Items", x => x.I_Item_ID);
                    table.ForeignKey(
                        name: "FK_Invoice_Items_Invoices_invoiceI_ID",
                        column: x => x.invoiceI_ID,
                        principalTable: "Invoices",
                        principalColumn: "I_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Items_Items_itemI_ID",
                        column: x => x.itemI_ID,
                        principalTable: "Items",
                        principalColumn: "I_ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Chalan_Items_DC_ID",
                table: "Delivery_Chalan_Items",
                column: "DC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Chalan_Items_itemI_ID",
                table: "Delivery_Chalan_Items",
                column: "itemI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Chalans_PO_ID",
                table: "Delivery_Chalans",
                column: "PO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Chalans_companyC_ID",
                table: "Delivery_Chalans",
                column: "companyC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employe_companyC_ID",
                table: "Employe",
                column: "companyC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Items_invoiceI_ID",
                table: "Invoice_Items",
                column: "invoiceI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Items_itemI_ID",
                table: "Invoice_Items",
                column: "itemI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_DC_ID",
                table: "Invoices",
                column: "DC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PO_ID",
                table: "Invoices",
                column: "PO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_IC_ID",
                table: "Items",
                column: "IC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PO_Items_PO_ID",
                table: "PO_Items",
                column: "PO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PO_Items_itemI_ID",
                table: "PO_Items",
                column: "itemI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_POs_Q_ID",
                table: "POs",
                column: "Q_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Bill_Items_PB_ID",
                table: "Purchase_Bill_Items",
                column: "PB_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Bill_Items_itemI_ID",
                table: "Purchase_Bill_Items",
                column: "itemI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Bills_PO_ID",
                table: "Purchase_Bills",
                column: "PO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Bills_V_ID",
                table: "Purchase_Bills",
                column: "V_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Quotation_Items_Q_ID",
                table: "Quotation_Items",
                column: "Q_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Quotation_Items_itemI_ID",
                table: "Quotation_Items",
                column: "itemI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_companyC_ID",
                table: "Quotations",
                column: "companyC_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Delivery_Chalan_Items");

            migrationBuilder.DropTable(
                name: "Employe");

            migrationBuilder.DropTable(
                name: "Invoice_Items");

            migrationBuilder.DropTable(
                name: "PO_Items");

            migrationBuilder.DropTable(
                name: "Purchase_Bill_Items");

            migrationBuilder.DropTable(
                name: "Quotation_Items");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Purchase_Bills");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Delivery_Chalans");

            migrationBuilder.DropTable(
                name: "Venders");

            migrationBuilder.DropTable(
                name: "Item_Category");

            migrationBuilder.DropTable(
                name: "POs");

            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
