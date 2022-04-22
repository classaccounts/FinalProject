using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectWebServerApp.Migrations
{
    public partial class jackseed : Migration
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
                    { 11, "It might seem weird to put weightlifting as a hobby on this page, but I have a reasonable justification. I’ve been consistently lifting for the past two years. Why, might you ask? Because I honestly need a little endorphin boost in my life. It simply feels great to do. It’s also a fun challenge. It usually works if you plan your meals correctly, build a lifting program that meets your goals and stay dedicated to the routines. Finally, it’s gratifying to see your weight on the bar increase over time, showing you are stronger than you were the previous month (that might be an ego thing). My style of lifting is purely to move heavyweight like a caveman. I wish I had started earlier because I was always working out in high school. I was on the swim and water polo team, where I competed at the state level. I hated lifting back then because I was always so exhausted after practice. However, my mindset on that has changed, and now I enjoy it.", 1, "Lifting" },
                    { 12, "I’m trying to keep up with my theme of not putting all my technical hobbies in here because that would seem redundant for a coding class. I enjoy spending at least 30 minutes a day playing the drums. I’ve played the bass since 4th grade, but I burnt out of that my first year. So the next logical step was to teach myself the drums. It’s a great stress reliever in the winter to bang out some songs when there’s nothing to do in the cold of Ohio. It keeps me in touch with the mind-body connection (I know that sounds weird).", 1, "Drumming" },
                    { 21, "ALEX", 2, "ALEX" },
                    { 22, "ALEX", 2, "ALEX" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Description", "StudentId", "Title" },
                values: new object[,]
                {
                    { 11, "Probably one of my favorite projects I did back in high school. Our team would build combat robots and fight them in competitions. We had a meager budget but did the best we could. I remember spending the countless sleepless night working on that robot days before the competition would start. Sometimes we would do very well; other times, we would fail. However, in my senior year, we built & machined our best combat robot. We made it to the final four, which is impressive considering the schools we had to face were trade schools. We even beat some colleges, including UC and Kent state. I made it back from the competition just in time for prom.", 1, "Xtreme Robotics" },
                    { 12, "The DavBot project, less affectionately known as the Davenport Aviation robot, is a microservice ecosystem that performs various aspects of business automation. I started the project back in 2018, and it has grown ever since. The most interesting module is the automatic web data aggregation service, which provides real-time statistics on the aviation industry and various markets. However, there are other exciting microservices attached to it as well.", 1, "DavBot Project" },
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
