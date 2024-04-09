using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1_LINQ.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNavgatonProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_CourseContent_CourseContentId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "CourseContentId",
                table: "Student",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CourseContentId",
                table: "Student",
                newName: "IX_Student_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_CourseId",
                table: "Student",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_CourseId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Student",
                newName: "CourseContentId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CourseId",
                table: "Student",
                newName: "IX_Student_CourseContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_CourseContent_CourseContentId",
                table: "Student",
                column: "CourseContentId",
                principalTable: "CourseContent",
                principalColumn: "CourseContentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
