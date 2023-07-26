using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodWorking.Data.Migrations
{
    public partial class addedContact3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contacts");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "София бул. „Цариградско шосе”", "София Младост", "02/9602059" },
                    { 2, "София бул. „Околовръстно шосе”", "София Ринг Мол", "02/4053600" },
                    { 3, "София бул. „Околовръстно шосе”", "София Ринг Мол", "02/9216300" },
                    { 4, "Перник ул. „Юрий Гагарин”", "Перник", "0884 43 15 94" },
                    { 5, "Благоевград жк. „Струмско”, ул. „Яне Сандански”", "Благоевград", "073/829500" },
                    { 6, "Пловдив ул. „Македония”", "Пловдив 2", "032/307779" },
                    { 7, "Пловдив бул. „6 септември”", "Пловдив 1", "032/605259" },
                    { 8, "Плевен ул. „Асен Халачев", "Плевен", "064/884900" },
                    { 9, "Русе бул. „Липник”", "Русе", "082/887810" },
                    { 10, "Бургас бул. „Захари Стоянов”", "Бургас", "056/874760" },
                    { 11, "Варна жк. Младост, ул. „Вяра”", "Варна", "052/572559" },
                    { 12, "Добрич Околовръстен път „Добротица”, изхода за Албена", "Добрич", "058/651680" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
