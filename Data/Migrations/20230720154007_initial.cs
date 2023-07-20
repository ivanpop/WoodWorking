using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodWorking.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ANPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpress = table.Column<bool>(type: "bit", nullable: false),
                    MaterialPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EdgePrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserEdges",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EdgeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserEdges", x => new { x.UserId, x.EdgeId });
                    table.ForeignKey(
                        name: "FK_IdentityUserEdges_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUserEdges_Edges_EdgeId",
                        column: x => x.EdgeId,
                        principalTable: "Edges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserOrders",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserOrders", x => new { x.UserId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_IdentityUserOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUserOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderedMaterials",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialLength = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialHeight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialQty = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialQuadrature = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialTotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeH1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeH1Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialEdgeH2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeH2Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialEdgeL1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeL1Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialEdgeL2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaterialEdgeL2Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialEdgeTotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OrderId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedMaterials", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderedMaterials_Orders_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Orders",
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

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "ANPF", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "984754", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEyMzM0fGltYWdlL2pwZWd8cHJvZHVjdHMvaGI5L2g3YS84ODU3NTE4ODMzNjk0LmpwZ3w2ZGIwZmFhMzRjM2UwZDEzOThiYWY1NDk0ZTM1YWJiZWUyYzM0MWNhYzM2N2Y2ODZjMzQwMTY1ZDg3N2FiNzc1", "сурови ПДЧ - 5,80м2/пл.", 25.99m },
                    { 2, "984757", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEwNTkxfGltYWdlL2pwZWd8cHJvZHVjdHMvaGEwL2g3YS84ODU3NTE5MjkyNDQ2LmpwZ3xlODQ5NjA3NTY2OTVkODczMzNkMGZlYmEzNjI2OWY1M2EwMjg0MDEzM2I0MmYxN2E0ZDFhZTY5OTNkNjVlYWNk", "Натур.HDF - 5,80м2/пл.", 11.49m },
                    { 3, "984763", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDE2OTF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oM2EvaGIyLzg5OTAxOTYwMDY5NDIuanBnfGE1MjBjM2M1ZmYxM2VkN2Y5YWRiMDUxZWQ1YjFiZjAwZDhiNjU3MjY2NjNhYTc5ZWJlNmE5OTRkZGMyODM1NTA", "0101 PE БЯЛ - 5,80m2/плоча", 12.59m },
                    { 4, "984764", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQ4NjV8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNDUvaDcwLzg4NTc5Mzk3NzE0MjIuanBnfGYxMjZhNjhmODJkZjZlYmE0YmE4ZjY0YzdhYzVmNDM3OGIyNjU2MTg1ZDk5YmJhY2VkOTNkZjExMGNmNTJiZGQ", "0381 PE БУК - 5,80m2/плоча", 12.59m },
                    { 5, "984765", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDU3MjZ8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZDAvaGUyLzg5OTAyMDkwODEzNzQuanBnfDM0OWNjODQzZDZmYjVlMDQyYTBhZDI5Njg5ZTYxMmUxODMyMzU2MzJhZDdmMmM1Nzk0MzdhNjk0OGIyZjFiMzc", "0344 PE ТЪМНА ЧЕРЕША - 5,80m2/плоча", 12.59m },
                    { 6, "984767", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQyMTZ8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZDEvaDk4Lzg4NTc1MjAyMDk5NTAuanBnfDBhZTU0NDRjOGU3MjcyMTMwYmYwYjBjNDJiNTI0NDFlNjljNzQzM2M1OGI3MDU5NTJiYWMwNTBhYWQ2YTJjMWU", "0854 PE ВЕНГЕ - 5,80m2/плоча", 12.59m },
                    { 7, "1008418", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDE2MTV8aW1hZ2UvanBlZ3xoNjUvaGEyLzkxNzA1NjU4OTAwNzh8YWUyZDhlMzE0NzQxNWQ2NmE1NDg4MjA0NWJjOWUwNDZiZmYyZjAwZTVhZDg0ZmMxYTY1ZWI4NjhhZDkyM2NjOA", "0110 SM БЯЛО - 5,80м2/плоча", 25.99m },
                    { 8, "984770", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQ2Njh8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oYjIvaDJhLzg4NTc1MjE1ODYyMDYuanBnfGZkZWNhMGQ4MTFmZWIyMDdkYjdkOTQzZjM3M2U0ZmQ2NThhYjA5MzdlZjVlZjUyNjg2NmU4NzMwMjU3YTE5Yzg", "0381 PR БУК - 5,80м2/плоча", 30.99m },
                    { 9, "984771", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg3NTh8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZDUvaDdkLzg4NTc1MjIwNDQ5NTguanBnfDM0MjgyYzk2MTkwOWU5YmU0Yzg4ZDkzNjMwOTI5NjU0YjRmNjg2N2Y5MzBiYTExYmRjYzk2ZjUxOWY0ZWY3NzM", "0854 BS ВЕНГЕ - 5,80м2/плоча", 30.99m },
                    { 10, "984773", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDIyMDR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNTMvaDRiLzg4NTc1MjI1MDM3MTAuanBnfDNhMWJkMjlkZmRjZmY4MWQ0ZTI4NTRkY2FhY2M4YjgxMDY1ODY5N2ZjMDc4YjlkYTBjZjdiMWMzMTAyYmI5NTc", "0190 PE ЧЕРНО -5,80м2/плоча", 30.99m },
                    { 11, "984775", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDIxNjh8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNGUvaDRlLzg4NTc1MjI5NjI0NjIuanBnfDUzYWEyZWE5M2IxODVhMTk0YTk5NGVkY2Y1YTNlODg2MDMxZDY0NjMzMTQ3ZWQ3NzM1OWY2NTFmNzE0Mjk4ZDM", "0514 PE СЛОНОВА КОСТ - 5,80м2/плоча", 30.99m },
                    { 12, "984776", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDk2MTd8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMWQvaDY5Lzg4NTc1MjM0MjEyMTQuanBnfGJmYzk1NTkwMTM5OWM3MmZiMjk5OGFlNWNmNTI0ODMyYzAxZWU4YzU4YTQyNDk2YWRlY2NkMWM5OWMwMWU3NjY", "3025 SU ДЪБ СОНОМА - 5,80м2/плоча", 30.99m },
                    { 13, "984780", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDIwNzF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oY2QvaDc3Lzg4NTc1MjM4Nzk5NjYuanBnfDM0NjUyZDAyNjBmMjdlOGI2MGNmOGM0NWVkNzFiYjMzNWQxZGY3YmJjMWE5MTQ0ZWQ4MGZkMDg2MzVlMWE0ZDE", "0112 PЕ СИВО - 5,80м2/плоча", 32.99m },
                    { 14, "984787", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDY3MDN8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMTgvaDViLzg4NTc1MjUyNTYyMjIuanBnfDg3ZWUwNWNmNzUyOGZiOTI5YTc4MjEyOGI0NjIzYjk0YjM1OTc3ZDQxYTQ5YzAwYjUwOTMwNWJjMmY5NGE4NTg", "K001 PW БЯЛ ДЪБ - 5,80м2/плоча", 32.99m },
                    { 15, "1008468", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEwNzE1fGltYWdlL2pwZWd8cHJvZHVjdHMvaDIzL2gwZi84OTg4NDUwODgxNTY2LmpwZ3w1YjU5ZDMzMWRjMDM1OGFjYTY1MGIyZjMwNzY4Mzk5NWExODM5YjE4ZjU0YzgyM2UxMTNjYWViZjIzNzFlZWJm", "ПДЧ ДЪБ ЕВОУК КОУСТ 18X2800X2070", 39.99m },
                    { 16, "1008469", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg2MTJ8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNmUvaDdlLzg5ODg0NDkwNDY1NTguanBnfDBmNGI1YzE5ZTZlYzQxMTMxMGI4N2FlYTE3MzRiZTA0MjkzMjU3NzIxOGU5MjkyNzFhYzZiMWFlMmE2NTkxOGM", "ПДЧ КОНЯК КАСТЕЛО 18X2800X2070", 31.99m },
                    { 17, "992002", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEyMjExfGltYWdlL2pwZWd8cHJvZHVjdHMvaDQyL2hmOC84OTkwMjA5OTk4ODc4LmpwZ3w5ZGY4NzkzMTdmMzg0ZDFmZWU0YWYxYzc4NjVmMjE1YjM5ZjMwZDdjYzQ1YTdlZjY1Y2E3MDEzNDQ4ODEzODM5", "ПДЧ ДЪБЪРБАН ОЙСТЪР ЛАМИНИРАНО", 33.99m },
                    { 18, "985511", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEwMzQxfGltYWdlL2pwZWd8cHJvZHVjdHMvaDY5L2hjNS84ODU3NTI4MDA4NzM0LmpwZ3xmZjBkZDQ4YmYzOWNhMGFhMzBkMDg0OGViYWQ5YmUzMTMzZWFiN2U5MGIyMWQ2N2M0NmFiNTIzYzU1YzE2ODE3", "MDF НАТУРАЛЕН 18ММ", 39.99m },
                    { 19, "991128", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDc5MjR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMzQvaDNjLzg5OTAxOTUwODk0MzguanBnfGY0OTQ5MWQ3MGM5Y2I3NTc4ZGU3OTczZWZmNTE3NGE5YjQ4MWVjYjcwMDZkZmI3NGFhNzlkNzNhNGJlOGRkMjY", "ПДЧ ОРЕХ ЛАМИНИРАНО 2800/2070/18ММ", 33.99m },
                    { 20, "1008461", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDgwODl8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMWIvaDViLzg5ODg2MDQzMDEzNDIuanBnfGFhYzY0MzI4ODNhZjQ0MDJjY2IyOWM4MGMxNDJkYTFjMzBlM2ViYzQzNjQzN2IyZDljMzZiOGU0YWY3ZjQ5OTM", "ПДЧ СВЕТЛО ХИКОРИ ЛАМИНИРАНО18X2800X2070", 39.99m },
                    { 21, "1008465", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQxNDR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZmYvaGJhLzg5ODg2MzUyNjcxMDIuanBnfGQxMWM1YzBmNzg4NmI4OGI4ZGUyMzA5ZjM4YTY5MjNiOGI2MWQzZTRlYzIzZDY3N2RiYjI1ZTM2NjdmNmE3OGY", "ПДЧ БРЕЗА ЛАМИНИРАНО 18X2800X2070", 33.99m },
                    { 22, "1008466", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDExNTI0fGltYWdlL2pwZWd8cHJvZHVjdHMvaGJhL2g5OC84OTg4NjMxODI2NDYyLmpwZ3wwMjZlYmNlYjk0NzRmMTI0MzcyM2JiZTM1ZGE5Y2I0ZjMyYjkzMGZlMGYwZjdiMzJiOTVhZjA1NjM3ZmUyZGQ5", "ПДЧ ДЪБ АМБЪР ЪРБЪН 18X2800X2070", 35.99m },
                    { 23, "1008467", "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg4NjF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMmMvaDM3Lzg5ODg2MjM1Njg5MjYuanBnfGExNTFmODdhMjllN2NjZDRiNzkxZDU3ZWY1MmY0NmY2MGIxMWQ2MzU0OTQ4N2E2M2RjNzZmZmE5OTlmODY4ZTU", "ПДЧ ЗЛАТЕН ДЪБ КРАФТ 18X2800X2070", 35.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserEdges_EdgeId",
                table: "IdentityUserEdges",
                column: "EdgeId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserOrders_OrderId",
                table: "IdentityUserOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedMaterials_OrderId1",
                table: "OrderedMaterials",
                column: "OrderId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserEdges");

            migrationBuilder.DropTable(
                name: "IdentityUserOrders");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "OrderedMaterials");

            migrationBuilder.DropTable(
                name: "Edges");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
