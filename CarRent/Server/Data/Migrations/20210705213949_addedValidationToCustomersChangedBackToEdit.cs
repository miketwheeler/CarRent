using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class addedValidationToCustomersChangedBackToEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "7adbe84c-6dca-4595-a586-b22abbacf1cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "dc5a3d27-64cb-4d9c-b646-b2f9bb102958");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2232ee71-86db-4b8f-ad20-7b89fadd5d65", "AQAAAAEAACcQAAAAEOd607jHT5ETlZThXa2kHKKyl7v9nvcMGJstWuOeL938aCoDPpXkXQV2xPpCYQq86w==", "e497d135-4be1-4118-b1fe-04e15014903a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ff6b19-c93e-4062-b1c1-c57162db7722", "AQAAAAEAACcQAAAAEHzJUhQbw7nHc+w0x6TRTps88J4mtYoXxLgKKxMYjTuZDIsOZGW3oFd5z4T06L40tw==", "8597664d-e096-4880-acde-9c7287d3114d" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4169), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4233), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4672), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4694), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4923), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4944), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4963), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4981), new DateTime(2021, 7, 5, 14, 25, 52, 968, DateTimeKind.Local).AddTicks(4990) });
        }
    }
}
