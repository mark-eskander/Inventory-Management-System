using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class EditAuditINVID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_Inventories_inventoryID",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_inventoryID",
                table: "AuditTable");

            migrationBuilder.DropColumn(
                name: "inventoryID",
                table: "AuditTable");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_Taregt_Inv",
                table: "AuditTable",
                column: "Taregt_Inv");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_Inventories_Taregt_Inv",
                table: "AuditTable",
                column: "Taregt_Inv",
                principalTable: "Inventories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_Inventories_Taregt_Inv",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_Taregt_Inv",
                table: "AuditTable");

            migrationBuilder.AddColumn<int>(
                name: "inventoryID",
                table: "AuditTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_inventoryID",
                table: "AuditTable",
                column: "inventoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_Inventories_inventoryID",
                table: "AuditTable",
                column: "inventoryID",
                principalTable: "Inventories",
                principalColumn: "ID");
        }
    }
}
