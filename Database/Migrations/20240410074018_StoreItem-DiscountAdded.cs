using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class StoreItemDiscountAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "StoreItems",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2023, 12, 7, 1, 19, 4, 173, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2023, 5, 20, 7, 10, 6, 830, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2023, 11, 1, 13, 1, 9, 487, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2023, 4, 14, 18, 52, 12, 145, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2023, 9, 27, 0, 43, 14, 802, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2024, 3, 10, 6, 34, 17, 459, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2023, 8, 22, 12, 25, 20, 116, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "SaleDate",
                value: new DateTime(2024, 2, 3, 18, 16, 22, 773, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "SaleDate",
                value: new DateTime(2023, 7, 18, 0, 7, 25, 430, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "SaleDate",
                value: new DateTime(2023, 12, 30, 5, 58, 28, 88, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "SaleDate",
                value: new DateTime(2023, 6, 12, 11, 49, 30, 745, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "SaleDate",
                value: new DateTime(2023, 11, 24, 17, 40, 33, 402, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "SaleDate",
                value: new DateTime(2023, 5, 7, 23, 31, 36, 59, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "SaleDate",
                value: new DateTime(2023, 10, 20, 5, 22, 38, 716, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "SaleDate",
                value: new DateTime(2024, 4, 2, 11, 13, 41, 373, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "SaleDate",
                value: new DateTime(2023, 9, 14, 17, 4, 44, 30, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "SaleDate",
                value: new DateTime(2024, 2, 26, 22, 55, 46, 688, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "SaleDate",
                value: new DateTime(2023, 8, 10, 4, 46, 49, 345, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "SaleDate",
                value: new DateTime(2024, 1, 22, 10, 37, 52, 2, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "SaleDate",
                value: new DateTime(2023, 7, 5, 16, 28, 54, 659, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "SaleDate",
                value: new DateTime(2023, 12, 17, 22, 19, 57, 316, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "SaleDate",
                value: new DateTime(2023, 5, 31, 4, 10, 59, 973, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "SaleDate",
                value: new DateTime(2023, 11, 12, 10, 2, 2, 631, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "SaleDate",
                value: new DateTime(2023, 4, 25, 15, 53, 5, 288, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "SaleDate",
                value: new DateTime(2023, 10, 7, 21, 44, 7, 945, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "SaleDate",
                value: new DateTime(2024, 3, 21, 3, 35, 10, 602, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "SaleDate",
                value: new DateTime(2023, 9, 2, 9, 26, 13, 259, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "SaleDate",
                value: new DateTime(2024, 2, 14, 15, 17, 15, 916, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "SaleDate",
                value: new DateTime(2023, 7, 28, 21, 8, 18, 574, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "SaleDate",
                value: new DateTime(2024, 1, 10, 2, 59, 21, 231, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "SaleDate",
                value: new DateTime(2023, 6, 23, 8, 50, 23, 888, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "SaleDate",
                value: new DateTime(2023, 12, 5, 14, 41, 26, 545, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "SaleDate",
                value: new DateTime(2023, 5, 18, 20, 32, 29, 202, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "SaleDate",
                value: new DateTime(2023, 10, 31, 2, 23, 31, 859, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "SaleDate",
                value: new DateTime(2023, 4, 13, 8, 14, 34, 517, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "SaleDate",
                value: new DateTime(2023, 9, 25, 14, 5, 37, 174, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "SaleDate",
                value: new DateTime(2024, 3, 8, 19, 56, 39, 831, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "SaleDate",
                value: new DateTime(2023, 8, 21, 1, 47, 42, 488, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "SaleDate",
                value: new DateTime(2024, 2, 2, 7, 38, 45, 145, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "SaleDate",
                value: new DateTime(2023, 7, 16, 13, 29, 47, 802, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "SaleDate",
                value: new DateTime(2023, 12, 28, 19, 20, 50, 460, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "SaleDate",
                value: new DateTime(2023, 6, 11, 1, 11, 53, 117, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "SaleDate",
                value: new DateTime(2023, 11, 23, 7, 2, 55, 774, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "SaleDate",
                value: new DateTime(2023, 5, 6, 12, 53, 58, 431, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "SaleDate",
                value: new DateTime(2023, 10, 18, 18, 45, 1, 88, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "SaleDate",
                value: new DateTime(2024, 4, 1, 0, 36, 3, 745, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "SaleDate",
                value: new DateTime(2023, 9, 13, 6, 27, 6, 403, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "SaleDate",
                value: new DateTime(2024, 2, 25, 12, 18, 9, 60, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "SaleDate",
                value: new DateTime(2023, 8, 8, 18, 9, 11, 717, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "SaleDate",
                value: new DateTime(2024, 1, 21, 0, 0, 14, 374, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 20);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Discount",
                value: 3);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Discount",
                value: 17);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Discount",
                value: 14);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "Discount",
                value: 28);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "Discount",
                value: 11);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Discount",
                value: 25);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "Discount",
                value: 8);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "Discount",
                value: 22);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "Discount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "Discount",
                value: 19);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "Discount",
                value: 2);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "Discount",
                value: 16);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "Discount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "Discount",
                value: 13);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "Discount",
                value: 27);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "Discount",
                value: 10);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "Discount",
                value: 24);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "Discount",
                value: 7);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "Discount",
                value: 21);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "Discount",
                value: 4);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "Discount",
                value: 18);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "Discount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "Discount",
                value: 15);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "Discount",
                value: 29);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "Discount",
                value: 12);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "Discount",
                value: 26);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "Discount",
                value: 9);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "Discount",
                value: 23);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "Discount",
                value: 6);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "Discount",
                value: 20);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "Discount",
                value: 3);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "Discount",
                value: 17);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "Discount",
                value: 14);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "Discount",
                value: 28);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "Discount",
                value: 11);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "Discount",
                value: 25);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "Discount",
                value: 8);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "Discount",
                value: 22);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "Discount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "Discount",
                value: 19);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "Discount",
                value: 2);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "Discount",
                value: 16);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "Discount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "Discount",
                value: 13);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "Discount",
                value: 27);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "Discount",
                value: 10);

            migrationBuilder.UpdateData(
                table: "StoreItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "Discount",
                value: 24);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "StoreItems");

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2023, 12, 6, 8, 48, 33, 363, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2023, 5, 19, 14, 39, 36, 20, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2023, 10, 31, 20, 30, 38, 678, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2023, 4, 14, 2, 21, 41, 335, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2023, 9, 26, 8, 12, 43, 992, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2024, 3, 9, 14, 3, 46, 649, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2023, 8, 21, 19, 54, 49, 306, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "SaleDate",
                value: new DateTime(2024, 2, 3, 1, 45, 51, 963, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "SaleDate",
                value: new DateTime(2023, 7, 17, 7, 36, 54, 621, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "SaleDate",
                value: new DateTime(2023, 12, 29, 13, 27, 57, 278, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "SaleDate",
                value: new DateTime(2023, 6, 11, 19, 18, 59, 935, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "SaleDate",
                value: new DateTime(2023, 11, 24, 1, 10, 2, 592, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "SaleDate",
                value: new DateTime(2023, 5, 7, 7, 1, 5, 249, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "SaleDate",
                value: new DateTime(2023, 10, 19, 12, 52, 7, 906, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "SaleDate",
                value: new DateTime(2024, 4, 1, 18, 43, 10, 564, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "SaleDate",
                value: new DateTime(2023, 9, 14, 0, 34, 13, 221, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "SaleDate",
                value: new DateTime(2024, 2, 26, 6, 25, 15, 878, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "SaleDate",
                value: new DateTime(2023, 8, 9, 12, 16, 18, 535, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "SaleDate",
                value: new DateTime(2024, 1, 21, 18, 7, 21, 192, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "SaleDate",
                value: new DateTime(2023, 7, 4, 23, 58, 23, 849, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "SaleDate",
                value: new DateTime(2023, 12, 17, 5, 49, 26, 507, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "SaleDate",
                value: new DateTime(2023, 5, 30, 11, 40, 29, 164, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "SaleDate",
                value: new DateTime(2023, 11, 11, 17, 31, 31, 821, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "SaleDate",
                value: new DateTime(2023, 4, 24, 23, 22, 34, 478, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "SaleDate",
                value: new DateTime(2023, 10, 7, 5, 13, 37, 135, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "SaleDate",
                value: new DateTime(2024, 3, 20, 11, 4, 39, 792, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "SaleDate",
                value: new DateTime(2023, 9, 1, 16, 55, 42, 449, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "SaleDate",
                value: new DateTime(2024, 2, 13, 22, 46, 45, 107, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "SaleDate",
                value: new DateTime(2023, 7, 28, 4, 37, 47, 764, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "SaleDate",
                value: new DateTime(2024, 1, 9, 10, 28, 50, 421, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "SaleDate",
                value: new DateTime(2023, 6, 22, 16, 19, 53, 78, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "SaleDate",
                value: new DateTime(2023, 12, 4, 22, 10, 55, 735, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "SaleDate",
                value: new DateTime(2023, 5, 18, 4, 1, 58, 392, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "SaleDate",
                value: new DateTime(2023, 10, 30, 9, 53, 1, 50, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "SaleDate",
                value: new DateTime(2023, 4, 12, 15, 44, 3, 707, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "SaleDate",
                value: new DateTime(2023, 9, 24, 21, 35, 6, 364, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "SaleDate",
                value: new DateTime(2024, 3, 8, 3, 26, 9, 21, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "SaleDate",
                value: new DateTime(2023, 8, 20, 9, 17, 11, 678, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "SaleDate",
                value: new DateTime(2024, 2, 1, 15, 8, 14, 335, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "SaleDate",
                value: new DateTime(2023, 7, 15, 20, 59, 16, 993, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "SaleDate",
                value: new DateTime(2023, 12, 28, 2, 50, 19, 650, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "SaleDate",
                value: new DateTime(2023, 6, 10, 8, 41, 22, 307, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "SaleDate",
                value: new DateTime(2023, 11, 22, 14, 32, 24, 964, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "SaleDate",
                value: new DateTime(2023, 5, 5, 20, 23, 27, 621, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "SaleDate",
                value: new DateTime(2023, 10, 18, 2, 14, 30, 278, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "SaleDate",
                value: new DateTime(2024, 3, 31, 8, 5, 32, 936, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "SaleDate",
                value: new DateTime(2023, 9, 12, 13, 56, 35, 593, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "SaleDate",
                value: new DateTime(2024, 2, 24, 19, 47, 38, 250, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "SaleDate",
                value: new DateTime(2023, 8, 8, 1, 38, 40, 907, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "SaleDate",
                value: new DateTime(2024, 1, 20, 7, 29, 43, 564, DateTimeKind.Local).AddTicks(6920));
        }
    }
}
