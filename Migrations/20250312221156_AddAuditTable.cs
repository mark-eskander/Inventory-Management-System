using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItem");

            migrationBuilder.DropColumn(
                name: "DaysSinceLastUse",
                table: "InventoryItems");

            migrationBuilder.RenameColumn(
                name: "PhoneNumer",
                table: "Clients",
                newName: "PhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUse",
                table: "InventoryItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InvToInvAudit",
                columns: table => new
                {
                    Trs_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    from = table.Column<int>(type: "int", nullable: false),
                    to = table.Column<int>(type: "int", nullable: false),
                    item = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    Production_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expire_Limit = table.Column<int>(type: "int", nullable: false),
                    Trs_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    item_navCode = table.Column<int>(type: "int", nullable: true),
                    PullOrderId = table.Column<int>(type: "int", nullable: true),
                    SupplyOrderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvToInvAudit", x => x.Trs_ID);
                    table.ForeignKey(
                        name: "FK_InvToInvAudit_Inventories_from",
                        column: x => x.from,
                        principalTable: "Inventories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvToInvAudit_Inventories_to",
                        column: x => x.to,
                        principalTable: "Inventories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvToInvAudit_Items_item_navCode",
                        column: x => x.item_navCode,
                        principalTable: "Items",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_InvToInvAudit_PullOrders_PullOrderId",
                        column: x => x.PullOrderId,
                        principalTable: "PullOrders",
                        principalColumn: "PullOrderId");
                    table.ForeignKey(
                        name: "FK_InvToInvAudit_SupplyOrders_SupplyOrderID",
                        column: x => x.SupplyOrderID,
                        principalTable: "SupplyOrders",
                        principalColumn: "SupplyOrderID");
                });

            migrationBuilder.CreateTable(
                name: "AuditTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taregt_Inv = table.Column<int>(type: "int", nullable: false),
                    Item = table.Column<int>(type: "int", nullable: false),
                    AddOrPull = table.Column<byte>(type: "tinyint", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    QuantityAfter = table.Column<int>(type: "int", nullable: false),
                    Pull_Order_Id = table.Column<int>(type: "int", nullable: true),
                    Supply_Order_Id = table.Column<int>(type: "int", nullable: true),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    From_Inv_To_Inv_ID = table.Column<int>(type: "int", nullable: true),
                    inventoryID = table.Column<int>(type: "int", nullable: true),
                    itemCode = table.Column<int>(type: "int", nullable: true),
                    supply_order_navSupplyOrderID = table.Column<int>(type: "int", nullable: true),
                    pull_order_navPullOrderId = table.Column<int>(type: "int", nullable: true),
                    From_Inv_To_Inv_Tracker_navTrs_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AuditTable_InvToInvAudit_From_Inv_To_Inv_Tracker_navTrs_ID",
                        column: x => x.From_Inv_To_Inv_Tracker_navTrs_ID,
                        principalTable: "InvToInvAudit",
                        principalColumn: "Trs_ID");
                    table.ForeignKey(
                        name: "FK_AuditTable_Inventories_inventoryID",
                        column: x => x.inventoryID,
                        principalTable: "Inventories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AuditTable_Items_itemCode",
                        column: x => x.itemCode,
                        principalTable: "Items",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_AuditTable_PullOrders_pull_order_navPullOrderId",
                        column: x => x.pull_order_navPullOrderId,
                        principalTable: "PullOrders",
                        principalColumn: "PullOrderId");
                    table.ForeignKey(
                        name: "FK_AuditTable_SupplyOrders_supply_order_navSupplyOrderID",
                        column: x => x.supply_order_navSupplyOrderID,
                        principalTable: "SupplyOrders",
                        principalColumn: "SupplyOrderID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_From_Inv_To_Inv_Tracker_navTrs_ID",
                table: "AuditTable",
                column: "From_Inv_To_Inv_Tracker_navTrs_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTable_inventoryID",
                table: "AuditTable",
                column: "inventoryID");

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

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_from",
                table: "InvToInvAudit",
                column: "from");

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_item_navCode",
                table: "InvToInvAudit",
                column: "item_navCode");

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_PullOrderId",
                table: "InvToInvAudit",
                column: "PullOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_SupplyOrderID",
                table: "InvToInvAudit",
                column: "SupplyOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_InvToInvAudit_to",
                table: "InvToInvAudit",
                column: "to");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditTable");

            migrationBuilder.DropTable(
                name: "InvToInvAudit");

            migrationBuilder.DropColumn(
                name: "LastUse",
                table: "InventoryItems");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Clients",
                newName: "PhoneNumer");

            migrationBuilder.AlterColumn<int>(
                name: "Unit",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DaysSinceLastUse",
                table: "InventoryItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InventoryItem",
                columns: table => new
                {
                    InventoriesID = table.Column<int>(type: "int", nullable: false),
                    ItemsCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItem", x => new { x.InventoriesID, x.ItemsCode });
                    table.ForeignKey(
                        name: "FK_InventoryItem_Inventories_InventoriesID",
                        column: x => x.InventoriesID,
                        principalTable: "Inventories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryItem_Items_ItemsCode",
                        column: x => x.ItemsCode,
                        principalTable: "Items",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_ItemsCode",
                table: "InventoryItem",
                column: "ItemsCode");
        }
    }
}
