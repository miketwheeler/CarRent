using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class updatedtoBookingstablecol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOur",
                table: "Bookings",
                newName: "DateOut");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOut",
                table: "Bookings",
                newName: "DateOur");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c69f883-6a25-4cbe-9866-98e4ffaa91f8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16966279-d7c4-4d27-922d-1287b8a12b9c", "AQAAAAEAACcQAAAAEAlU1I4xog0CalVDMI3Y083kjm83qeIeoWTkT3V3T1o10wIvYVwnivE/19LWfWgd5g==", "55cce51e-f876-432c-9e27-e8973e948355" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d8c74-42ae-42b9-a3cb-d62aa74d42dc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d487c11-7a5d-490c-938b-aa6f9f7280b8", "AQAAAAEAACcQAAAAEGA3ZBhP5pSlDRVYF49mYOQlsqxqHfinrCp3tXirIe4nJCJ3bIGkSAgPXnfAUDilmQ==", "2138f2f9-c30c-4f75-b954-46b9818fe2df" });

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
        }
    }
}
