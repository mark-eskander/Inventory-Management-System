using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class editInvToInvafterSubmit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_Inventories_from",
                table: "InvToInvAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_Inventories_to",
                table: "InvToInvAudit");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_Inventories_from",
                table: "InvToInvAudit",
                column: "from",
                principalTable: "Inventories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_Inventories_to",
                table: "InvToInvAudit",
                column: "to",
                principalTable: "Inventories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_Inventories_from",
                table: "InvToInvAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_Inventories_to",
                table: "InvToInvAudit");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_Inventories_from",
                table: "InvToInvAudit",
                column: "from",
                principalTable: "Inventories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_Inventories_to",
                table: "InvToInvAudit",
                column: "to",
                principalTable: "Inventories",
                principalColumn: "ID");
        }
    }
}
