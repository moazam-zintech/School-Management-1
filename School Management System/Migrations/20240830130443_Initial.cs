using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Class_id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Grd_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grd_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Grd_id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Std_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Std_id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Sbj_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sbj_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Sbj_id);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Trm_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Trm_id);
                });

            migrationBuilder.CreateTable(
                name: "GradeStudent",
                columns: table => new
                {
                    GradesGrd_id = table.Column<int>(type: "int", nullable: false),
                    StudentsStd_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeStudent", x => new { x.GradesGrd_id, x.StudentsStd_id });
                    table.ForeignKey(
                        name: "FK_GradeStudent_Grades_GradesGrd_id",
                        column: x => x.GradesGrd_id,
                        principalTable: "Grades",
                        principalColumn: "Grd_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GradeStudent_Students_StudentsStd_id",
                        column: x => x.StudentsStd_id,
                        principalTable: "Students",
                        principalColumn: "Std_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentClasses",
                columns: table => new
                {
                    ClassesClass_id = table.Column<int>(type: "int", nullable: false),
                    StudentsStd_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClasses", x => new { x.ClassesClass_id, x.StudentsStd_id });
                    table.ForeignKey(
                        name: "FK_StudentClasses_Classes_ClassesClass_id",
                        column: x => x.ClassesClass_id,
                        principalTable: "Classes",
                        principalColumn: "Class_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClasses_Students_StudentsStd_id",
                        column: x => x.StudentsStd_id,
                        principalTable: "Students",
                        principalColumn: "Std_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    T_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_joining = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    StudentStd_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.T_id);
                    table.ForeignKey(
                        name: "FK_Teachers_Students_StudentStd_id",
                        column: x => x.StudentStd_id,
                        principalTable: "Students",
                        principalColumn: "Std_id");
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentsStd_id = table.Column<int>(type: "int", nullable: false),
                    SubjectsSbj_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentsStd_id, x.SubjectsSbj_id });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Students_StudentsStd_id",
                        column: x => x.StudentsStd_id,
                        principalTable: "Students",
                        principalColumn: "Std_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subjects_SubjectsSbj_id",
                        column: x => x.SubjectsSbj_id,
                        principalTable: "Subjects",
                        principalColumn: "Sbj_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTerm",
                columns: table => new
                {
                    StudentsStd_id = table.Column<int>(type: "int", nullable: false),
                    TermsTrm_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTerm", x => new { x.StudentsStd_id, x.TermsTrm_id });
                    table.ForeignKey(
                        name: "FK_StudentTerm_Students_StudentsStd_id",
                        column: x => x.StudentsStd_id,
                        principalTable: "Students",
                        principalColumn: "Std_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTerm_Terms_TermsTrm_id",
                        column: x => x.TermsTrm_id,
                        principalTable: "Terms",
                        principalColumn: "Trm_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassTeacher",
                columns: table => new
                {
                    Class_id = table.Column<int>(type: "int", nullable: false),
                    TeachersT_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTeacher", x => new { x.Class_id, x.TeachersT_id });
                    table.ForeignKey(
                        name: "FK_ClassTeacher_Classes_Class_id",
                        column: x => x.Class_id,
                        principalTable: "Classes",
                        principalColumn: "Class_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassTeacher_Teachers_TeachersT_id",
                        column: x => x.TeachersT_id,
                        principalTable: "Teachers",
                        principalColumn: "T_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    SubjectSbj_id = table.Column<int>(type: "int", nullable: false),
                    TeachersT_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.SubjectSbj_id, x.TeachersT_id });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Subjects_SubjectSbj_id",
                        column: x => x.SubjectSbj_id,
                        principalTable: "Subjects",
                        principalColumn: "Sbj_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Teachers_TeachersT_id",
                        column: x => x.TeachersT_id,
                        principalTable: "Teachers",
                        principalColumn: "T_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassTeacher_TeachersT_id",
                table: "ClassTeacher",
                column: "TeachersT_id");

            migrationBuilder.CreateIndex(
                name: "IX_GradeStudent_StudentsStd_id",
                table: "GradeStudent",
                column: "StudentsStd_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_StudentsStd_id",
                table: "StudentClasses",
                column: "StudentsStd_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectsSbj_id",
                table: "StudentSubject",
                column: "SubjectsSbj_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTerm_TermsTrm_id",
                table: "StudentTerm",
                column: "TermsTrm_id");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_TeachersT_id",
                table: "SubjectTeacher",
                column: "TeachersT_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_StudentStd_id",
                table: "Teachers",
                column: "StudentStd_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassTeacher");

            migrationBuilder.DropTable(
                name: "GradeStudent");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Register");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "StudentTerm");

            migrationBuilder.DropTable(
                name: "SubjectTeacher");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
