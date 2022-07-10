using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PreferredSets = table.Column<int>(type: "INTEGER", nullable: false),
                    PreferredReps = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuscleFocuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleFocuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPrograms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    WorkoutProgramId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExersiceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Sets = table.Column<int>(type: "INTEGER", nullable: false),
                    Reps = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    Day = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => new { x.WorkoutProgramId, x.ExersiceId });
                    table.ForeignKey(
                        name: "FK_Workout_Exercises_ExersiceId",
                        column: x => x.ExersiceId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workout_WorkoutPrograms_WorkoutProgramId",
                        column: x => x.WorkoutProgramId,
                        principalTable: "WorkoutPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutFocus",
                columns: table => new
                {
                    WorkoutProgramId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MuscleFocusId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutFocus", x => new { x.WorkoutProgramId, x.MuscleFocusId });
                    table.ForeignKey(
                        name: "FK_WorkoutFocus_MuscleFocuses_MuscleFocusId",
                        column: x => x.MuscleFocusId,
                        principalTable: "MuscleFocuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutFocus_WorkoutPrograms_WorkoutProgramId",
                        column: x => x.WorkoutProgramId,
                        principalTable: "WorkoutPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_ExersiceId",
                table: "Workout",
                column: "ExersiceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutFocus_MuscleFocusId",
                table: "WorkoutFocus",
                column: "MuscleFocusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutFocus");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "MuscleFocuses");

            migrationBuilder.DropTable(
                name: "WorkoutPrograms");
        }
    }
}
