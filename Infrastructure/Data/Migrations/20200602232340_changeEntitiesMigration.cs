using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class changeEntitiesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "CarsReservation");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CarsReservation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CarsReservation_UserId",
                table: "CarsReservation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarsReservation_User_UserId",
                table: "CarsReservation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarsReservation_User_UserId",
                table: "CarsReservation");

            migrationBuilder.DropIndex(
                name: "IX_CarsReservation_UserId",
                table: "CarsReservation");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CarsReservation");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "CarsReservation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Car",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Car",
                type: "datetime2",
                nullable: true);
        }
    }
}
