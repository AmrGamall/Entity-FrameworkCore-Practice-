using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCorePractice.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Departmentid",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Evaluation",
                table: "InstructorCourse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                columns: new[] { "CourseId", "InstructorId" });

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourse_InstructorId",
                table: "InstructorCourse",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Departmentid",
                table: "Students",
                column: "Departmentid",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Departmentid",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourse_InstructorId",
                table: "InstructorCourse");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Evaluation",
                table: "InstructorCourse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                columns: new[] { "InstructorId", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Departmentid",
                table: "Students",
                column: "Departmentid",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
