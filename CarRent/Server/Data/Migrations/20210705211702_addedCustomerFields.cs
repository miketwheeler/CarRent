using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class addedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "5ae2e922-adaa-42ab-b33b-824180056c74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "5df8453a-5ece-47e0-99a1-8cee9c0e1e24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83be2c04-540d-4951-8fa6-4ce69339d9d8", "AQAAAAEAACcQAAAAEK5sPf/Aw6Za4HHfcbxxeL2ZtCkVbeogmxW/f6x5SAlepyt5lvjNcUpTCk8z3kh9dQ==", "0a426916-0a37-4567-b917-d74c54bcda93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ddf118-52a1-4b8a-b2e2-65af033d1a92", "AQAAAAEAACcQAAAAEGRasEx8DaK8ZaRTizI7hd3bSXjWdmpINjRZVkHul78H4QnMoexpC04xt74sGpVhIQ==", "13310aec-4b47-4223-a8c3-6cc3927b5d26" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(644), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(689), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(876), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(884), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(972), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(979), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(983), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 7, 3, 15, 32, 25, 88, DateTimeKind.Local).AddTicks(989) });
        }
    }
}
