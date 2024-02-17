using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiChamados.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CalledStatusId",
                table: "Called",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Called",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Called",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "Called",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Called",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Called",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CalledStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalledStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Called_CalledStatusId",
                table: "Called",
                column: "CalledStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Called_CalledStatus_CalledStatusId",
                table: "Called",
                column: "CalledStatusId",
                principalTable: "CalledStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Called_CalledStatus_CalledStatusId",
                table: "Called");

            migrationBuilder.DropTable(
                name: "CalledStatus");

            migrationBuilder.DropIndex(
                name: "IX_Called_CalledStatusId",
                table: "Called");

            migrationBuilder.DropColumn(
                name: "CalledStatusId",
                table: "Called");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Called");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Called");

            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "Called");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Called");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Called");
        }
    }
}
