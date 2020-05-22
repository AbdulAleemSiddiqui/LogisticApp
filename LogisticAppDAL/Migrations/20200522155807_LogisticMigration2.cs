using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogisticAppDAL.Migrations
{
    public partial class LogisticMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_POs_PO_ID",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "PO_ID",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Payment_ID",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    B_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.B_Id);
                });

            migrationBuilder.CreateTable(
                name: "Cheques",
                columns: table => new
                {
                    Cheque_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cheque_No = table.Column<string>(nullable: false),
                    Bank_ID = table.Column<int>(nullable: false),
                    Cheque_Date = table.Column<DateTime>(nullable: false),
                    bankB_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheques", x => x.Cheque_ID);
                    table.ForeignKey(
                        name: "FK_Cheques_Banks_bankB_Id",
                        column: x => x.bankB_Id,
                        principalTable: "Banks",
                        principalColumn: "B_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deposit_Slips",
                columns: table => new
                {
                    DS_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DS_No = table.Column<string>(nullable: false),
                    DS_PersonName = table.Column<string>(nullable: true),
                    DS_Date = table.Column<DateTime>(nullable: false),
                    Bank_ID = table.Column<int>(nullable: false),
                    bankB_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit_Slips", x => x.DS_ID);
                    table.ForeignKey(
                        name: "FK_Deposit_Slips_Banks_bankB_Id",
                        column: x => x.bankB_Id,
                        principalTable: "Banks",
                        principalColumn: "B_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    P_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    P_No = table.Column<string>(nullable: true),
                    Issue_Name = table.Column<string>(nullable: false),
                    Issue_Date = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Method = table.Column<string>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Cheque_ID = table.Column<int>(nullable: true),
                    Cheque = table.Column<int>(nullable: true),
                    Deposite_ID = table.Column<int>(nullable: true),
                    Deposite = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.P_ID);
                    table.ForeignKey(
                        name: "FK_Payments_Cheques_Cheque",
                        column: x => x.Cheque,
                        principalTable: "Cheques",
                        principalColumn: "Cheque_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Deposit_Slips_Deposite",
                        column: x => x.Deposite,
                        principalTable: "Deposit_Slips",
                        principalColumn: "DS_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_bankB_Id",
                table: "Cheques",
                column: "bankB_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Deposit_Slips_bankB_Id",
                table: "Deposit_Slips",
                column: "bankB_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Cheque",
                table: "Payments",
                column: "Cheque");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Deposite",
                table: "Payments",
                column: "Deposite");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_POs_PO_ID",
                table: "Invoices",
                column: "PO_ID",
                principalTable: "POs",
                principalColumn: "PO_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_POs_PO_ID",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Cheques");

            migrationBuilder.DropTable(
                name: "Deposit_Slips");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropColumn(
                name: "Payment_ID",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "PO_ID",
                table: "Invoices",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_POs_PO_ID",
                table: "Invoices",
                column: "PO_ID",
                principalTable: "POs",
                principalColumn: "PO_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
