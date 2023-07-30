using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAbpProject6.Migrations
{
    public partial class AddNewEntity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                schema: "PB",
                table: "PhoneNumber",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                schema: "PB",
                table: "PhoneNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneType",
                schema: "PB",
                table: "PhoneNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "PB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                schema: "PB",
                table: "PhoneNumber",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                schema: "PB",
                table: "PhoneNumber",
                column: "PersonId",
                principalSchema: "PB",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "PB");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_PersonId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "Number",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "PersonId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "PhoneType",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "PB",
                table: "PhoneNumber",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                schema: "PB",
                table: "PhoneNumber",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "PB",
                table: "PhoneNumber",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_PhoneNumber_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "PB",
                        principalTable: "PhoneNumber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumber",
                column: "PersonId");
        }
    }
}
