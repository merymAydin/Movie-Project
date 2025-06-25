using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ymypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DirectorModelBuilderCreateAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1164bc81-b465-4414-8cb7-a24ee8a69064"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f879cb0-5711-446d-949f-e2b573e110dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35f43169-f3f9-4be0-a403-f87e854edb5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d1e9642-6e68-48a7-8cea-fbcfd373ead1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("640f4792-6e0c-4236-afb9-9b4961a94faf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d69b00e0-b3b6-4038-a814-f576211f4489"));

            migrationBuilder.AlterColumn<string>(
                name: "imageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("3668ba3a-45f7-4146-9682-217a248cf1b4"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1844), "", true, false, "fantastik", null },
                    { new Guid("6b5a86c8-5196-49de-b25f-8d0c09cabc33"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1779), "", true, false, "Komedi", null },
                    { new Guid("7f8a09ab-6241-4004-8399-a58e1c129250"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1781), "", true, false, "bilim kurgu", null },
                    { new Guid("98a81c46-193a-408a-bb01-8850ca160b22"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1846), "", true, false, "belgesel", null },
                    { new Guid("b89f875a-8ce5-4561-a4fc-7d63a702b353"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1848), "", true, false, "korku", null },
                    { new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1759), "", true, false, "Aksiyon", null }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "IsActive", "IsDeleted", "LastName", "UpdateAt", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("2251cbe9-9e35-4867-b761-d346ad51607a"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1965), "American film director, producer, screenwriter, and actor.", "Martin", true, false, "Scorsese", null, null },
                    { new Guid("68373c2f-4068-4207-ad0c-84c220a8720d"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1967), "American filmmaker, actor, and screenwriter.", "Quentin", true, false, "Tarantino", null, null },
                    { new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1951), "British-American film director, producer, and screenwriter.", "Christopher", true, false, "Nolan", null, null },
                    { new Guid("73e202a7-9d73-47ab-97af-1b285937f7ab"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1963), "American film director, producer, and screenwriter.", "Steven", true, false, "Spielberg", null, null },
                    { new Guid("e4650828-229e-4f0c-9f1e-aa63c32c4392"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1969), "Canadian filmmaker and environmental advocate.", "James", true, false, "Cameron", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3668ba3a-45f7-4146-9682-217a248cf1b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b5a86c8-5196-49de-b25f-8d0c09cabc33"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f8a09ab-6241-4004-8399-a58e1c129250"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98a81c46-193a-408a-bb01-8850ca160b22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b89f875a-8ce5-4561-a4fc-7d63a702b353"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2251cbe9-9e35-4867-b761-d346ad51607a"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("68373c2f-4068-4207-ad0c-84c220a8720d"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("73e202a7-9d73-47ab-97af-1b285937f7ab"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e4650828-229e-4f0c-9f1e-aa63c32c4392"));

            migrationBuilder.AlterColumn<string>(
                name: "imageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1164bc81-b465-4414-8cb7-a24ee8a69064"), new DateTime(2025, 6, 23, 17, 51, 21, 824, DateTimeKind.Local).AddTicks(2440), "", true, false, "bilim kurgu", null },
                    { new Guid("1f879cb0-5711-446d-949f-e2b573e110dc"), new DateTime(2025, 6, 23, 17, 51, 21, 824, DateTimeKind.Local).AddTicks(2380), "", true, false, "Aksiyon", null },
                    { new Guid("35f43169-f3f9-4be0-a403-f87e854edb5d"), new DateTime(2025, 6, 23, 17, 51, 21, 824, DateTimeKind.Local).AddTicks(2418), "", true, false, "Komedi", null },
                    { new Guid("3d1e9642-6e68-48a7-8cea-fbcfd373ead1"), new DateTime(2025, 6, 23, 17, 51, 21, 824, DateTimeKind.Local).AddTicks(2453), "", true, false, "korku", null },
                    { new Guid("640f4792-6e0c-4236-afb9-9b4961a94faf"), new DateTime(2025, 6, 23, 17, 51, 21, 824, DateTimeKind.Local).AddTicks(2445), "", true, false, "fantastik", null },
                    { new Guid("d69b00e0-b3b6-4038-a814-f576211f4489"), new DateTime(2025, 6, 23, 17, 51, 21, 824, DateTimeKind.Local).AddTicks(2449), "", true, false, "belgesel", null }
                });
        }
    }
}
