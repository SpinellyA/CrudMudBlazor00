using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudMudBlazor.Migrations
{
    /// <inheritdoc />
    public partial class MigrationTest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parties_PartyTypes_PartyTypeId",
                table: "Parties");

            migrationBuilder.DropIndex(
                name: "IX_Parties_PartyTypeId",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "PartyTypeId",
                table: "Parties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartyTypeId",
                table: "Parties",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parties_PartyTypeId",
                table: "Parties",
                column: "PartyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parties_PartyTypes_PartyTypeId",
                table: "Parties",
                column: "PartyTypeId",
                principalTable: "PartyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
