using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4828), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4863), "Black", "System" },
                    { 2, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4867), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(4869), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5068), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5072), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5075), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5077), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5163), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5166), "Supra", "System" },
                    { 2, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5170), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5172), "RAV-4", "System" },
                    { 3, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5175), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5177), "i435", "System" },
                    { 4, "System", new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5179), new DateTime(2021, 6, 17, 21, 0, 24, 937, DateTimeKind.Local).AddTicks(5181), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
