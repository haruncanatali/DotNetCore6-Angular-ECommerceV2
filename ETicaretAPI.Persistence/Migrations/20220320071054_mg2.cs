using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAPI.Persistence.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Tbl_Product",
                newName: "UpdatedTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Tbl_Product",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Tbl_Order",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Tbl_Order",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Tbl_Customer",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Tbl_Customer",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Tbl_Product");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Tbl_Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Tbl_Customer");

            migrationBuilder.RenameColumn(
                name: "UpdatedTime",
                table: "Tbl_Product",
                newName: "CreatedDate");
        }
    }
}
