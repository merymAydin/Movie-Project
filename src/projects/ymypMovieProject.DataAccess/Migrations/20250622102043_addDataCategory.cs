using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ymypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4ba0458e-9994-4aab-a014-5190e62a08cf"), new DateTime(2025, 6, 22, 13, 20, 43, 73, DateTimeKind.Local).AddTicks(4539), "", true, false, "korku", null },
                    { new Guid("7c073b6b-af02-4e74-89ea-8f432c029679"), new DateTime(2025, 6, 22, 13, 20, 43, 73, DateTimeKind.Local).AddTicks(4471), "", true, false, "Aksiyon", null },
                    { new Guid("8175828b-3647-4899-bec0-0653c8476785"), new DateTime(2025, 6, 22, 13, 20, 43, 73, DateTimeKind.Local).AddTicks(4535), "", true, false, "belgesel", null },
                    { new Guid("cad667c2-7834-4e30-b6a7-1461dac16d9c"), new DateTime(2025, 6, 22, 13, 20, 43, 73, DateTimeKind.Local).AddTicks(4517), "", true, false, "Komedi", null },
                    { new Guid("e50215e4-2e5f-4ef2-9bd1-6f6b61bd6f6d"), new DateTime(2025, 6, 22, 13, 20, 43, 73, DateTimeKind.Local).AddTicks(4521), "", true, false, "bilim kurgu", null },
                    { new Guid("e876987f-d460-441b-8666-e37de27bc38e"), new DateTime(2025, 6, 22, 13, 20, 43, 73, DateTimeKind.Local).AddTicks(4524), "", true, false, "fantastik", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ba0458e-9994-4aab-a014-5190e62a08cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c073b6b-af02-4e74-89ea-8f432c029679"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8175828b-3647-4899-bec0-0653c8476785"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cad667c2-7834-4e30-b6a7-1461dac16d9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e50215e4-2e5f-4ef2-9bd1-6f6b61bd6f6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e876987f-d460-441b-8666-e37de27bc38e"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
