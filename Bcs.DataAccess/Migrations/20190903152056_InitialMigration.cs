using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bcs.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
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
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    DisableLogin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatchName = table.Column<string>(nullable: true),
                    BatchDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCategories",
                columns: table => new
                {
                    PaymentCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCategories", x => x.PaymentCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Programmes",
                columns: table => new
                {
                    ProgrammeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProgrammeName = table.Column<string>(nullable: true),
                    ProgrammeCode = table.Column<string>(nullable: true),
                    ProgrammeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmes", x => x.ProgrammeId);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SessionName = table.Column<string>(nullable: true),
                    ActiveSession = table.Column<bool>(nullable: false),
                    SessionStart = table.Column<DateTime>(nullable: false),
                    SessionEnd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OtherNames = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    StateOfOrigin = table.Column<string>(nullable: true),
                    Lga = table.Column<string>(nullable: true),
                    Passport = table.Column<byte>(nullable: false),
                    StaffNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
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
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProgrammeId = table.Column<int>(nullable: false),
                    CourseName = table.Column<string>(nullable: true),
                    CourseCode = table.Column<string>(nullable: true),
                    CourseDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Programmes_ProgrammeId",
                        column: x => x.ProgrammeId,
                        principalTable: "Programmes",
                        principalColumn: "ProgrammeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSettings",
                columns: table => new
                {
                    PaymentSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentCategoryId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    ApplyDiscount = table.Column<bool>(nullable: false),
                    ConsiderNationality = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSettings", x => x.PaymentSettingId);
                    table.ForeignKey(
                        name: "FK_PaymentSettings_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentSettings_PaymentCategories_PaymentCategoryId",
                        column: x => x.PaymentCategoryId,
                        principalTable: "PaymentCategories",
                        principalColumn: "PaymentCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentSettings_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentCategoryId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    AmountInWords = table.Column<string>(nullable: true),
                    IsForeign = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_PaymentCategories_PaymentCategoryId",
                        column: x => x.PaymentCategoryId,
                        principalTable: "PaymentCategories",
                        principalColumn: "PaymentCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OtherNames = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    StateOfOrigin = table.Column<string>(nullable: true),
                    Lga = table.Column<string>(nullable: true),
                    Passport = table.Column<byte>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    StudentNumber = table.Column<string>(nullable: true),
                    BcsReferenceNumber = table.Column<string>(nullable: true),
                    IsTrainingCandidate = table.Column<bool>(nullable: false),
                    IsExamCandidate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseRegistrations",
                columns: table => new
                {
                    CourseRegistrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    IsTraining = table.Column<bool>(nullable: false),
                    IsExam = table.Column<bool>(nullable: false),
                    TrainingRegDate = table.Column<DateTime>(nullable: false),
                    ExamRegDate = table.Column<DateTime>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRegistrations", x => x.CourseRegistrationId);
                    table.ForeignKey(
                        name: "FK_CourseRegistrations_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRegistrations_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRegistrations_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamTimeTables",
                columns: table => new
                {
                    ExamTimeTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    ExamDate = table.Column<DateTime>(nullable: false),
                    ExamStartTime = table.Column<DateTime>(nullable: false),
                    ExamEndTime = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    VenueDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTimeTables", x => x.ExamTimeTableId);
                    table.ForeignKey(
                        name: "FK_ExamTimeTables_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamTimeTables_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamTimeTables_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingTimeTables",
                columns: table => new
                {
                    TrainingTimeTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    DayOfTheWeek = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    VenueDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingTimeTables", x => x.TrainingTimeTableId);
                    table.ForeignKey(
                        name: "FK_TrainingTimeTables_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingTimeTables_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingTimeTables_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentPayments",
                columns: table => new
                {
                    StudentPaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: true),
                    PaymentReferenceNo = table.Column<string>(maxLength: 30, nullable: true),
                    PaymentCategoryId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    IsPayed = table.Column<bool>(nullable: false),
                    PaymentStatus = table.Column<string>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPayments", x => x.StudentPaymentId);
                    table.ForeignKey(
                        name: "FK_StudentPayments_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPayments_PaymentCategories_PaymentCategoryId",
                        column: x => x.PaymentCategoryId,
                        principalTable: "PaymentCategories",
                        principalColumn: "PaymentCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPayments_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPayments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentResults",
                columns: table => new
                {
                    StudentResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: true),
                    CourseId = table.Column<int>(nullable: false),
                    BatchId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    Grade = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentResults", x => x.StudentResultId);
                    table.ForeignKey(
                        name: "FK_StudentResults_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentResults_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentResults_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "18209871-61a2-4b29-ab19-ec4f98151b15", "Admin", "Admin" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e675", "58fbf796-b635-4fb9-943e-a4497097b7f0", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisableLogin", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffId", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "15cb1ad6-7143-40d0-9cdd-f0849ecd4413", false, "Admin@Compunet.com", true, false, null, "ADMIN@COMPUNET.COM", "ADMIN@COMPUNET.COM", "AQAAAAEAACcQAAAAEJn9Qq5TjnVFXsrMlMfMoyujM9VwmBQMCeTMPZFy8WaTJtJTQfEAjEvf4BAPiVDIaQ==", null, false, "", 0, 0, false, "Admin@Compunet.com" },
                    { "a18be9c0-aa65-4af8-bd17-00bd9344e675", 0, "5042669a-71d5-4f9a-8dd6-f3f06b239776", false, "SuperAdmin@Compunet.com", true, false, null, "SUPERADMIN@COMPUNET.COM", "SUPERADMIN@COMPUNET.COM", "AQAAAAEAACcQAAAAELz18rSHXTKTAbBIqefr3oIGNTOp6798qmWkO5Lzw+Whz2WhaJnIDwDRbFHHRInvYQ==", null, false, "", 0, 0, false, "SuperAdmin@Compunet.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e675", "a18be9c0-aa65-4af8-bd17-00bd9344e675" });

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
                name: "IX_CourseRegistrations_BatchId",
                table: "CourseRegistrations",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistrations_CourseId",
                table: "CourseRegistrations",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistrations_SessionId",
                table: "CourseRegistrations",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ProgrammeId",
                table: "Courses",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamTimeTables_BatchId",
                table: "ExamTimeTables",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamTimeTables_CourseId",
                table: "ExamTimeTables",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamTimeTables_SessionId",
                table: "ExamTimeTables",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSettings_BatchId",
                table: "PaymentSettings",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSettings_PaymentCategoryId",
                table: "PaymentSettings",
                column: "PaymentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSettings_SessionId",
                table: "PaymentSettings",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_BatchId",
                table: "PaymentTypes",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_PaymentCategoryId",
                table: "PaymentTypes",
                column: "PaymentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_SessionId",
                table: "PaymentTypes",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_BatchId",
                table: "StudentPayments",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_PaymentCategoryId",
                table: "StudentPayments",
                column: "PaymentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_PaymentReferenceNo",
                table: "StudentPayments",
                column: "PaymentReferenceNo",
                unique: true,
                filter: "[PaymentReferenceNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_SessionId",
                table: "StudentPayments",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_StudentId",
                table: "StudentPayments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentResults_BatchId",
                table: "StudentResults",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentResults_CourseId",
                table: "StudentResults",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentResults_SessionId",
                table: "StudentResults",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentResults_StudentId",
                table: "StudentResults",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SessionId",
                table: "Students",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingTimeTables_BatchId",
                table: "TrainingTimeTables",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingTimeTables_CourseId",
                table: "TrainingTimeTables",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingTimeTables_SessionId",
                table: "TrainingTimeTables",
                column: "SessionId");
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
                name: "CourseRegistrations");

            migrationBuilder.DropTable(
                name: "ExamTimeTables");

            migrationBuilder.DropTable(
                name: "PaymentSettings");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "StudentPayments");

            migrationBuilder.DropTable(
                name: "StudentResults");

            migrationBuilder.DropTable(
                name: "TrainingTimeTables");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PaymentCategories");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Programmes");
        }
    }
}
