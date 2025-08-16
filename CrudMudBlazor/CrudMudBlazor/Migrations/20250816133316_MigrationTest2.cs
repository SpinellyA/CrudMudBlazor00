using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudMudBlazor.Migrations
{
    /// <inheritdoc />
    public partial class MigrationTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "FoundingDate",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "OfficialName",
                table: "Parties");

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    PartyId = table.Column<int>(type: "integer", nullable: false),
                    OfficialName = table.Column<string>(type: "text", nullable: false),
                    FoundingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.PartyId);
                    table.ForeignKey(
                        name: "FK_Organization_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PartyId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PartyId);
                    table.ForeignKey(
                        name: "FK_Person_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Parties",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Parties",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Parties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FoundingDate",
                table: "Parties",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Parties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficialName",
                table: "Parties",
                type: "text",
                nullable: true);
        }
    }
}
