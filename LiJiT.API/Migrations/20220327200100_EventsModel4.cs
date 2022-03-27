using Microsoft.EntityFrameworkCore.Migrations;

namespace LiJiT.API.Migrations
{
    public partial class EventsModel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_statusTypes_StatusTypeId",
                table: "events");

            migrationBuilder.DropIndex(
                name: "IX_events_StatusTypeId",
                table: "events");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "StatusTypeId",
                table: "events",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateIndex(
                name: "IX_events_StatusTypeId",
                table: "events",
                column: "StatusTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_events_statusTypes_StatusTypeId",
                table: "events",
                column: "StatusTypeId",
                principalTable: "statusTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
