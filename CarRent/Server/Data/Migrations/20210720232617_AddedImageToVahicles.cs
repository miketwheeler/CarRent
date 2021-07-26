using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class AddedImageToVahicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "b9cd6784-adbc-4b2a-8b74-06df09d73644");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "f56d4cfc-0ed4-4301-81b2-e9b4d734476f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5755f91-8493-4daa-88b8-eb8d1bae1198", "AQAAAAEAACcQAAAAEEXbuOb1STi0MBiyv2R48D33fZxGDemLdepPxQFfbhl9iq7aIjKZyiH+h+EsjV9uGA==", "5085e5e4-cf76-42dc-ae90-188e0ae91d09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cc297e9-0519-428c-8bd0-36aebd96617b", "AQAAAAEAACcQAAAAEGp4fDNRDDKckI3YMgIvNXoxIUV1cEHPEbzbmT+tpVd8Km0GRrQC+MmvFf2mehQSXA==", "865393f3-1a3d-44df-b104-705eaa77988e" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(530), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(576), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(916), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(930), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1255), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1270), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1277), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1284), new DateTime(2021, 7, 20, 16, 26, 16, 287, DateTimeKind.Local).AddTicks(1287) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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
    }
}
