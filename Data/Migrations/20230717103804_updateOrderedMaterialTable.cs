using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodWorking.Data.Migrations
{
    public partial class updateOrderedMaterialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MaterialEdgeH1Price",
                table: "OrderedMaterials",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialEdgeH2Price",
                table: "OrderedMaterials",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialEdgeL1Price",
                table: "OrderedMaterials",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaterialEdgeL2Price",
                table: "OrderedMaterials",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialEdgeH1Price",
                table: "OrderedMaterials");

            migrationBuilder.DropColumn(
                name: "MaterialEdgeH2Price",
                table: "OrderedMaterials");

            migrationBuilder.DropColumn(
                name: "MaterialEdgeL1Price",
                table: "OrderedMaterials");

            migrationBuilder.DropColumn(
                name: "MaterialEdgeL2Price",
                table: "OrderedMaterials");
        }
    }
}
