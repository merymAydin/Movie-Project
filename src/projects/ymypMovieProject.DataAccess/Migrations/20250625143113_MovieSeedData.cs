using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ymypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MovieSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("73e202a7-9d73-47ab-97af-1b285937f7ab"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e4650828-229e-4f0c-9f1e-aa63c32c4392"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("053bb811-f7ad-4417-b6a2-9792827b3e96"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2253), "", true, false, "korku", null },
                    { new Guid("1857f747-5208-41d3-914d-b49b6a4690ed"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2249), "", true, false, "fantastik", null },
                    { new Guid("9a63d805-2879-49ea-98a8-df6af8324261"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2237), "", true, false, "Komedi", null },
                    { new Guid("e48abf7a-b389-4e59-aa9e-e33d74a4d050"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2251), "", true, false, "belgesel", null },
                    { new Guid("f376ba93-3bf8-4d23-aa4b-444b388ba339"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2247), "", true, false, "bilim kurgu", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "IsActive", "IsDeleted", "LastName", "UpdateAt", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("0f7fb8c5-4254-40cc-a629-46d090edb463"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2409), "American film director, producer, screenwriter, and actor.", "Martin", true, false, "Scorsese", null, null },
                    { new Guid("7a591767-6572-4322-94de-01b5e157b361"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2411), "American filmmaker, actor, and screenwriter.", "Quentin", true, false, "Tarantino", null, null },
                    { new Guid("91ab1822-9159-4f30-afa6-48e1ea4e358e"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2407), "American film director, producer, and screenwriter.", "Steven", true, false, "Spielberg", null, null },
                    { new Guid("e2cba1fe-6d58-4200-9c4f-d58cdcb8c5fa"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2414), "Canadian filmmaker and environmental advocate.", "James", true, false, "Cameron", null, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1198036a-1a5d-4ef0-8424-3677a442b7c9"), new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2444), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a7387d8f-b156-4720-a7c6-e74d9379dfcd"), new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2441), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("aa54c4ba-dc3d-4b86-bddb-816596f5ab57"), new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 6, 25, 17, 31, 13, 580, DateTimeKind.Local).AddTicks(2431), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("053bb811-f7ad-4417-b6a2-9792827b3e96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1857f747-5208-41d3-914d-b49b6a4690ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a63d805-2879-49ea-98a8-df6af8324261"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e48abf7a-b389-4e59-aa9e-e33d74a4d050"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f376ba93-3bf8-4d23-aa4b-444b388ba339"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("0f7fb8c5-4254-40cc-a629-46d090edb463"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("7a591767-6572-4322-94de-01b5e157b361"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("91ab1822-9159-4f30-afa6-48e1ea4e358e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("e2cba1fe-6d58-4200-9c4f-d58cdcb8c5fa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1198036a-1a5d-4ef0-8424-3677a442b7c9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a7387d8f-b156-4720-a7c6-e74d9379dfcd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aa54c4ba-dc3d-4b86-bddb-816596f5ab57"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("3668ba3a-45f7-4146-9682-217a248cf1b4"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1844), "", true, false, "fantastik", null },
                    { new Guid("6b5a86c8-5196-49de-b25f-8d0c09cabc33"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1779), "", true, false, "Komedi", null },
                    { new Guid("7f8a09ab-6241-4004-8399-a58e1c129250"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1781), "", true, false, "bilim kurgu", null },
                    { new Guid("98a81c46-193a-408a-bb01-8850ca160b22"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1846), "", true, false, "belgesel", null },
                    { new Guid("b89f875a-8ce5-4561-a4fc-7d63a702b353"), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1848), "", true, false, "korku", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "IsActive", "IsDeleted", "LastName", "UpdateAt", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("2251cbe9-9e35-4867-b761-d346ad51607a"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1965), "American film director, producer, screenwriter, and actor.", "Martin", true, false, "Scorsese", null, null },
                    { new Guid("68373c2f-4068-4207-ad0c-84c220a8720d"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1967), "American filmmaker, actor, and screenwriter.", "Quentin", true, false, "Tarantino", null, null },
                    { new Guid("73e202a7-9d73-47ab-97af-1b285937f7ab"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1963), "American film director, producer, and screenwriter.", "Steven", true, false, "Spielberg", null, null },
                    { new Guid("e4650828-229e-4f0c-9f1e-aa63c32c4392"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 10, 47, 48, 12, DateTimeKind.Local).AddTicks(1969), "Canadian filmmaker and environmental advocate.", "James", true, false, "Cameron", null, null }
                });
        }
    }
}
