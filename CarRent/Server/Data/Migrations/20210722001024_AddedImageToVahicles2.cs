using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class AddedImageToVahicles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "b733c305-c37d-4893-a696-f007a31f1dde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "fae313a2-4fd9-427c-9e94-2aa0984afb73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6804a13b-30f8-45ca-aea7-7db6477a11b3", "AQAAAAEAACcQAAAAEDvJXiQw2VbO8U2cP2jiWaORhWTZdlxdGfAZAGyI9kxxlcG2AbxA2/aTRhfKWJJIoQ==", "7e830c0c-fa28-4b47-8412-e900cb6f9350" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a92bd016-ad10-498a-b15e-3f7d1ac112d1", "AQAAAAEAACcQAAAAEHiSE3Q100QEHDxe0b1UJlWFBz+lZ64Kz6mYatUPcPGF2z/TJGnXBrKkDk2nYCet5g==", "1fad9cf5-fd25-4901-b464-d182542729ad" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8524), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8566), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8778), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8785), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8869), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8875), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8880), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8884), new DateTime(2021, 7, 21, 17, 10, 24, 424, DateTimeKind.Local).AddTicks(8886) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
