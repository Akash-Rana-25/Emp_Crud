using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Managment.Migrations
{
    public partial class dfgwsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "PunchEvents");

            migrationBuilder.DropColumn(
                name: "PunchTime",
                table: "PunchEvents");

            migrationBuilder.DropColumn(
                name: "PunchType",
                table: "PunchEvents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "PunchEvents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PunchTime",
                table: "PunchEvents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PunchType",
                table: "PunchEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
