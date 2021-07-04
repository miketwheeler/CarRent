using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class addedvalidationtobookingdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "c1a3a75a-624c-434b-8610-4f2230e14746");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "800757fc-8d3b-4257-8f71-2c2caec36cc5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac270c47-1105-4516-bf38-2dbbbd1abb32", "AQAAAAEAACcQAAAAECOCR6nwgyk4z3AIhqeUOij/yjtHbzkEMgDjsXkeoaTtvcoZV7oL2SVDfaLq0oAWCg==", "016b9104-f705-495d-a5b5-43720cb78577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1aecd6-7b29-4637-833a-4a420b0ff671", "AQAAAAEAACcQAAAAECblwrOMufZi9QOO9L9kXvcFw3wBz4U81wrekXVtReMoPxJbkIPwbksO0AoAQ2vVwg==", "01518578-e390-4e60-bb71-d6861865fd78" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5366), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5410), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5604), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5610), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5694), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5700), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5705), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5709), new DateTime(2021, 7, 1, 21, 41, 0, 413, DateTimeKind.Local).AddTicks(5711) });
        }
    }
}
