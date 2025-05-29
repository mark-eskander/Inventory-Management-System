using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class editpullOrderDetaisDuplication3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pullOrederDetails_Items_ItemCode",
                table: "pullOrederDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_pullOrederDetails_Suppliers_SupplierIdSupplier",
                table: "pullOrederDetails");

            migrationBuilder.DropIndex(
                name: "IX_pullOrederDetails_ItemCode",
                table: "pullOrederDetails");

            migrationBuilder.DropIndex(
                name: "IX_pullOrederDetails_SupplierIdSupplier",
                table: "pullOrederDetails");

            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "pullOrederDetails");

            migrationBuilder.DropColumn(
                name: "SupplierIdSupplier",
                table: "pullOrederDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemCode",
                table: "pullOrederDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierIdSupplier",
                table: "pullOrederDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pullOrederDetails_ItemCode",
                table: "pullOrederDetails",
                column: "ItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_pullOrederDetails_SupplierIdSupplier",
                table: "pullOrederDetails",
                column: "SupplierIdSupplier");

            migrationBuilder.AddForeignKey(
                name: "FK_pullOrederDetails_Items_ItemCode",
                table: "pullOrederDetails",
                column: "ItemCode",
                principalTable: "Items",
                principalColumn: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_pullOrederDetails_Suppliers_SupplierIdSupplier",
                table: "pullOrederDetails",
                column: "SupplierIdSupplier",
                principalTable: "Suppliers",
                principalColumn: "IdSupplier");
        }
    }
}
