using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class EditInvToInv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_Items_item_navCode",
                table: "InvToInvAudit");

            migrationBuilder.DropIndex(
                name: "IX_InvToInvAudit_item_navCode",
                table: "InvToInvAudit");

            migrationBuilder.DropColumn(
                name: "item_navCode",
                table: "InvToInvAudit");

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_item",
                table: "InvToInvAudit",
                column: "item");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_Items_item",
                table: "InvToInvAudit",
                column: "item",
                principalTable: "Items",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_Items_item",
                table: "InvToInvAudit");

            migrationBuilder.DropIndex(
                name: "IX_InvToInvAudit_item",
                table: "InvToInvAudit");

            migrationBuilder.AddColumn<int>(
                name: "item_navCode",
                table: "InvToInvAudit",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_item_navCode",
                table: "InvToInvAudit",
                column: "item_navCode");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_Items_item_navCode",
                table: "InvToInvAudit",
                column: "item_navCode",
                principalTable: "Items",
                principalColumn: "Code");
        }
    }
}
