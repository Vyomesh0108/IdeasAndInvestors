﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeasAndInvestors.Migrations
{
    public partial class IdeasAndInvestorssecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ppassword",
                table: "PersonMasters",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ppassword",
                table: "PersonMasters",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
