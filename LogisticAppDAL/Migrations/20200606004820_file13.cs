using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogisticAppDAL.Migrations
{
    public partial class file13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Expense_Category",
                columns: table => new
                {
                    Exp_Cat_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Exp_Cat_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense_Category", x => x.Exp_Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Exp_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Person = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Exp_Cat_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Exp_ID);
                    table.ForeignKey(
                        name: "FK_Expense_Expense_Category_Exp_Cat_ID",
                        column: x => x.Exp_Cat_ID,
                        principalTable: "Expense_Category",
                        principalColumn: "Exp_Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                });
             
            migrationBuilder.CreateIndex(
                name: "IX_Expense_Exp_Cat_ID",
                table: "Expense",
                column: "Exp_Cat_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
