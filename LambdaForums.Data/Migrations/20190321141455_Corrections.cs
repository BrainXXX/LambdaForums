using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LambdaForums.Data.Migrations
{
    public partial class Corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Context",
                table: "Posts",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Posts",
                newName: "Context");
        }
    }
}
