using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectWebServerApp.Migrations
{
    public partial class aboutdbmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.HobbyId);
                    table.ForeignKey(
                        name: "FK_Hobby_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Project_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Name" },
                values: new object[] { 1, "Jack" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Name" },
                values: new object[] { 2, "Alex" });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyId", "Description", "StudentId", "Title" },
                values: new object[,]
                {
                    { 11, "JACK", 1, "JACK" },
                    { 12, "JACK", 1, "JACK" },
                    { 21, "ALEX", 2, "ALEX" },
                    { 22, "ALEX", 2, "ALEX" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Description", "StudentId", "Title" },
                values: new object[,]
                {
                    { 11, "JACK", 1, "JACK" },
                    { 12, "JACK", 1, "JACK" },
                    { 21, "ALEX", 2, "ALEX" },
                    { 22, "ALEX", 2, "ALEX" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobby_StudentId",
                table: "Hobby",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_StudentId",
                table: "Project",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
