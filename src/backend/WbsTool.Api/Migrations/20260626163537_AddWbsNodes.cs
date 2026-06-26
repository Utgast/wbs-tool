using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WbsTool.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddWbsNodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WbsNodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProjectId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ParentId = table.Column<Guid>(type: "TEXT", nullable: true),
                    VisibleWbsId = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    SortOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    PlannedStart = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    PlannedEnd = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    PlannedHours = table.Column<decimal>(type: "TEXT", nullable: true),
                    ActualHours = table.Column<decimal>(type: "TEXT", nullable: true),
                    IsBlocked = table.Column<bool>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WbsNodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WbsNodes_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WbsNodes_WbsNodes_ParentId",
                        column: x => x.ParentId,
                        principalTable: "WbsNodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WbsNodes_ParentId",
                table: "WbsNodes",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_WbsNodes_ProjectId",
                table: "WbsNodes",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WbsNodes");
        }
    }
}
