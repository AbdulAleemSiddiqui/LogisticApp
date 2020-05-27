using Microsoft.EntityFrameworkCore.Migrations;

namespace LogisticAppDAL.Migrations
{
    public partial class newupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Item_Category_IC_ID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item_Category",
                table: "Item_Category");

            migrationBuilder.RenameTable(
                name: "Item_Category",
                newName: "Item_Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item_Categories",
                table: "Item_Categories",
                column: "IC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Item_Categories_IC_ID",
                table: "Items",
                column: "IC_ID",
                principalTable: "Item_Categories",
                principalColumn: "IC_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Item_Categories_IC_ID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item_Categories",
                table: "Item_Categories");

            migrationBuilder.RenameTable(
                name: "Item_Categories",
                newName: "Item_Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item_Category",
                table: "Item_Category",
                column: "IC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Item_Category_IC_ID",
                table: "Items",
                column: "IC_ID",
                principalTable: "Item_Category",
                principalColumn: "IC_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
