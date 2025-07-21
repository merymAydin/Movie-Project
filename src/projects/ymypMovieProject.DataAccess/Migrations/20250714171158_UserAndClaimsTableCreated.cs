using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ymypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserAndClaimsTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0e286779-09e2-4be6-a81d-eba0145613c1"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5761), "", true, false, "korku", null },
                    { new Guid("27a04002-5331-43c6-b946-27b936f99614"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5759), "", true, false, "belgesel", null },
                    { new Guid("5a81bc2d-03c4-48c4-9203-1fc6ac80ea34"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5757), "", true, false, "fantastik", null },
                    { new Guid("605822ef-9ecb-457b-9f13-7b58847e04f6"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5756), "", true, false, "bilim kurgu", null },
                    { new Guid("abb8a54d-9c79-4214-852f-e0d92a4e69d5"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5744), "", true, false, "Komedi", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "IsActive", "IsDeleted", "LastName", "UpdateAt", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("007cceab-b277-486d-a29d-eb37a2822328"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5897), "American filmmaker, actor, and screenwriter.", "Quentin", true, false, "Tarantino", null, null },
                    { new Guid("552100c9-13c1-4f95-84d6-0b3d8e1c97b9"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5893), "American film director, producer, and screenwriter.", "Steven", true, false, "Spielberg", null, null },
                    { new Guid("7d72a924-f7b1-48b3-afde-b004f60d7de0"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5927), "Canadian filmmaker and environmental advocate.", "James", true, false, "Cameron", null, null },
                    { new Guid("d3b1a5df-d649-43e9-8518-116e16d81206"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5895), "American film director, producer, screenwriter, and actor.", "Martin", true, false, "Scorsese", null, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("7f202cbb-dd18-472a-985d-56d7e42b986f"), new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5960), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ca0a6e77-5d9a-43fc-86e4-29b32c69eb91"), new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5945), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("d4b4de18-5a81-4f1b-a93a-f5770701246f"), new Guid("bdafa56b-368b-4633-adb2-963aa41d0809"), new DateTime(2025, 7, 14, 20, 11, 58, 402, DateTimeKind.Local).AddTicks(5955), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("6e00e3aa-2aa2-4bad-ae37-25c16d34acc1"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e286779-09e2-4be6-a81d-eba0145613c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27a04002-5331-43c6-b946-27b936f99614"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a81bc2d-03c4-48c4-9203-1fc6ac80ea34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("605822ef-9ecb-457b-9f13-7b58847e04f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abb8a54d-9c79-4214-852f-e0d92a4e69d5"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("007cceab-b277-486d-a29d-eb37a2822328"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("552100c9-13c1-4f95-84d6-0b3d8e1c97b9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("7d72a924-f7b1-48b3-afde-b004f60d7de0"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d3b1a5df-d649-43e9-8518-116e16d81206"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7f202cbb-dd18-472a-985d-56d7e42b986f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ca0a6e77-5d9a-43fc-86e4-29b32c69eb91"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d4b4de18-5a81-4f1b-a93a-f5770701246f"));

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
    }
}
