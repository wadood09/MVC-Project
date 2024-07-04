using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace QuestionGenerator.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RevistedAssesment");

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "User");

            migrationBuilder.CreateTable(
                name: "RevisitedAssesment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    AssessmentScore = table.Column<double>(type: "double", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevisitedAssesment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RevisitedAssesment_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RevisitedAssesment_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RevisitedAssesment_AssessmentId",
                table: "RevisitedAssesment",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RevisitedAssesment_DocumentId",
                table: "RevisitedAssesment",
                column: "DocumentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RevisitedAssesment");

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "User",
                type: "longtext",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "RevistedAssesment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    AssessmentScore = table.Column<double>(type: "double", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevistedAssesment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RevistedAssesment_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RevistedAssesment_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RevistedAssesment_AssessmentId",
                table: "RevistedAssesment",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RevistedAssesment_DocumentId",
                table: "RevistedAssesment",
                column: "DocumentId");
        }
    }
}
