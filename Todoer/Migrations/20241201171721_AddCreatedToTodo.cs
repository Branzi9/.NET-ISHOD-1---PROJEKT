﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todoer.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedToTodo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "dateOnly",
                table: "Todo",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateOnly",
                table: "Todo");
        }
    }
}
