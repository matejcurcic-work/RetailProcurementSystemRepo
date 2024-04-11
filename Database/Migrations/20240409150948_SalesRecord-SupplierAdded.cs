using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class SalesRecordSupplierAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "SalesRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "SalesRecords",
                columns: new[] { "Id", "QuantitySold", "SaleDate", "StoreItemId", "SupplierId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 47, new DateTime(2023, 12, 6, 8, 48, 33, 363, DateTimeKind.Local).AddTicks(7109), 13, 2, 388.086019790771180m },
                    { 2, 17, new DateTime(2023, 5, 19, 14, 39, 36, 20, DateTimeKind.Local).AddTicks(9289), 39, 5, 492.673055777639720m },
                    { 3, 87, new DateTime(2023, 10, 31, 20, 30, 38, 678, DateTimeKind.Local).AddTicks(907), 15, 7, 107.260091764507770m },
                    { 4, 57, new DateTime(2023, 4, 14, 2, 21, 41, 335, DateTimeKind.Local).AddTicks(2523), 41, 10, 211.847127751376310m },
                    { 5, 27, new DateTime(2023, 9, 26, 8, 12, 43, 992, DateTimeKind.Local).AddTicks(4138), 17, 3, 316.434163738244360m },
                    { 6, 97, new DateTime(2024, 3, 9, 14, 3, 46, 649, DateTimeKind.Local).AddTicks(5753), 44, 6, 421.021199725112410m },
                    { 7, 67, new DateTime(2023, 8, 21, 19, 54, 49, 306, DateTimeKind.Local).AddTicks(7367), 20, 9, 35.6082357119807050m },
                    { 8, 36, new DateTime(2024, 2, 3, 1, 45, 51, 963, DateTimeKind.Local).AddTicks(8980), 46, 2, 140.1952716988490m },
                    { 9, 6, new DateTime(2023, 7, 17, 7, 36, 54, 621, DateTimeKind.Local).AddTicks(623), 22, 5, 244.782307685717050m },
                    { 10, 76, new DateTime(2023, 12, 29, 13, 27, 57, 278, DateTimeKind.Local).AddTicks(2238), 48, 8, 349.36934367258510m },
                    { 11, 46, new DateTime(2023, 6, 11, 19, 18, 59, 935, DateTimeKind.Local).AddTicks(3851), 24, 1, 453.956379659453640m },
                    { 12, 16, new DateTime(2023, 11, 24, 1, 10, 2, 592, DateTimeKind.Local).AddTicks(5467), 50, 4, 68.543415646321690m },
                    { 13, 86, new DateTime(2023, 5, 7, 7, 1, 5, 249, DateTimeKind.Local).AddTicks(7081), 26, 7, 173.130451633190230m },
                    { 14, 56, new DateTime(2023, 10, 19, 12, 52, 7, 906, DateTimeKind.Local).AddTicks(8695), 3, 10, 277.717487620058280m },
                    { 15, 26, new DateTime(2024, 4, 1, 18, 43, 10, 564, DateTimeKind.Local).AddTicks(309), 29, 3, 382.304523606926330m },
                    { 16, 96, new DateTime(2023, 9, 14, 0, 34, 13, 221, DateTimeKind.Local).AddTicks(1951), 5, 6, 486.891559593794380m },
                    { 17, 66, new DateTime(2024, 2, 26, 6, 25, 15, 878, DateTimeKind.Local).AddTicks(3563), 31, 9, 101.478595580662920m },
                    { 18, 35, new DateTime(2023, 8, 9, 12, 16, 18, 535, DateTimeKind.Local).AddTicks(5177), 7, 1, 206.065631567530970m },
                    { 19, 5, new DateTime(2024, 1, 21, 18, 7, 21, 192, DateTimeKind.Local).AddTicks(6794), 33, 4, 310.652667554399510m },
                    { 20, 75, new DateTime(2023, 7, 4, 23, 58, 23, 849, DateTimeKind.Local).AddTicks(8407), 9, 7, 415.239703541267560m },
                    { 21, 45, new DateTime(2023, 12, 17, 5, 49, 26, 507, DateTimeKind.Local).AddTicks(21), 35, 10, 29.8267395281357570m },
                    { 22, 15, new DateTime(2023, 5, 30, 11, 40, 29, 164, DateTimeKind.Local).AddTicks(1635), 11, 3, 134.413775515004150m },
                    { 23, 85, new DateTime(2023, 11, 11, 17, 31, 31, 821, DateTimeKind.Local).AddTicks(3250), 38, 6, 239.00081150187220m },
                    { 24, 55, new DateTime(2023, 4, 24, 23, 22, 34, 478, DateTimeKind.Local).AddTicks(4892), 14, 9, 343.587847488740250m },
                    { 25, 25, new DateTime(2023, 10, 7, 5, 13, 37, 135, DateTimeKind.Local).AddTicks(6507), 40, 2, 448.174883475608790m },
                    { 26, 95, new DateTime(2024, 3, 20, 11, 4, 39, 792, DateTimeKind.Local).AddTicks(8119), 16, 5, 62.761919462476840m },
                    { 27, 65, new DateTime(2023, 9, 1, 16, 55, 42, 449, DateTimeKind.Local).AddTicks(9731), 42, 8, 167.348955449344890m },
                    { 28, 34, new DateTime(2024, 2, 13, 22, 46, 45, 107, DateTimeKind.Local).AddTicks(1345), 18, 1, 271.935991436213430m },
                    { 29, 4, new DateTime(2023, 7, 28, 4, 37, 47, 764, DateTimeKind.Local).AddTicks(2957), 44, 4, 376.523027423081480m },
                    { 30, 74, new DateTime(2024, 1, 9, 10, 28, 50, 421, DateTimeKind.Local).AddTicks(4571), 20, 7, 481.110063409949530m },
                    { 31, 44, new DateTime(2023, 6, 22, 16, 19, 53, 78, DateTimeKind.Local).AddTicks(6212), 47, 10, 95.697099396818070m },
                    { 32, 14, new DateTime(2023, 12, 4, 22, 10, 55, 735, DateTimeKind.Local).AddTicks(7827), 23, 3, 200.284135383686120m },
                    { 33, 84, new DateTime(2023, 5, 18, 4, 1, 58, 392, DateTimeKind.Local).AddTicks(9440), 49, 6, 304.871171370554170m },
                    { 34, 54, new DateTime(2023, 10, 30, 9, 53, 1, 50, DateTimeKind.Local).AddTicks(1053), 25, 8, 409.458207357422710m },
                    { 35, 24, new DateTime(2023, 4, 12, 15, 44, 3, 707, DateTimeKind.Local).AddTicks(2665), 1, 1, 24.045243344290760m },
                    { 36, 94, new DateTime(2023, 9, 24, 21, 35, 6, 364, DateTimeKind.Local).AddTicks(4279), 27, 4, 128.632279331158810m },
                    { 37, 64, new DateTime(2024, 3, 8, 3, 26, 9, 21, DateTimeKind.Local).AddTicks(5893), 3, 7, 233.219315318027350m },
                    { 38, 33, new DateTime(2023, 8, 20, 9, 17, 11, 678, DateTimeKind.Local).AddTicks(7506), 29, 10, 337.80635130489540m },
                    { 39, 3, new DateTime(2024, 2, 1, 15, 8, 14, 335, DateTimeKind.Local).AddTicks(9146), 6, 3, 442.393387291763450m },
                    { 40, 73, new DateTime(2023, 7, 15, 20, 59, 16, 993, DateTimeKind.Local).AddTicks(759), 32, 6, 56.9804232786318430m },
                    { 41, 43, new DateTime(2023, 12, 28, 2, 50, 19, 650, DateTimeKind.Local).AddTicks(2374), 8, 9, 161.567459265500040m },
                    { 42, 13, new DateTime(2023, 6, 10, 8, 41, 22, 307, DateTimeKind.Local).AddTicks(3986), 34, 2, 266.154495252368090m },
                    { 43, 83, new DateTime(2023, 11, 22, 14, 32, 24, 964, DateTimeKind.Local).AddTicks(5600), 10, 5, 370.741531239236630m },
                    { 44, 53, new DateTime(2023, 5, 5, 20, 23, 27, 621, DateTimeKind.Local).AddTicks(7214), 36, 8, 475.328567226104680m },
                    { 45, 23, new DateTime(2023, 10, 18, 2, 14, 30, 278, DateTimeKind.Local).AddTicks(8826), 12, 1, 89.915603212972730m },
                    { 46, 93, new DateTime(2024, 3, 31, 8, 5, 32, 936, DateTimeKind.Local).AddTicks(467), 38, 4, 194.502639199841270m },
                    { 47, 63, new DateTime(2023, 9, 12, 13, 56, 35, 593, DateTimeKind.Local).AddTicks(2080), 15, 7, 299.089675186709320m },
                    { 48, 32, new DateTime(2024, 2, 24, 19, 47, 38, 250, DateTimeKind.Local).AddTicks(3694), 41, 10, 403.676711173577860m },
                    { 49, 2, new DateTime(2023, 8, 8, 1, 38, 40, 907, DateTimeKind.Local).AddTicks(5307), 17, 2, 18.2637471604457630m },
                    { 50, 72, new DateTime(2024, 1, 20, 7, 29, 43, 564, DateTimeKind.Local).AddTicks(6920), 43, 5, 122.850783147313960m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecords_SupplierId",
                table: "SalesRecords",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Suppliers_SupplierId",
                table: "SalesRecords",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Suppliers_SupplierId",
                table: "SalesRecords");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecords_SupplierId",
                table: "SalesRecords");

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "SalesRecords");
        }
    }
}
