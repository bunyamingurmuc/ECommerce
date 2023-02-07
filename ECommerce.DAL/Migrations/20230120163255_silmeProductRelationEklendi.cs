using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class silmeProductRelationEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "CardItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4008), new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4013), new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4066), new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4073), new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4077), new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4080), new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4083), new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4087), new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4089), new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4100), new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4103), new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4114), new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "OrderDate" },
                values: new object[] { new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4116), new DateTime(2023, 1, 15, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3520));
        }
    }
}
