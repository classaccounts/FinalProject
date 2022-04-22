using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectWebServerApp.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyId",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "In my free time I regularly play video games by myself or with my friends. I started playing video games when I was young, with my first console being the PlayStation 1. Over the years I've gotten more into playing video games especially ones that I can play online with my friends. There's not really a genre of game I typically stray away from but for some reason my favorite games are simulator games.", "Video Games" });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyId",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { " When I want to take a break from sitting around playing games, I like to go biking. Every once in a while, I'll take a bike trip with my friends to East Fork or some park with a bike trail.If no one else is available, I like to just take my bike out and ride around my neighborhood while I listen to some music or a podcast.", "Biking" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "This discord bot I created was made to allow people in a server to select each other randomly for secret Santa. This way who a person received would not be known to a third party allowing for complete anonymity up until the secret Santa gathering.This bot holds a list of users in an array then randomly selects a person in the array excluding the person who called the command.", "Secret Santa Bot" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "I recently picked up learning 3d modeling in blender and as a project a made a 3d model of a chess set and board. Each piece was modeled separately then placed inside a new file containing the board where the chess scene presented in the picture above was created and rendered out into a PNG. This was done over a period of a few weeks in my spare time.", "Blender Chess Set" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyId",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "ALEX", "ALEX" });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyId",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "ALEX", "ALEX" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "ALEX", "ALEX" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "ALEX", "ALEX" });
        }
    }
}
