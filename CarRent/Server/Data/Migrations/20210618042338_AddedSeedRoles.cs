using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class AddedSeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "893025bd-361a-440f-bced-a71212c43a21", "b3648334-d889-4acf-9b43-37e8d59df2a6", "User", "USER" },
                    { "b0454334-3109-418b-966d-63c901b9865b", "e6dbe6f7-c2ee-4473-85cb-fa80c5fc4506", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(2755), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(2792), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3038), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3046), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3141), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3148), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3153), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3157), new DateTime(2021, 6, 17, 21, 23, 37, 759, DateTimeKind.Local).AddTicks(3159) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4828), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4867), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5068), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5075), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5163), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5170), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5175), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5179), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5181) });
        }
    }
}
