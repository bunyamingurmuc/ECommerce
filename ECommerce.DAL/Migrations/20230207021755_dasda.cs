using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dasda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 2, 6, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7096), new DateTime(2023, 2, 5, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 2, 4, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7103), new DateTime(2023, 2, 3, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 2, 6, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7110), new DateTime(2023, 2, 5, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 2, 4, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7116), new DateTime(2023, 2, 3, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7118), new DateTime(2023, 2, 6, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7122), new DateTime(2023, 2, 5, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 2, 4, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7154), new DateTime(2023, 2, 3, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7157), new DateTime(2023, 2, 6, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7160), new DateTime(2023, 2, 5, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 2, 4, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7166), new DateTime(2023, 2, 3, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7169), new DateTime(2023, 2, 6, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7173), new DateTime(2023, 2, 5, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7175), new DateTime(2023, 2, 4, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7178), new DateTime(2023, 2, 2, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 7, 5, 17, 54, 765, DateTimeKind.Local).AddTicks(6606));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 23, 22, 38, 24, 400, DateTimeKind.Local).AddTicks(6232));
        }
    }
}
