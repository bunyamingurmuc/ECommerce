using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dasdasdasaa5ada5dsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUsers_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    ConversationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingPrice = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Orders_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CardItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    RemoveCount = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardItems_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    IsStock = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    SalePrice = table.Column<double>(type: "float", nullable: true),
                    Ratings = table.Column<double>(type: "float", nullable: true),
                    IsHomeProduct = table.Column<bool>(type: "bit", nullable: true),
                    SalesQuantity = table.Column<int>(type: "int", nullable: true),
                    RemoveCount = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    SellerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Base64Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPrice = table.Column<double>(type: "float", nullable: true),
                    ProductDiscount = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "Discount", "IsDeleted", "TotalPrice" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3667), 15, false, 2000.0 });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "SurName" },
                values: new object[] { 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3520), false, "seller1", "seller12" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Address", "CardId", "CreatedDate", "Email", "IsDeleted", "Name", "Password", "SellerId", "SurName" },
                values: new object[] { 1, "adress", 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2740), "email", false, "dasd", "1", 1, "dasdas" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "ImageId", "IsDeleted", "Name", "SellerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3208), null, false, "cat1", 1 },
                    { 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3212), null, false, "cat2", 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "AppUserId", "City", "ConversationId", "CreatedDate", "Discount", "Email", "FirstName", "IsDeleted", "LastName", "Note", "OrderDate", "OrderNumber", "OrderStatus", "PaymentId", "Phone", "SellerId", "ShippingPrice", "TotalPrice" },
                values: new object[,]
                {
                    { 1, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3988), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3991), "A5845DS1", 1, "1", "+9055512548", 1, 25.0, 2520.0 },
                    { 2, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4004), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4005), "A5845DS2", 1, "1", "+9055512548", 1, 25.0, 2120.0 },
                    { 3, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4008), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4009), "A5845DS3", 1, "1", "+9055512548", 1, 25.0, 220.0 },
                    { 4, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4013), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4013), "A5845DS4", 1, "1", "+9055512548", 1, 25.0, 4520.0 },
                    { 5, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4017), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4018), "A5845DS5", 1, "1", "+9055512548", 1, 25.0, 2820.0 },
                    { 6, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4066), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4067), "A5845DS6", 1, "1", "+9055512548", 1, 25.0, 2520.0 },
                    { 7, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4073), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4073), "A5845DS7", 1, "1", "+9055512548", 1, 25.0, 28820.0 },
                    { 8, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4077), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4078), "A5845DS8", 1, "1", "+9055512548", 1, 25.0, 1220.0 },
                    { 9, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4080), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4080), "A5845DS9", 1, "1", "+9055512548", 1, 25.0, 5820.0 },
                    { 10, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4083), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4084), "A5845DS0", 1, "1", "+9055512548", 1, 25.0, 20.0 },
                    { 11, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4087), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4087), "A5845DS1", 1, "1", "+9055512548", 1, 25.0, 2520.0 },
                    { 12, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4089), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4091), "A5845DS2", 1, "1", "+9055512548", 1, 25.0, 8520.0 },
                    { 13, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4094), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4094), "A5845DS3", 1, "1", "+9055512548", 1, 25.0, 2520.0 },
                    { 14, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4097), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4098), "A5845DS4", 1, "1", "+9055512548", 1, 25.0, 22520.0 },
                    { 15, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4100), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4101), "A5845DS5", 1, "1", "+9055512548", 1, 25.0, 2820.0 },
                    { 16, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4103), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 16, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4103), "A5845DS6", 1, "1", "+9055512548", 1, 25.0, 250.0 },
                    { 17, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4105), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 19, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4106), "A5845DS7", 1, "1", "+9055512548", 1, 25.0, 25250.0 },
                    { 18, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4111), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 18, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4111), "A5845DS8", 1, "1", "+9055512548", 1, 25.0, 2250.0 },
                    { 19, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4114), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 17, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4114), "A5845DS9", 1, "1", "+9055512548", 1, 25.0, 2250.0 },
                    { 20, "dsadasda", 1, "ankara", "5", new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4116), 20, "sdadas@dasdsa.com", "dasdasdas", false, "sdadasda", "dsadasdas", new DateTime(2023, 1, 15, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(4117), "A5845DS0", 1, "1", "+9055512548", 1, 25.0, 2250.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Discount", "IsDeleted", "IsHomeProduct", "IsStock", "Name", "Price", "Ratings", "RemoveCount", "SalePrice", "SalesQuantity", "SellerId", "StockCount", "Unit" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2933), "prodcu1", 15, false, true, true, "product1", 2000.0, 4.2000000000000002, 2, 1800.0, 5, 1, 2, null },
                    { 2, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2954), "prodcu2", 20, false, true, true, "product2", 5000.0, 3.2000000000000002, 12, 1800.0, 5, 1, 25, null },
                    { 3, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2958), "prodcu3", 0, false, true, true, "product3", 6000.0, 5.2000000000000002, 10, 1800.0, 100, 1, 100, null },
                    { 4, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2961), "prodcu4", 0, false, true, true, "product4", 2800.0, 9.1999999999999993, 15, 1800.0, 21, 1, 15, null },
                    { 5, 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(2963), "prodcu5", 15, false, true, true, "product5", 4500.0, 6.2000000000000002, 2, 1800.0, 25, 1, 10, null },
                    { 6, 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3004), "prodcu6", 25, false, true, true, "product6", 22500.0, 2.2000000000000002, 3, 1800.0, 1100, 1, 9, null },
                    { 7, 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3008), "prodcu7", 40, false, true, true, "product7", 2200.0, 5.2000000000000002, 5, 1800.0, 60, 1, 65, null },
                    { 8, 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3010), "prodcu8", 13, false, true, true, "product8", 6500.0, 5.5, 6, 1800.0, 550, 1, 1, null },
                    { 9, 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3013), "prodcu9", 17, false, true, false, "product9", 7800.0, 3.1000000000000001, 1, 1800.0, 25, 1, 0, null },
                    { 10, 2, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3018), "prodc10u", 7, false, true, true, "product10", 15800.0, 3.7999999999999998, 0, 1800.0, 1000, 1, 65, null }
                });

            migrationBuilder.InsertData(
                table: "CardItems",
                columns: new[] { "Id", "Amount", "CardId", "CreatedDate", "IsDeleted", "ProductId", "Quantity", "RemoveCount" },
                values: new object[,]
                {
                    { 1, 12.0, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3836), false, 1, 2, 2 },
                    { 2, 12.0, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3840), false, 2, 3, 2 },
                    { 3, 12.0, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3841), false, 3, 1, 2 },
                    { 4, 12.0, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3843), false, 4, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "Description", "IsDeleted", "ProductId", "Rate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3357), "review", false, 1, 2.0 },
                    { 2, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3362), "review", false, 2, 2.0 },
                    { 3, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3364), "review", false, 3, 2.0 },
                    { 4, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3365), "review", false, 4, 2.0 },
                    { 5, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3366), "review", false, 5, 2.0 },
                    { 6, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3368), "review", false, 6, 2.0 },
                    { 7, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3370), "review", false, 7, 2.0 },
                    { 8, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3371), "review", false, 8, 2.0 },
                    { 9, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3372), "review", false, 9, 2.0 },
                    { 10, 1, new DateTime(2023, 1, 20, 19, 19, 1, 871, DateTimeKind.Local).AddTicks(3374), "review", false, 10, 2.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CardId",
                table: "AppUsers",
                column: "CardId",
                unique: true,
                filter: "[CardId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_SellerId",
                table: "AppUsers",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_CardId",
                table: "CardItems",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_ProductId",
                table: "CardItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ImageId",
                table: "Categories",
                column: "ImageId",
                unique: true,
                filter: "[ImageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SellerId",
                table: "Categories",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerId",
                table: "Orders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AppUserId",
                table: "Reviews",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardItems_Products_ProductId",
                table: "CardItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Images_ImageId",
                table: "Categories",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sellers_SellerId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sellers_SellerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "CardItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
