using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class editInvToInvafterSubmit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_PullOrders_PullOrderId",
                table: "InvToInvAudit");

            migrationBuilder.DropForeignKey(
                name: "FK_InvToInvAudit_SupplyOrders_SupplyOrderID",
                table: "InvToInvAudit");

            migrationBuilder.DropIndex(
                name: "IX_InvToInvAudit_PullOrderId",
                table: "InvToInvAudit");

            migrationBuilder.DropIndex(
                name: "IX_InvToInvAudit_SupplyOrderID",
                table: "InvToInvAudit");

            migrationBuilder.DropColumn(
                name: "PullOrderId",
                table: "InvToInvAudit");

            migrationBuilder.DropColumn(
                name: "SupplyOrderID",
                table: "InvToInvAudit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PullOrderId",
                table: "InvToInvAudit",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplyOrderID",
                table: "InvToInvAudit",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_PullOrderId",
                table: "InvToInvAudit",
                column: "PullOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_SupplyOrderID",
                table: "InvToInvAudit",
                column: "SupplyOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_PullOrders_PullOrderId",
                table: "InvToInvAudit",
                column: "PullOrderId",
                principalTable: "PullOrders",
                principalColumn: "PullOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvToInvAudit_SupplyOrders_SupplyOrderID",
                table: "InvToInvAudit",
                column: "SupplyOrderID",
                principalTable: "SupplyOrders",
                principalColumn: "SupplyOrderID");
        }
    }
}
