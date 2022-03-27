using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiJiT.API.Migrations
{
    public partial class EventsModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageEvent",
                table: "events",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageEvent",
                table: "events");
        }
    }
}
