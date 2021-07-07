using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class addedValidationToCustomersChangedBackToEdit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "0c20510f-5576-435e-898e-701861cf1186");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "7c7b54c4-c167-4280-b887-41526135fb20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adb23b72-918c-4aa4-ba90-7c06df0fd5db", "AQAAAAEAACcQAAAAEOAd8gvZ4rpI5601zNaeuyVWOLKiFo+9sfBaYLxhawXEvq9f5bK3otXGN/0ZbDdN5A==", "8880b2e0-492a-4d4d-925c-cd2f07f268f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b393d54-5569-4fc6-b1f8-b84b5c23dbc5", "AQAAAAEAACcQAAAAEDl49pltev251lbqfZ7U1fx41l6Cy+2fGRlKZlfrGjzcyVB0wP/4GOWkN80O1RCnJw==", "94718666-96aa-4c98-a39b-d3c8a7691c6c" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1340), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1380), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1720), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1738), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2010), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2055), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2063), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2068), new DateTime(2021, 7, 5, 14, 51, 26, 376, DateTimeKind.Local).AddTicks(2070) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "8421b462-3fda-4604-9dff-9d087061eaa9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "9b45db87-6dae-4ae5-abbc-847cb818fcda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cf9eb1d-be2b-4202-9da6-b3436eed6855", "AQAAAAEAACcQAAAAEAmXVCL/FtAzuBvp6Zvs6cyGMP1VmPXExPfSxGCsA7PXmt5lVNlN9nOfPvl8Ie2h0g==", "e5c591fe-7134-47f4-bc31-cf14ee3952b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76cb7e55-c6c2-4119-90e7-cc3a4e2aa469", "AQAAAAEAACcQAAAAEO5t4w2g340yHRSmpuS8Lvz89nKaOT48R+Vdb+IvtQgWCvz0SlvmmyHOriEBHujlSw==", "e4cc2554-23d8-4fe9-9237-4ccbd3d9b7c0" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(2622), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(2690), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3164), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3184), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3461), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3473), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3486), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3502), new DateTime(2021, 7, 5, 14, 39, 48, 583, DateTimeKind.Local).AddTicks(3509) });
        }
    }
}
