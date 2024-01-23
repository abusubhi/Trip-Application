using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepTrips.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitilyzationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addriss = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessSeats = table.Column<int>(type: "int", nullable: false),
                    EconomySeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plane = table.Column<int>(type: "int", nullable: false),
                    TripFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PriceOfEconomy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceOfBusiness = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlanesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Planes_PlanesId",
                        column: x => x.PlanesId,
                        principalTable: "Planes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TripReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PlaneId = table.Column<int>(type: "int", nullable: false),
                    TripStatusId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    TripTypesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripReservations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripReservations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripReservations_Planes_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripReservations_TripStatuses_TripStatusId",
                        column: x => x.TripStatusId,
                        principalTable: "TripStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripReservations_TripTypes_TripTypesId",
                        column: x => x.TripTypesId,
                        principalTable: "TripTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TripReservations_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripReservations_ClientId",
                table: "TripReservations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReservations_CountryId",
                table: "TripReservations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReservations_PlaneId",
                table: "TripReservations",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReservations_TripId",
                table: "TripReservations",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReservations_TripStatusId",
                table: "TripReservations",
                column: "TripStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReservations_TripTypesId",
                table: "TripReservations",
                column: "TripTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_PlanesId",
                table: "Trips",
                column: "PlanesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripReservations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "TripStatuses");

            migrationBuilder.DropTable(
                name: "TripTypes");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
