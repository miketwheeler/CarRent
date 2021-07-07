using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class addedValidationToCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "856d9722-eee2-4f3c-9def-e3d29793b2e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "b1da05cf-3e69-42dc-84a3-bd3cafea1c98");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f3099ba-d320-490c-8174-2bdf416fb342", "AQAAAAEAACcQAAAAEIIH0RumiP0gvep/9jKrciO98HC6i5lNRBzrm+zC0O0olbImSu95Ehb+S1U3HYbNzA==", "724dc4ff-8831-4b79-b602-39cc3f247611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04da2e47-0c8c-48d8-836c-1d2e2dd47b24", "AQAAAAEAACcQAAAAEFFSjvF+QJEI8OzM2Xum+HV2aQARiM3L8juVSk3CXVKGsqlj7FHnOSFqJsGP03P6ag==", "81eb6fd8-e3af-4ccf-a3d4-6f2263c424db" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4537), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4587), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4859), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4866), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4966), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4972), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4977), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4981), new DateTime(2021, 7, 5, 14, 17, 1, 320, DateTimeKind.Local).AddTicks(4983) });
        }
    }
}
