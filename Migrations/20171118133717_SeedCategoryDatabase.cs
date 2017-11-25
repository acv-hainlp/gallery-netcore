using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace gallerynetcore.Migrations
{
    public partial class SeedCategoryDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Title) VALUES ('Illustration')");
            migrationBuilder.Sql("INSERT INTO Categories (Title) VALUES ('UX/UI Design')");
            migrationBuilder.Sql("INSERT INTO Categories (Title) VALUES ('Background')");
            migrationBuilder.Sql("INSERT INTO Categories (Title) VALUES ('Other Work')");
            
            // migrationBuilder.Sql("INSERT INTO Posts (timestamp,title,isActive,CategoryId) VALUES ('22021991','Post1','1', '1')");
            // migrationBuilder.Sql("INSERT INTO Posts (timestamp,title,isActive, CategoryId) VALUES ('2312312','Post2','1', '2')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
