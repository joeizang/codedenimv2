using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Codedenim.Web.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    CourseCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    CategoryDescription = table.Column<string>(maxLength: 200, nullable: true),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: false),
                    ImageLocation = table.Column<string>(maxLength: 300, nullable: true),
                    StudentType = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => x.CourseCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    PaymentName = table.Column<string>(maxLength: 100, nullable: false),
                    PaymentTypeValue = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RemitaPaymentLogs",
                columns: table => new
                {
                    RemitaPaymentLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<string>(maxLength: 20, nullable: false),
                    OrderId = table.Column<string>(maxLength: 50, nullable: false),
                    PayerName = table.Column<string>(maxLength: 50, nullable: false),
                    PaymentDate = table.Column<DateTimeOffset>(nullable: false),
                    PaymentName = table.Column<string>(maxLength: 50, nullable: false),
                    Rrr = table.Column<string>(maxLength: 100, nullable: false),
                    StatusCode = table.Column<string>(maxLength: 50, nullable: false),
                    TransactionMessage = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemitaPaymentLogs", x => x.RemitaPaymentLogId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    AccountType = table.Column<string>(maxLength: 15, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    Batch = table.Column<string>(maxLength: 30, nullable: true),
                    CallUpNo = table.Column<string>(maxLength: 50, nullable: true),
                    CountryOfBirth = table.Column<string>(maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(nullable: true),
                    Discpline = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    EnrollmentDate = table.Column<DateTimeOffset>(nullable: false),
                    FileLocation = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(maxLength: 50, nullable: true),
                    IsAcctive = table.Column<bool>(nullable: false),
                    IsGraduated = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    MatricNo = table.Column<string>(maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Passport = table.Column<byte[]>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    StateOfOrigin = table.Column<string>(maxLength: 50, nullable: true),
                    StateOfService = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 5, nullable: true),
                    TownOfBirth = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    TutorId = table.Column<string>(nullable: false),
                    ActiveStatus = table.Column<string>(maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    CountryOfBirth = table.Column<string>(maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(nullable: true),
                    Designation = table.Column<string>(maxLength: 4, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    FileLocation = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImageLocation = table.Column<string>(nullable: true),
                    IsAcctive = table.Column<bool>(nullable: false),
                    IsActiveTutor = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 10, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Passport = table.Column<byte[]>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    StaffRole = table.Column<string>(maxLength: 50, nullable: true),
                    StateOfOrigin = table.Column<string>(maxLength: 50, nullable: true),
                    TownOfBirth = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.TutorId);
                });

            migrationBuilder.CreateTable(
                name: "VoteForumAnswer",
                columns: table => new
                {
                    VoteForumAnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ForumAnswerId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Vote = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteForumAnswer", x => x.VoteForumAnswerId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorperEnrolledCourses",
                columns: table => new
                {
                    CorperEnrolledCoursesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CorperCallUpNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CourseCategoryId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorperEnrolledCourses", x => x.CorperEnrolledCoursesId);
                    table.ForeignKey(
                        name: "FK_CorperEnrolledCourses_CourseCategories_CourseCategoryId",
                        column: x => x.CourseCategoryId,
                        principalTable: "CourseCategories",
                        principalColumn: "CourseCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorperEnrolledCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentPayments",
                columns: table => new
                {
                    StudentPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    AmountPaid = table.Column<decimal>(nullable: false),
                    CourseCategoryId = table.Column<int>(nullable: false),
                    IsPayed = table.Column<bool>(nullable: false),
                    OrderId = table.Column<string>(nullable: true),
                    PaymentDateTime = table.Column<DateTimeOffset>(nullable: false),
                    PaymentStatus = table.Column<string>(maxLength: 20, nullable: true),
                    ReferenceNo = table.Column<string>(maxLength: 20, nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPayments", x => x.StudentPaymentId);
                    table.ForeignKey(
                        name: "FK_StudentPayments_CourseCategories_CourseCategoryId",
                        column: x => x.CourseCategoryId,
                        principalTable: "CourseCategories",
                        principalColumn: "CourseCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPayments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<byte[]>(nullable: false),
                    ContentType = table.Column<string>(maxLength: 100, nullable: false),
                    FileName = table.Column<string>(maxLength: 355, nullable: false),
                    FileType = table.Column<int>(nullable: false),
                    TutorId = table.Column<int>(nullable: false),
                    TutorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_Tutors_TutorId1",
                        column: x => x.TutorId1,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CorperEnrolledCoursesId = table.Column<int>(nullable: true),
                    CourseCode = table.Column<string>(maxLength: 10, nullable: false),
                    CourseDescription = table.Column<string>(maxLength: 300, nullable: true),
                    CourseImage = table.Column<byte[]>(nullable: true),
                    CourseName = table.Column<string>(maxLength: 300, nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: true),
                    ExpectedTime = table.Column<int>(nullable: false),
                    FileLocation = table.Column<string>(maxLength: 300, nullable: true),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_CorperEnrolledCourses_CorperEnrolledCoursesId",
                        column: x => x.CorperEnrolledCoursesId,
                        principalTable: "CorperEnrolledCourses",
                        principalColumn: "CorperEnrolledCoursesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssesmentQuestionAnswer",
                columns: table => new
                {
                    AssesmentQuestionAnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    IsFillInTheGag = table.Column<bool>(nullable: false),
                    IsMultiChoiceAnswer = table.Column<bool>(nullable: false),
                    IsSingleChoiceAnswer = table.Column<bool>(nullable: false),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: false),
                    QuestionHint = table.Column<string>(nullable: true),
                    QuestionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssesmentQuestionAnswer", x => x.AssesmentQuestionAnswerId);
                    table.ForeignKey(
                        name: "FK_AssesmentQuestionAnswer_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseRatings",
                columns: table => new
                {
                    CourseRatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    Dislike = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRatings", x => x.CourseRatingId);
                    table.ForeignKey(
                        name: "FK_CourseRatings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fora",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    ForumName = table.Column<string>(maxLength: 300, nullable: false),
                    LastPosted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fora", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Fora_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    ExpectedTime = table.Column<int>(nullable: false),
                    ModuleDescription = table.Column<string>(nullable: true),
                    ModuleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAssesment",
                columns: table => new
                {
                    StudentAssesmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: true),
                    CousreId = table.Column<int>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    TotalQuestion = table.Column<int>(nullable: false),
                    TotalScore = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssesment", x => x.StudentAssesmentId);
                    table.ForeignKey(
                        name: "FK_StudentAssesment_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAssesment_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentAssignedCourses",
                columns: table => new
                {
                    StudentAssignedCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssignedCourses", x => x.StudentAssignedCourseId);
                    table.ForeignKey(
                        name: "FK_StudentAssignedCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAssignedCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TutorCourses",
                columns: table => new
                {
                    TutorCoursesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    TutorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorCourses", x => x.TutorCoursesId);
                    table.ForeignKey(
                        name: "FK_TutorCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TutorCourses_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumQuestions",
                columns: table => new
                {
                    ForumQuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    PostDate = table.Column<DateTime>(nullable: false),
                    QuestionName = table.Column<string>(maxLength: 200, nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumQuestions", x => x.ForumQuestionId);
                    table.ForeignKey(
                        name: "FK_ForumQuestions_Fora_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Fora",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumQuestions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumViews",
                columns: table => new
                {
                    ContentViewId = table.Column<int>(nullable: false),
                    ViewCounter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumViews", x => x.ContentViewId);
                    table.ForeignKey(
                        name: "FK_ForumViews_Fora_ContentViewId",
                        column: x => x.ContentViewId,
                        principalTable: "Fora",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizLogs",
                columns: table => new
                {
                    QuizLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamTaken = table.Column<bool>(nullable: false),
                    ExamTypeId = table.Column<int>(nullable: false),
                    LevelId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    Score = table.Column<double>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    TopicId = table.Column<int>(nullable: false),
                    TotalScore = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizLogs", x => x.QuizLogId);
                    table.ForeignKey(
                        name: "FK_QuizLogs_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizLogs_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentTestLog",
                columns: table => new
                {
                    StudentTestLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamTaken = table.Column<bool>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    Score = table.Column<double>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    TotalScore = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTestLog", x => x.StudentTestLogId);
                    table.ForeignKey(
                        name: "FK_StudentTestLog_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTestLog_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentTopicQuizs",
                columns: table => new
                {
                    StudentTopicQuizId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(maxLength: 300, nullable: false),
                    Check1 = table.Column<bool>(nullable: false),
                    Check2 = table.Column<bool>(nullable: false),
                    Check3 = table.Column<bool>(nullable: false),
                    Check4 = table.Column<bool>(nullable: false),
                    ExamTime = table.Column<int>(nullable: false),
                    FilledAnswer = table.Column<string>(maxLength: 500, nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    IsFillInTheGag = table.Column<bool>(nullable: false),
                    IsMultiChoiceAnswer = table.Column<bool>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    Option1 = table.Column<string>(maxLength: 300, nullable: false),
                    Option2 = table.Column<string>(maxLength: 300, nullable: false),
                    Option3 = table.Column<string>(maxLength: 300, nullable: false),
                    Option4 = table.Column<string>(maxLength: 300, nullable: false),
                    Question = table.Column<string>(maxLength: 300, nullable: false),
                    QuestionHint = table.Column<string>(maxLength: 300, nullable: false),
                    QuestionNumber = table.Column<int>(nullable: false),
                    SelectedAnswer = table.Column<string>(maxLength: 300, nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    StudentQuestionId = table.Column<int>(nullable: false),
                    TotalQuestion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTopicQuizs", x => x.StudentTopicQuizId);
                    table.ForeignKey(
                        name: "FK_StudentTopicQuizs_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTopicQuizs_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpectedTime = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    TopicName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                    table.ForeignKey(
                        name: "FK_Topics_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignCourseCategories",
                columns: table => new
                {
                    AssignCourseCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseCategoryId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    StudentAssignedCourseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignCourseCategories", x => x.AssignCourseCategoryId);
                    table.ForeignKey(
                        name: "FK_AssignCourseCategories_CourseCategories_CourseCategoryId",
                        column: x => x.CourseCategoryId,
                        principalTable: "CourseCategories",
                        principalColumn: "CourseCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignCourseCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignCourseCategories_StudentAssignedCourses_StudentAssignedCourseId",
                        column: x => x.StudentAssignedCourseId,
                        principalTable: "StudentAssignedCourses",
                        principalColumn: "StudentAssignedCourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumAnswers",
                columns: table => new
                {
                    ForumAnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true),
                    ForumQuestionId = table.Column<int>(nullable: false),
                    ReplyDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAnswers", x => x.ForumAnswerId);
                    table.ForeignKey(
                        name: "FK_ForumAnswers_ForumQuestions_ForumQuestionId",
                        column: x => x.ForumQuestionId,
                        principalTable: "ForumQuestions",
                        principalColumn: "ForumQuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumQuestionViews",
                columns: table => new
                {
                    ForumQuestionId = table.Column<int>(nullable: false),
                    ViewCounter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumQuestionViews", x => x.ForumQuestionId);
                    table.ForeignKey(
                        name: "FK_ForumQuestionViews_ForumQuestions_ForumQuestionId",
                        column: x => x.ForumQuestionId,
                        principalTable: "ForumQuestions",
                        principalColumn: "ForumQuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(maxLength: 1000, nullable: false),
                    PostDate = table.Column<DateTimeOffset>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    TopicId = table.Column<int>(nullable: false),
                    TutorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuizRules",
                columns: table => new
                {
                    QuizRuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaximumTime = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    ScorePerQuestion = table.Column<double>(nullable: false),
                    TopicId = table.Column<int>(nullable: false),
                    TotalQuestion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizRules", x => x.QuizRuleId);
                    table.ForeignKey(
                        name: "FK_QuizRules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizRules_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentQuestion",
                columns: table => new
                {
                    StudentQuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true),
                    Check1 = table.Column<bool>(nullable: false),
                    Check2 = table.Column<bool>(nullable: false),
                    Check3 = table.Column<bool>(nullable: false),
                    Check4 = table.Column<bool>(nullable: false),
                    ExamTime = table.Column<int>(nullable: false),
                    FilledAnswer = table.Column<string>(nullable: true),
                    IsCorrect = table.Column<bool>(nullable: false),
                    IsFillInTheGag = table.Column<bool>(nullable: false),
                    IsMultiChoiceAnswer = table.Column<bool>(nullable: false),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    QuestionHint = table.Column<string>(nullable: true),
                    QuestionNumber = table.Column<int>(nullable: false),
                    SelectedAnswer = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true),
                    TopicId = table.Column<int>(nullable: false),
                    TotalQuestion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentQuestion", x => x.StudentQuestionId);
                    table.ForeignKey(
                        name: "FK_StudentQuestion_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQuestion_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubmitAssignment",
                columns: table => new
                {
                    SubmitAssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentBody = table.Column<string>(nullable: true),
                    AttachmentLocation = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true),
                    TopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmitAssignment", x => x.SubmitAssignmentId);
                    table.ForeignKey(
                        name: "FK_SubmitAssignment_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubmitAssignment_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopicAssignment",
                columns: table => new
                {
                    TopicAssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentDescription = table.Column<string>(maxLength: 300, nullable: true),
                    AssignmentDueDate = table.Column<DateTimeOffset>(nullable: true),
                    AssignmentTitle = table.Column<string>(maxLength: 100, nullable: false),
                    TopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicAssignment", x => x.TopicAssignmentId);
                    table.ForeignKey(
                        name: "FK_TopicAssignment_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopicMaterialUploads",
                columns: table => new
                {
                    TopicMaterialUploadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    FileLocation = table.Column<string>(maxLength: 300, nullable: true),
                    FileType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    TopicId = table.Column<int>(nullable: false),
                    TutorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicMaterialUploads", x => x.TopicMaterialUploadId);
                    table.ForeignKey(
                        name: "FK_TopicMaterialUploads_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicMaterialUploads_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "TutorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TopicQuizs",
                columns: table => new
                {
                    TopicQuizId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: false),
                    IsFillInTheGag = table.Column<bool>(nullable: false),
                    IsMultiChoiceAnswer = table.Column<bool>(nullable: false),
                    IsSingleChoiceAnswer = table.Column<bool>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: false),
                    QuestionHint = table.Column<string>(nullable: true),
                    QuestionType = table.Column<string>(maxLength: 200, nullable: true),
                    TopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicQuizs", x => x.TopicQuizId);
                    table.ForeignKey(
                        name: "FK_TopicQuizs_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicQuizs_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumAnswerVoteForumAnswers",
                columns: table => new
                {
                    ForumAnswerId = table.Column<int>(nullable: false),
                    VoteForumAnswerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumAnswerVoteForumAnswers", x => new { x.ForumAnswerId, x.VoteForumAnswerId });
                    table.ForeignKey(
                        name: "FK_ForumAnswerVoteForumAnswers_ForumAnswers_ForumAnswerId",
                        column: x => x.ForumAnswerId,
                        principalTable: "ForumAnswers",
                        principalColumn: "ForumAnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumAnswerVoteForumAnswers_VoteForumAnswer_VoteForumAnswerId",
                        column: x => x.VoteForumAnswerId,
                        principalTable: "VoteForumAnswer",
                        principalColumn: "VoteForumAnswerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentReview",
                columns: table => new
                {
                    AssignmentReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<string>(nullable: true),
                    ReviewComment = table.Column<string>(nullable: true),
                    SubmitAssignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentReview", x => x.AssignmentReviewId);
                    table.ForeignKey(
                        name: "FK_AssignmentReview_SubmitAssignment_SubmitAssignmentId",
                        column: x => x.SubmitAssignmentId,
                        principalTable: "SubmitAssignment",
                        principalColumn: "SubmitAssignmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssesmentQuestionAnswer_CourseId",
                table: "AssesmentQuestionAnswer",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignCourseCategories_CourseCategoryId",
                table: "AssignCourseCategories",
                column: "CourseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignCourseCategories_CourseId",
                table: "AssignCourseCategories",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignCourseCategories_StudentAssignedCourseId",
                table: "AssignCourseCategories",
                column: "StudentAssignedCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentReview_SubmitAssignmentId",
                table: "AssignmentReview",
                column: "SubmitAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_CorperEnrolledCourses_CourseCategoryId",
                table: "CorperEnrolledCourses",
                column: "CourseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CorperEnrolledCourses_StudentId",
                table: "CorperEnrolledCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRatings_CourseId",
                table: "CourseRatings",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CorperEnrolledCoursesId",
                table: "Courses",
                column: "CorperEnrolledCoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_TutorId1",
                table: "Files",
                column: "TutorId1");

            migrationBuilder.CreateIndex(
                name: "IX_ForumAnswers_ForumQuestionId",
                table: "ForumAnswers",
                column: "ForumQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumAnswerVoteForumAnswers_VoteForumAnswerId",
                table: "ForumAnswerVoteForumAnswers",
                column: "VoteForumAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumQuestions_CourseId",
                table: "ForumQuestions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumQuestions_StudentId",
                table: "ForumQuestions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_TopicId",
                table: "Post",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_TutorId",
                table: "Post",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizLogs_ModuleId",
                table: "QuizLogs",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizLogs_StudentId",
                table: "QuizLogs",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizRules_ModuleId",
                table: "QuizRules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizRules_TopicId",
                table: "QuizRules",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssesment_CourseId",
                table: "StudentAssesment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssesment_StudentId",
                table: "StudentAssesment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignedCourses_CourseId",
                table: "StudentAssignedCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignedCourses_StudentId",
                table: "StudentAssignedCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_CourseCategoryId",
                table: "StudentPayments",
                column: "CourseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_StudentId",
                table: "StudentPayments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuestion_StudentId",
                table: "StudentQuestion",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuestion_TopicId",
                table: "StudentQuestion",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTestLog_ModuleId",
                table: "StudentTestLog",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTestLog_StudentId",
                table: "StudentTestLog",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTopicQuizs_ModuleId",
                table: "StudentTopicQuizs",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTopicQuizs_StudentId",
                table: "StudentTopicQuizs",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmitAssignment_StudentId",
                table: "SubmitAssignment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmitAssignment_TopicId",
                table: "SubmitAssignment",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicAssignment_TopicId",
                table: "TopicAssignment",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMaterialUploads_TopicId",
                table: "TopicMaterialUploads",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicMaterialUploads_TutorId",
                table: "TopicMaterialUploads",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicQuizs_ModuleId",
                table: "TopicQuizs",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicQuizs_TopicId",
                table: "TopicQuizs",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ModuleId",
                table: "Topics",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorCourses_CourseId",
                table: "TutorCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorCourses_TutorId",
                table: "TutorCourses",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssesmentQuestionAnswer");

            migrationBuilder.DropTable(
                name: "AssignCourseCategories");

            migrationBuilder.DropTable(
                name: "AssignmentReview");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "CourseRatings");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "ForumAnswerVoteForumAnswers");

            migrationBuilder.DropTable(
                name: "ForumQuestionViews");

            migrationBuilder.DropTable(
                name: "ForumViews");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "QuizLogs");

            migrationBuilder.DropTable(
                name: "QuizRules");

            migrationBuilder.DropTable(
                name: "RemitaPaymentLogs");

            migrationBuilder.DropTable(
                name: "StudentAssesment");

            migrationBuilder.DropTable(
                name: "StudentPayments");

            migrationBuilder.DropTable(
                name: "StudentQuestion");

            migrationBuilder.DropTable(
                name: "StudentTestLog");

            migrationBuilder.DropTable(
                name: "StudentTopicQuizs");

            migrationBuilder.DropTable(
                name: "TopicAssignment");

            migrationBuilder.DropTable(
                name: "TopicMaterialUploads");

            migrationBuilder.DropTable(
                name: "TopicQuizs");

            migrationBuilder.DropTable(
                name: "TutorCourses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StudentAssignedCourses");

            migrationBuilder.DropTable(
                name: "SubmitAssignment");

            migrationBuilder.DropTable(
                name: "ForumAnswers");

            migrationBuilder.DropTable(
                name: "VoteForumAnswer");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "ForumQuestions");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "Fora");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CorperEnrolledCourses");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
