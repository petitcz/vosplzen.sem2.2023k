﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vosplzen.sem2._2023k.Data.Migrations
{
    /// <inheritdoc />
    public partial class initStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloodLevel = table.Column<int>(type: "int", nullable: false),
                    DroughtLevel = table.Column<int>(type: "int", nullable: false),
                    TimeOutInMinutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
