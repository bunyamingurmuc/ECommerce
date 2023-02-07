using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dsadasdasas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTop",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4795), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4808), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4812), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4814), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4817), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4822), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4824), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4827), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4856), false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsNew", "IsTop" },
                values: new object[] { new DateTime(2023, 1, 22, 23, 49, 39, 24, DateTimeKind.Local).AddTicks(4860), false, false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsTop",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1876), new DateTime(2023, 1, 19, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 1, 18, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 1, 17, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1943), new DateTime(2023, 1, 16, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1946), new DateTime(2023, 1, 19, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1950), new DateTime(2023, 1, 18, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1953), new DateTime(2023, 1, 17, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 1, 16, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1958), new DateTime(2023, 1, 19, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 1, 18, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1968), new DateTime(2023, 1, 17, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1972), new DateTime(2023, 1, 16, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1976), new DateTime(2023, 1, 19, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1980), new DateTime(2023, 1, 18, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 1, 17, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 1, 16, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1989), new DateTime(2023, 1, 19, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 1, 18, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1995), new DateTime(2023, 1, 17, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1998), new DateTime(2023, 1, 15, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 32, 55, 688, DateTimeKind.Local).AddTicks(1427));
        }
    }
}
