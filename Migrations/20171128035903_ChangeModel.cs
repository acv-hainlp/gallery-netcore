using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gallerynetcore.Migrations
{
    public partial class ChangeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "timestamp",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Posts",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Posts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "coverUrl",
                table: "Posts",
                newName: "CoverUrl");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Categories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Categories",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateOn",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateOn",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Posts",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Posts",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CoverUrl",
                table: "Posts",
                newName: "coverUrl");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "description");

            migrationBuilder.AddColumn<int>(
                name: "timestamp",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
