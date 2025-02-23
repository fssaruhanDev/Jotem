using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jotem.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntityUpdateforAllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedUserID",
                schema: "dbo",
                table: "AuditLogs");

            migrationBuilder.RenameColumn(
                name: "UpdateUserID",
                schema: "dbo",
                table: "user",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                schema: "dbo",
                table: "user",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "dbo",
                table: "AuditLogs",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateUserID",
                schema: "dbo",
                table: "AuditLogs",
                newName: "UpdatedBy");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                schema: "dbo",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                schema: "dbo",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isModified",
                schema: "dbo",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                schema: "dbo",
                table: "AuditLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                schema: "dbo",
                table: "AuditLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isModified",
                schema: "dbo",
                table: "AuditLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                schema: "dbo",
                table: "user");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                schema: "dbo",
                table: "user");

            migrationBuilder.DropColumn(
                name: "isModified",
                schema: "dbo",
                table: "user");

            migrationBuilder.DropColumn(
                name: "isActive",
                schema: "dbo",
                table: "AuditLogs");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                schema: "dbo",
                table: "AuditLogs");

            migrationBuilder.DropColumn(
                name: "isModified",
                schema: "dbo",
                table: "AuditLogs");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "dbo",
                table: "user",
                newName: "UpdateUserID");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "user",
                newName: "CreatedUserID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "dbo",
                table: "AuditLogs",
                newName: "UpdateUserID");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "AuditLogs",
                newName: "UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUserID",
                schema: "dbo",
                table: "AuditLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
