using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodWorking.Data.Migrations
{
    public partial class AddEdges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.CreateTable(
                name: "Edges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "identityUserEdges",
                columns: table => new
                {
                    StoreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EdgeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identityUserEdges", x => new { x.StoreId, x.EdgeId });
                    table.ForeignKey(
                        name: "FK_identityUserEdges_AspNetUsers_StoreId",
                        column: x => x.StoreId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_identityUserEdges_Edges_EdgeId",
                        column: x => x.EdgeId,
                        principalTable: "Edges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Edges",
                columns: new[] { "Id", "Height", "Length", "Price" },
                values: new object[,]
                {
                    { 1, 0.45m, 0.45m, 1.39m },
                    { 2, 0.8m, 0.8m, 3.19m },
                    { 3, 2m, 2m, 2.79m },
                    { 4, 3m, 3m, 4.99m }
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { "1008461", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDgwODl8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMWIvaDViLzg5ODg2MDQzMDEzNDIuanBnfGFhYzY0MzI4ODNhZjQ0MDJjY2IyOWM4MGMxNDJkYTFjMzBlM2ViYzQzNjQzN2IyZDljMzZiOGU0YWY3ZjQ5OTM", "ПДЧ СВЕТЛО ХИКОРИ ЛАМИНИРАНО18X2800X2070", 39.99m });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { "1008465", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQxNDR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZmYvaGJhLzg5ODg2MzUyNjcxMDIuanBnfGQxMWM1YzBmNzg4NmI4OGI4ZGUyMzA5ZjM4YTY5MjNiOGI2MWQzZTRlYzIzZDY3N2RiYjI1ZTM2NjdmNmE3OGY", "ПДЧ БРЕЗА ЛАМИНИРАНО 18X2800X2070", 33.99m });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { "1008466", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDExNTI0fGltYWdlL2pwZWd8cHJvZHVjdHMvaGJhL2g5OC84OTg4NjMxODI2NDYyLmpwZ3wwMjZlYmNlYjk0NzRmMTI0MzcyM2JiZTM1ZGE5Y2I0ZjMyYjkzMGZlMGYwZjdiMzJiOTVhZjA1NjM3ZmUyZGQ5", "ПДЧ ДЪБ АМБЪР ЪРБЪН 18X2800X2070", 35.99m });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ANPF", "ImageUrl", "Name" },
                values: new object[] { "1008467", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg4NjF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMmMvaDM3Lzg5ODg2MjM1Njg5MjYuanBnfGExNTFmODdhMjllN2NjZDRiNzkxZDU3ZWY1MmY0NmY2MGIxMWQ2MzU0OTQ4N2E2M2RjNzZmZmE5OTlmODY4ZTU", "ПДЧ ЗЛАТЕН ДЪБ КРАФТ 18X2800X2070" });

            migrationBuilder.CreateIndex(
                name: "IX_identityUserEdges_EdgeId",
                table: "identityUserEdges",
                column: "EdgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "identityUserEdges");

            migrationBuilder.DropTable(
                name: "Edges");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { "991129------------------------------------------------------------------------------------------------", "", "ПДЧ ДЪБ КАФЕ ЛАМИНИРАНО 2800/2070/18ММ", 17.84m });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { "1008461", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDgwODl8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMWIvaDViLzg5ODg2MDQzMDEzNDIuanBnfGFhYzY0MzI4ODNhZjQ0MDJjY2IyOWM4MGMxNDJkYTFjMzBlM2ViYzQzNjQzN2IyZDljMzZiOGU0YWY3ZjQ5OTM", "ПДЧ СВЕТЛО ХИКОРИ ЛАМИНИРАНО18X2800X2070", 39.99m });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { "1008465", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQxNDR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZmYvaGJhLzg5ODg2MzUyNjcxMDIuanBnfGQxMWM1YzBmNzg4NmI4OGI4ZGUyMzA5ZjM4YTY5MjNiOGI2MWQzZTRlYzIzZDY3N2RiYjI1ZTM2NjdmNmE3OGY", "ПДЧ БРЕЗА ЛАМИНИРАНО 18X2800X2070", 33.99m });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ANPF", "ImageUrl", "Name" },
                values: new object[] { "1008466", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDExNTI0fGltYWdlL2pwZWd8cHJvZHVjdHMvaGJhL2g5OC84OTg4NjMxODI2NDYyLmpwZ3wwMjZlYmNlYjk0NzRmMTI0MzcyM2JiZTM1ZGE5Y2I0ZjMyYjkzMGZlMGYwZjdiMzJiOTVhZjA1NjM3ZmUyZGQ5", "ПДЧ ДЪБ АМБЪР ЪРБЪН 18X2800X2070" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[] { 24, "1008467", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg4NjF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMmMvaDM3Lzg5ODg2MjM1Njg5MjYuanBnfGExNTFmODdhMjllN2NjZDRiNzkxZDU3ZWY1MmY0NmY2MGIxMWQ2MzU0OTQ4N2E2M2RjNzZmZmE5OTlmODY4ZTU", "ПДЧ ЗЛАТЕН ДЪБ КРАФТ 18X2800X2070", 35.99m });
        }
    }
}
