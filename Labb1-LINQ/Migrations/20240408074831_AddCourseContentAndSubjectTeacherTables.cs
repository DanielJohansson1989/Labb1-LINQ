using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1_LINQ.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseContentAndSubjectTeacherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseContent",
                columns: table => new
                {
                    CourseContentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseContent", x => x.CourseContentId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Course_CourseContent_CourseContentId",
                        column: x => x.CourseContentId,
                        principalTable: "CourseContent",
                        principalColumn: "CourseContentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseContentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_CourseContent_CourseContentId",
                        column: x => x.CourseContentId,
                        principalTable: "CourseContent",
                        principalColumn: "CourseContentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTeacherAssociation",
                columns: table => new
                {
                    SubjectTeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseContentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacherAssociation", x => x.SubjectTeacherId);
                    table.ForeignKey(
                        name: "FK_SubjectTeacherAssociation_CourseContent_CourseContentId",
                        column: x => x.CourseContentId,
                        principalTable: "CourseContent",
                        principalColumn: "CourseContentId");
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectTeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subject_SubjectTeacherAssociation_SubjectTeacherId",
                        column: x => x.SubjectTeacherId,
                        principalTable: "SubjectTeacherAssociation",
                        principalColumn: "SubjectTeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectTeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teacher_SubjectTeacherAssociation_SubjectTeacherId",
                        column: x => x.SubjectTeacherId,
                        principalTable: "SubjectTeacherAssociation",
                        principalColumn: "SubjectTeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseContentId",
                table: "Course",
                column: "CourseContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseContentId",
                table: "Student",
                column: "CourseContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectTeacherId",
                table: "Subject",
                column: "SubjectTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacherAssociation_CourseContentId",
                table: "SubjectTeacherAssociation",
                column: "CourseContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectTeacherId",
                table: "Teacher",
                column: "SubjectTeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "SubjectTeacherAssociation");

            migrationBuilder.DropTable(
                name: "CourseContent");
        }
    }
}
