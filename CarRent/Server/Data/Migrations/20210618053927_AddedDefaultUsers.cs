using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "7a79a439-a8c3-4f61-9341-78a47529e1f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "57dd3f38-63f0-43c1-a92c-09d13411e86f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "500d8c74-42ae-42b9-a3cb-d62aa74d42dc", 0, "5d487c11-7a5d-490c-938b-aa6f9f7280b8", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGA3ZBhP5pSlDRVYF49mYOQlsqxqHfinrCp3tXirIe4nJCJ3bIGkSAgPXnfAUDilmQ==", null, false, "2138f2f9-c30c-4f75-b954-46b9818fe2df", false, "admin@localhost.com" },
                    { "0c69f883-6a25-4cbe-9866-98e4ffaa91f8", 0, "16966279-d7c4-4d27-922d-1287b8a12b9c", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAlU1I4xog0CalVDMI3Y083kjm83qeIeoWTkT3V3T1o10wIvYVwnivE/19LWfWgd5g==", null, false, "55cce51e-f876-432c-9e27-e8973e948355", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9601), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9641), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9832), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9840), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9925), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9932), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9936), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9941), new DateTime(2021, 6, 17, 22, 39, 26, 788, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "893025bd-361a-440f-bced-a71212c43a21", "500d8c74-42ae-42b9-a3cb-d62aa74d42dc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b0454334-3109-418b-966d-63c901b9865b", "0c69f883-6a25-4cbe-9866-98e4ffaa91f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0454334-3109-418b-966d-63c901b9865b", "0c69f883-6a25-4cbe-9866-98e4ffaa91f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "893025bd-361a-440f-bced-a71212c43a21", "500d8c74-42ae-42b9-a3cb-d62aa74d42dc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "893025bd-361a-440f-bced-a71212c43a21",
                column: "ConcurrencyStamp",
                value: "b3648334-d889-4acf-9b43-37e8d59df2a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0454334-3109-418b-966d-63c901b9865b",
                column: "ConcurrencyStamp",
                value: "e6dbe6f7-c2ee-4473-85cb-fa80c5fc4506");

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
    }
}
