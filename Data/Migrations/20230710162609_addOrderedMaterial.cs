using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodWorking.Data.Migrations
{
    public partial class addOrderedMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserOrders_Order_OrderId",
                table: "IdentityUserOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material10TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material11TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material12TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material1TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material2TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material3TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material4TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material5TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material6TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material7TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material8TotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9EdgeH1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9EdgeH2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9EdgeL1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9EdgeL2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9EdgeTotalPrice",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9Height",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9Length",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9Name",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9Price",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9Qty",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9Quadrature",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Material9TotalPrice",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderedMaterials",
                columns: table => new
                {
                    OrderedMaterialsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialLength = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialHeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialQty = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialQuadrature = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialTotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeH1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeH2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeL1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeL2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeTotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedMaterials", x => x.OrderedMaterialsId);
                    table.ForeignKey(
                        name: "FK_OrderedMaterials_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedMaterials_OrderId",
                table: "OrderedMaterials",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserOrders_Orders_OrderId",
                table: "IdentityUserOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserOrders_Orders_OrderId",
                table: "IdentityUserOrders");

            migrationBuilder.DropTable(
                name: "OrderedMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.AddColumn<decimal>(
                name: "Material10EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material10Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material10TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material11Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material11TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material12Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material12TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material1Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material1TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material2Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material2TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material3Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material3TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material4Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material4TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material5Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material5TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material6Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material6TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material7Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material7TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material8Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material8TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9EdgeH1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9EdgeH2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9EdgeL1",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9EdgeL2",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9EdgeTotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9Height",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9Length",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Material9Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9Price",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9Qty",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9Quadrature",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Material9TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserOrders_Order_OrderId",
                table: "IdentityUserOrders",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
