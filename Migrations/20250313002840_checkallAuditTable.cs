using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class checkallAuditTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_InvToInvAudit_From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_Items_itemCode",
                table: "AuditTable");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_PullOrders_pull_order_navPullOrderId",
                table: "AuditTable");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_SupplyOrders_supply_order_navSupplyOrderID",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_itemCode",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_pull_order_navPullOrderId",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_supply_order_navSupplyOrderID",
                table: "AuditTable");

            migrationBuilder.DropColumn(
                name: "From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable");

            migrationBuilder.DropColumn(
                name: "itemCode",
                table: "AuditTable");

            migrationBuilder.DropColumn(
                name: "pull_order_navPullOrderId",
                table: "AuditTable");

            migrationBuilder.DropColumn(
                name: "supply_order_navSupplyOrderID",
                table: "AuditTable");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_From_Inv_To_Inv_ID",
                table: "AuditTable",
                column: "From_Inv_To_Inv_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_Item",
                table: "AuditTable",
                column: "Item");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_Pull_Order_Id",
                table: "AuditTable",
                column: "Pull_Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_Supply_Order_Id",
                table: "AuditTable",
                column: "Supply_Order_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_InvToInvAudit_From_Inv_To_Inv_ID",
                table: "AuditTable",
                column: "From_Inv_To_Inv_ID",
                principalTable: "InvToInvAudit",
                principalColumn: "Trs_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_Items_Item",
                table: "AuditTable",
                column: "Item",
                principalTable: "Items",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_PullOrders_Pull_Order_Id",
                table: "AuditTable",
                column: "Pull_Order_Id",
                principalTable: "PullOrders",
                principalColumn: "PullOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_SupplyOrders_Supply_Order_Id",
                table: "AuditTable",
                column: "Supply_Order_Id",
                principalTable: "SupplyOrders",
                principalColumn: "SupplyOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_InvToInvAudit_From_Inv_To_Inv_ID",
                table: "AuditTable");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_Items_Item",
                table: "AuditTable");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_PullOrders_Pull_Order_Id",
                table: "AuditTable");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditTable_SupplyOrders_Supply_Order_Id",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_From_Inv_To_Inv_ID",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_Item",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_Pull_Order_Id",
                table: "AuditTable");

            migrationBuilder.DropIndex(
                name: "IX_AuditTable_Supply_Order_Id",
                table: "AuditTable");

            migrationBuilder.AddColumn<int>(
                name: "From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "itemCode",
                table: "AuditTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pull_order_navPullOrderId",
                table: "AuditTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "supply_order_navSupplyOrderID",
                table: "AuditTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable",
                column: "From_Inv_To_Inv_Tracker_navTrs_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_itemCode",
                table: "AuditTable",
                column: "itemCode");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_pull_order_navPullOrderId",
                table: "AuditTable",
                column: "pull_order_navPullOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_supply_order_navSupplyOrderID",
                table: "AuditTable",
                column: "supply_order_navSupplyOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_InvToInvAudit_From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable",
                column: "From_Inv_To_Inv_Tracker_navTrs_ID",
                principalTable: "InvToInvAudit",
                principalColumn: "Trs_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_Items_itemCode",
                table: "AuditTable",
                column: "itemCode",
                principalTable: "Items",
                principalColumn: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_PullOrders_pull_order_navPullOrderId",
                table: "AuditTable",
                column: "pull_order_navPullOrderId",
                principalTable: "PullOrders",
                principalColumn: "PullOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditTable_SupplyOrders_supply_order_navSupplyOrderID",
                table: "AuditTable",
                column: "supply_order_navSupplyOrderID",
                principalTable: "SupplyOrders",
                principalColumn: "SupplyOrderID");
        }
    }
}
