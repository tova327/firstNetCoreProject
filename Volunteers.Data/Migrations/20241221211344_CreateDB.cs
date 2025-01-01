using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Volunteers.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conditions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeededVolunteers = table.Column<int>(type: "int", nullable: false),
                    ExistVolunteers = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    OrgId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldOfActivity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfVolunteers = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conditions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    HeadAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    PhoneToContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    LovedBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permissions = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerInActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    MonthParticipate = table.Column<int>(type: "int", nullable: false),
                    ManagerSatisfaction = table.Column<int>(type: "int", nullable: false),
                    VolunteerSatisfaction = table.Column<int>(type: "int", nullable: false),
                    LogIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BringMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerInActivities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Orgs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VolunteerInActivities");
        }
    }
}
