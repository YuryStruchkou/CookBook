using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DomainLayer.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Email", "PasswordHash", "Role", "Username" },
                values: new object[] { 1, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", "yfhrhr838319-sdkkie92-sdew2", 2, "user1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Email", "PasswordHash", "Role", "Username" },
                values: new object[] { 2, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", "yfhrhr838319-sdkkie92-sdew2", 1, "user2" });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "UserId", "Avatar", "IsMuted", "UserStatus" },
                values: new object[] { 1, "https://kek.com/kek.jpg", false, 1 });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "UserId", "Avatar", "IsMuted", "UserStatus" },
                values: new object[] { 2, "https://kek.com/kek.jpg", false, 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Content", "CreationDate", "DeleteDate", "Description", "EditDate", "Name", "RecipeStatus", "UserId" },
                values: new object[] { 1, "Blah", new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blah-blah", null, "Something", 1, 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Content", "CreationDate", "DeleteDate", "Description", "EditDate", "Name", "RecipeStatus", "UserId" },
                values: new object[] { 2, "Blah", new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blah-blah", new DateTime(2018, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "SomethingElse", 2, 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Content", "CreationDate", "DeleteDate", "Description", "EditDate", "Name", "RecipeStatus", "UserId" },
                values: new object[] { 3, "Blah", new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blah-blah", new DateTime(2018, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "SomethingElseElse", 1, 2 });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "RecipeId", "UserId", "Value" },
                values: new object[] { 1, 1, 1, 5 });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "RecipeId", "UserId", "Value" },
                values: new object[] { 2, 1, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
