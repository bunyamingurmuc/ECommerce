using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dasdasdas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5835), new DateTime(2023, 1, 21, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 1, 20, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 1, 19, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5860), new DateTime(2023, 1, 18, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 1, 21, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 1, 20, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 1, 19, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 1, 18, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 1, 21, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 1, 20, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 1, 19, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 1, 18, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 1, 21, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 1, 20, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 1, 19, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 1, 18, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 1, 21, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5964), new DateTime(2023, 1, 20, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 1, 19, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5969), new DateTime(2023, 1, 17, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(5351));
        }
    }
}
