using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class AppUserModelAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2023, 12, 7, 3, 42, 8, 92, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2023, 5, 20, 9, 33, 10, 749, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2023, 11, 1, 15, 24, 13, 406, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2023, 4, 14, 21, 15, 16, 63, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2023, 9, 27, 3, 6, 18, 720, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2024, 3, 10, 8, 57, 21, 378, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2023, 8, 22, 14, 48, 24, 35, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "SaleDate",
                value: new DateTime(2024, 2, 3, 20, 39, 26, 692, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "SaleDate",
                value: new DateTime(2023, 7, 18, 2, 30, 29, 349, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "SaleDate",
                value: new DateTime(2023, 12, 30, 8, 21, 32, 6, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "SaleDate",
                value: new DateTime(2023, 6, 12, 14, 12, 34, 663, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "SaleDate",
                value: new DateTime(2023, 11, 24, 20, 3, 37, 321, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "SaleDate",
                value: new DateTime(2023, 5, 8, 1, 54, 39, 978, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "SaleDate",
                value: new DateTime(2023, 10, 20, 7, 45, 42, 635, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "SaleDate",
                value: new DateTime(2024, 4, 2, 13, 36, 45, 292, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 16,
                column: "SaleDate",
                value: new DateTime(2023, 9, 14, 19, 27, 47, 949, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 17,
                column: "SaleDate",
                value: new DateTime(2024, 2, 27, 1, 18, 50, 606, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 18,
                column: "SaleDate",
                value: new DateTime(2023, 8, 10, 7, 9, 53, 264, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 19,
                column: "SaleDate",
                value: new DateTime(2024, 1, 22, 13, 0, 55, 921, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 20,
                column: "SaleDate",
                value: new DateTime(2023, 7, 5, 18, 51, 58, 578, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 21,
                column: "SaleDate",
                value: new DateTime(2023, 12, 18, 0, 43, 1, 235, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 22,
                column: "SaleDate",
                value: new DateTime(2023, 5, 31, 6, 34, 3, 892, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 23,
                column: "SaleDate",
                value: new DateTime(2023, 11, 12, 12, 25, 6, 549, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 24,
                column: "SaleDate",
                value: new DateTime(2023, 4, 25, 18, 16, 9, 206, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 25,
                column: "SaleDate",
                value: new DateTime(2023, 10, 8, 0, 7, 11, 864, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 26,
                column: "SaleDate",
                value: new DateTime(2024, 3, 21, 5, 58, 14, 521, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 27,
                column: "SaleDate",
                value: new DateTime(2023, 9, 2, 11, 49, 17, 178, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 28,
                column: "SaleDate",
                value: new DateTime(2024, 2, 14, 17, 40, 19, 835, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 29,
                column: "SaleDate",
                value: new DateTime(2023, 7, 28, 23, 31, 22, 492, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 30,
                column: "SaleDate",
                value: new DateTime(2024, 1, 10, 5, 22, 25, 149, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 31,
                column: "SaleDate",
                value: new DateTime(2023, 6, 23, 11, 13, 27, 807, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 32,
                column: "SaleDate",
                value: new DateTime(2023, 12, 5, 17, 4, 30, 464, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 33,
                column: "SaleDate",
                value: new DateTime(2023, 5, 18, 22, 55, 33, 121, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 34,
                column: "SaleDate",
                value: new DateTime(2023, 10, 31, 4, 46, 35, 778, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 35,
                column: "SaleDate",
                value: new DateTime(2023, 4, 13, 10, 37, 38, 435, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 36,
                column: "SaleDate",
                value: new DateTime(2023, 9, 25, 16, 28, 41, 92, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 37,
                column: "SaleDate",
                value: new DateTime(2024, 3, 8, 22, 19, 43, 750, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 38,
                column: "SaleDate",
                value: new DateTime(2023, 8, 21, 4, 10, 46, 407, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 39,
                column: "SaleDate",
                value: new DateTime(2024, 2, 2, 10, 1, 49, 64, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 40,
                column: "SaleDate",
                value: new DateTime(2023, 7, 16, 15, 52, 51, 721, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 41,
                column: "SaleDate",
                value: new DateTime(2023, 12, 28, 21, 43, 54, 378, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 42,
                column: "SaleDate",
                value: new DateTime(2023, 6, 11, 3, 34, 57, 35, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 43,
                column: "SaleDate",
                value: new DateTime(2023, 11, 23, 9, 25, 59, 693, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 44,
                column: "SaleDate",
                value: new DateTime(2023, 5, 6, 15, 17, 2, 350, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 45,
                column: "SaleDate",
                value: new DateTime(2023, 10, 18, 21, 8, 5, 7, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 46,
                column: "SaleDate",
                value: new DateTime(2024, 4, 1, 2, 59, 7, 664, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 47,
                column: "SaleDate",
                value: new DateTime(2023, 9, 13, 8, 50, 10, 321, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 48,
                column: "SaleDate",
                value: new DateTime(2024, 2, 25, 14, 41, 12, 978, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 49,
                column: "SaleDate",
                value: new DateTime(2023, 8, 8, 20, 32, 15, 636, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "SalesRecords",
                keyColumn: "Id",
                keyValue: 50,
                column: "SaleDate",
                value: new DateTime(2024, 1, 21, 2, 23, 18, 293, DateTimeKind.Local).AddTicks(1936));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
        }
    }
}
