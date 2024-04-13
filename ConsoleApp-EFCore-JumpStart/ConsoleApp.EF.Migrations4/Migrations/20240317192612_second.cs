using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp.EF.Migrations4.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Participants");

            migrationBuilder.AddColumn<string>(
                name: "ParticipantType",
                table: "Participants",
                type: "varchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticipantType",
                table: "Participants");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Participants",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }
    }
}
