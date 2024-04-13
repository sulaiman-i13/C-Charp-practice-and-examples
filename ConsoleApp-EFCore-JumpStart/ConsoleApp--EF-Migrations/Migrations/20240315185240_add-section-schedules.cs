using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp.EF.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class addsectionschedules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Section",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SUN = table.Column<bool>(type: "bit", nullable: false),
                    MON = table.Column<bool>(type: "bit", nullable: false),
                    TUE = table.Column<bool>(type: "bit", nullable: false),
                    WED = table.Column<bool>(type: "bit", nullable: false),
                    THU = table.Column<bool>(type: "bit", nullable: false),
                    FRI = table.Column<bool>(type: "bit", nullable: false),
                    SAT = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionSchedule_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionSchedule_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "FRI", "MON", "SAT", "SUN", "THU", "TUE", "Title", "WED" },
                values: new object[,]
                {
                    { 1, false, true, false, true, true, true, "Daily", true },
                    { 2, false, false, false, true, true, true, "DayAfterDay", false },
                    { 3, false, true, false, false, false, false, "Twice-a-Week", true },
                    { 4, true, false, true, false, false, false, "Weekend", false },
                    { 5, true, true, true, true, true, true, "Compact", true }
                });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1,
                column: "SectionName",
                value: "S_MA1");

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2,
                column: "SectionName",
                value: "S_MA2");

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 2, 1, "S_PH1" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InstructorId", "SectionName" },
                values: new object[] { 3, "S_PH2" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InstructorId", "SectionName" },
                values: new object[] { 2, "S_CH1" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 3, 3, "S_CH2" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 4, 4, "S_BI1" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 8,
                column: "SectionName",
                value: "S_BI2");

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 5, 4, "S_CS1" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InstructorId", "SectionName" },
                values: new object[] { 5, "S_CS2" });

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 11, 5, 4, "S_CS3" });

            migrationBuilder.InsertData(
                table: "SectionSchedule",
                columns: new[] { "Id", "EndTime", "ScheduleId", "SectionId", "StartTime" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 10, 0, 0, 0), 1, 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new TimeSpan(0, 18, 0, 0, 0), 3, 2, new TimeSpan(0, 14, 0, 0, 0) },
                    { 3, new TimeSpan(0, 15, 0, 0, 0), 4, 3, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, new TimeSpan(0, 12, 0, 0, 0), 1, 4, new TimeSpan(0, 10, 0, 0, 0) },
                    { 5, new TimeSpan(0, 18, 0, 0, 0), 1, 5, new TimeSpan(0, 16, 0, 0, 0) },
                    { 6, new TimeSpan(0, 10, 0, 0, 0), 2, 6, new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, new TimeSpan(0, 14, 0, 0, 0), 3, 7, new TimeSpan(0, 11, 0, 0, 0) },
                    { 8, new TimeSpan(0, 14, 0, 0, 0), 4, 8, new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, new TimeSpan(0, 18, 0, 0, 0), 4, 9, new TimeSpan(0, 16, 0, 0, 0) },
                    { 10, new TimeSpan(0, 15, 0, 0, 0), 3, 10, new TimeSpan(0, 12, 0, 0, 0) },
                    { 11, new TimeSpan(0, 11, 0, 0, 0), 5, 11, new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedule_ScheduleId",
                table: "SectionSchedule",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedule_SectionId",
                table: "SectionSchedule",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionSchedule");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Section",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1,
                column: "SectionName",
                value: "Section #1");

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2,
                column: "SectionName",
                value: "Section #2");

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 1, 3, "Section #3" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InstructorId", "SectionName" },
                values: new object[] { 2, "Section #4" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InstructorId", "SectionName" },
                values: new object[] { 3, "Section #5" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 4, 4, "Section #6" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 3, 5, "Section #7" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 8,
                column: "SectionName",
                value: "Section #8");

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "InstructorId", "SectionName" },
                values: new object[] { 3, 2, "Section #9" });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InstructorId", "SectionName" },
                values: new object[] { 2, "Section #10" });
        }
    }
}
