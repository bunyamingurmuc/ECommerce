using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dsadasdas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 1, 22, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6744), new DateTime(2023, 1, 21, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6748), new DateTime(2023, 1, 20, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 1, 19, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 1, 22, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 1, 21, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 1, 20, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 1, 19, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 1, 22, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 1, 21, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 1, 20, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 1, 19, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6785), new DateTime(2023, 1, 22, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6788), new DateTime(2023, 1, 21, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 1, 20, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6793), new DateTime(2023, 1, 19, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 1, 22, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 1, 21, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 1, 20, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 1, 18, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Email", "Password" },
                values: new object[] { new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6226), "1", "1" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CreatedDate", "Email", "IsDeleted", "Name", "Password", "SurName" },
                values: new object[] { 2, new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6232), "2", false, "seller2", "2", "seller122" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Sellers");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 1, 22, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 1, 21, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 1, 20, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 1, 19, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1396), new DateTime(2023, 1, 22, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1400), new DateTime(2023, 1, 21, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1404), new DateTime(2023, 1, 20, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1407), new DateTime(2023, 1, 19, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 1, 22, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 1, 21, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1416), new DateTime(2023, 1, 20, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 1, 19, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1422), new DateTime(2023, 1, 22, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1424), new DateTime(2023, 1, 21, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1427), new DateTime(2023, 1, 20, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1430), new DateTime(2023, 1, 19, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1433), new DateTime(2023, 1, 22, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1437), new DateTime(2023, 1, 21, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 1, 20, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 1, 18, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 20, 16, 13, 120, DateTimeKind.Local).AddTicks(940));
        }
    }
}
