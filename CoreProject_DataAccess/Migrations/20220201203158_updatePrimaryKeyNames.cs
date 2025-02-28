﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProject_DataAccess.Migrations
{
    public partial class updatePrimaryKeyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "Publishers",
                newName: "Publisher_Id");

            migrationBuilder.RenameColumn(
                name: "Publisher_Id",
                table: "Authors",
                newName: "Author_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publisher_Id",
                table: "Publishers",
                newName: "Author_Id");

            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "Authors",
                newName: "Publisher_Id");
        }
    }
}
