using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StoreItems",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "aut", "Bike", 1.771604122021982m, 234 },
                    { 2, "ea", "Cheese", 1.985047052607428m, 83 },
                    { 3, "optio", "Gloves", 1.198489983192873m, 433 },
                    { 4, "doloribus", "Bacon", 1.411932913778319m, 282 },
                    { 5, "veniam", "Pants", 1.625375844363764m, 132 },
                    { 6, "in", "Pizza", 1.838818774949209m, 481 },
                    { 7, "accusamus", "Shirt", 1.0522617055346545m, 331 },
                    { 8, "dolorem", "Salad", 1.2657046361201m, 180 },
                    { 9, "praesentium", "Table", 1.479147566705545m, 30 },
                    { 10, "facere", "Sausages", 1.69259049729099m, 379 },
                    { 11, "quae", "Shoes", 1.906033427876436m, 229 },
                    { 12, "laboriosam", "Chips", 1.119476358461881m, 78 },
                    { 13, "harum", "Hat", 1.332919289047327m, 428 },
                    { 14, "molestiae", "Chair", 1.546362219632772m, 277 },
                    { 15, "eius", "Towels", 1.759805150218217m, 127 },
                    { 16, "excepturi", "Computer", 1.973248080803662m, 476 },
                    { 17, "aut", "Soap", 1.186691011389108m, 326 },
                    { 18, "aspernatur", "Keyboard", 1.400133941974553m, 175 },
                    { 19, "reprehenderit", "Tuna", 1.613576872559999m, 25 },
                    { 20, "nobis", "Mouse", 1.827019803145444m, 374 },
                    { 21, "reiciendis", "Chicken", 1.0404627337308893m, 224 },
                    { 22, "enim", "Bike", 1.253905664316335m, 73 },
                    { 23, "error", "Fish", 1.46734859490178m, 423 },
                    { 24, "vero", "Ball", 1.680791525487225m, 272 },
                    { 25, "sequi", "Cheese", 1.894234456072671m, 122 },
                    { 26, "ducimus", "Gloves", 1.107677386658116m, 471 },
                    { 27, "quod", "Bacon", 1.321120317243561m, 321 },
                    { 28, "aperiam", "Pants", 1.534563247829007m, 170 },
                    { 29, "voluptas", "Salad", 1.748006178414452m, 20 },
                    { 30, "dolorum", "Shirt", 1.961449108999897m, 369 },
                    { 31, "repudiandae", "Sausages", 1.174892039585343m, 219 },
                    { 32, "quia", "Table", 1.388334970170788m, 68 },
                    { 33, "et", "Chips", 1.601777900756233m, 418 },
                    { 34, "autem", "Shoes", 1.815220831341679m, 267 },
                    { 35, "dicta", "Chair", 1.028663761927124m, 117 },
                    { 36, "vel", "Hat", 1.242106692512569m, 466 },
                    { 37, "tempore", "Car", 1.455549623098015m, 316 },
                    { 38, "delectus", "Towels", 1.66899255368346m, 165 },
                    { 39, "quaerat", "Computer", 1.882435484268905m, 15 },
                    { 40, "omnis", "Soap", 1.0958784148543507m, 364 },
                    { 41, "pariatur", "Keyboard", 1.309321345439796m, 214 },
                    { 42, "qui", "Chicken", 1.522764276025241m, 63 },
                    { 43, "iusto", "Mouse", 1.736207206610687m, 413 },
                    { 44, "qui", "Fish", 1.949650137196132m, 262 },
                    { 45, "voluptatem", "Bike", 1.163093067781577m, 112 },
                    { 46, "ipsam", "Cheese", 1.376535998367023m, 461 },
                    { 47, "est", "Ball", 1.589978928952468m, 311 },
                    { 48, "ut", "Bacon", 1.803421859537914m, 160 },
                    { 49, "adipisci", "Gloves", 1.0168647901233587m, 10 },
                    { 50, "corrupti", "Pizza", 1.230307720708804m, 359 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "FullAddress", "IBAN", "Name" },
                values: new object[,]
                {
                    { 1, "779 Grady Plains, East Georgianafort, Chad", "HR7643916023", "Brown and Sons" },
                    { 2, "00337 Feil Row, Schulistfurt, Uganda", "HR1384207005", "Jakubowski, Cummerata and Wyman" },
                    { 3, "74254 Casper Terrace, Port Jacklynport, Malta", "HR1512933586", "Predovic Group" },
                    { 4, "8386 Krajcik Spurs, North Aylin, Haiti", "HR0064472535", "Zboncak, Maggio and Jenkins" },
                    { 5, "8240 Viola Corner, Satterfieldville, Saint Barthelemy", "HR6491951930", "Graham - Gislason" },
                    { 6, "663 Micheal Street, North Edwardbury, Benin", "HR9854747175", "Mayert, Windler and Smitham" },
                    { 7, "807 Quinn Hill, Chanelport, Honduras", "HR0360988494", "Swaniawski - Olson" },
                    { 8, "48838 Verdie Turnpike, New Randy, Niger", "HR8544921716", "Cruickshank, Hessel and Gleason" },
                    { 9, "97005 Oberbrunner Parkways, New Emelyfurt, Eritrea", "HR4249905948", "Koch - Beer" },
                    { 10, "11365 Cleta Village, Vernonmouth, Thailand", "HR7234296256", "Rolfson, Rosenbaum and Pouros" }
                });

            migrationBuilder.InsertData(
                table: "SupplierStoreItems",
                columns: new[] { "StoreId", "SupplierId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 5, 1 },
                    { 5, 2 },
                    { 6, 3 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 10 },
                    { 10, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 14, 2 },
                    { 14, 3 },
                    { 15, 4 },
                    { 16, 8 },
                    { 17, 9 },
                    { 17, 10 },
                    { 20, 6 },
                    { 20, 7 },
                    { 21, 8 },
                    { 22, 2 },
                    { 23, 4 },
                    { 23, 5 },
                    { 25, 9 },
                    { 26, 1 },
                    { 26, 10 },
                    { 28, 7 },
                    { 29, 8 },
                    { 29, 9 },
                    { 31, 3 },
                    { 31, 4 },
                    { 32, 6 },
                    { 34, 1 },
                    { 35, 2 },
                    { 35, 3 },
                    { 37, 8 },
                    { 37, 9 },
                    { 38, 10 },
                    { 40, 5 },
                    { 41, 7 },
                    { 43, 2 },
                    { 43, 3 },
                    { 44, 4 },
                    { 46, 9 },
                    { 46, 10 },
                    { 47, 1 },
                    { 49, 6 },
                    { 49, 7 },
                    { 50, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 31, 4 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 37, 9 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 43, 3 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 49, 6 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "SupplierStoreItems",
                keyColumns: new[] { "StoreId", "SupplierId" },
                keyValues: new object[] { 50, 9 });

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
