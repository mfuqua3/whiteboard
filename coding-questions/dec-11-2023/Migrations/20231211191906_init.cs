using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityConfigurations.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HolidayName = table.Column<string>(type: "text", nullable: true),
                    HolidayDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationHolidays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    HolidayId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationHolidays_Holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "Holidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationHolidays_MerchantLocations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "MerchantLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationHolidays_HolidayId",
                table: "LocationHolidays",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationHolidays_LocationId",
                table: "LocationHolidays",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationHolidays");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "MerchantLocations");
        }
    }
}
