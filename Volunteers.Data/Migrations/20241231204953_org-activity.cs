using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteers.Data.Migrations
{
    public partial class orgactivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Activities_OrgId",
                table: "Activities",
                column: "OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Orgs_OrgId",
                table: "Activities",
                column: "OrgId",
                principalTable: "Orgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Orgs_OrgId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_OrgId",
                table: "Activities");
        }
    }
}
