using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioMed.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PricePerVisit = table.Column<decimal>(type: "Money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disease_DiseaseCategory_DiseaseCategoryId",
                        column: x => x.DiseaseCategoryId,
                        principalTable: "DiseaseCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorCategory_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorDepartment_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Prescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TotalPrice = table.Column<decimal>(type: "Money", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visit_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visit_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TestTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabResult_TestType_TestTypeId",
                        column: x => x.TestTypeId,
                        principalTable: "TestType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Visit_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    LabResultId = table.Column<int>(type: "int", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatment_Disease_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatment_LabResult_LabResultId",
                        column: x => x.LabResultId,
                        principalTable: "LabResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatment_Visit_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disease_DiseaseCategoryId",
                table: "Disease",
                column: "DiseaseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorCategory_CategoryId",
                table: "DoctorCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorCategory_DoctorId",
                table: "DoctorCategory",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorDepartment_DepartmentId",
                table: "DoctorDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorDepartment_DoctorId",
                table: "DoctorDepartment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResult_TestTypeId",
                table: "LabResult",
                column: "TestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_VisitId",
                table: "Payment",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_DiseaseId",
                table: "Treatment",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_LabResultId",
                table: "Treatment",
                column: "LabResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_VisitId",
                table: "Treatment",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_DoctorId",
                table: "Visit",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PatientId",
                table: "Visit",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorCategory");

            migrationBuilder.DropTable(
                name: "DoctorDepartment");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Treatment");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Disease");

            migrationBuilder.DropTable(
                name: "LabResult");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "DiseaseCategory");

            migrationBuilder.DropTable(
                name: "TestType");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
