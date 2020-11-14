using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Anna_.Migrations
{
    public partial class Data1311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Check_in_date = table.Column<DateTime>(nullable: false),
                    Check_out_date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    RoomID = table.Column<long>(nullable: true),
                    EmployeeID = table.Column<long>(nullable: true),
                    Service1ID = table.Column<long>(nullable: true),
                    Service2ID = table.Column<long>(nullable: true),
                    Service3ID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Appellation = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Capacity = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<long>(nullable: true),
                    ClientsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rooms_Clients_ClientsID",
                        column: x => x.ClientsID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Appellation = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ClientsID = table.Column<long>(nullable: true),
                    ClientsID1 = table.Column<long>(nullable: true),
                    ClientsID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_Clients_ClientsID",
                        column: x => x.ClientsID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_Clients_ClientsID1",
                        column: x => x.ClientsID1,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_Clients_ClientsID2",
                        column: x => x.ClientsID2,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    PositionID = table.Column<long>(nullable: true),
                    ClientsID = table.Column<long>(nullable: true),
                    RoomsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Clients_ClientsID",
                        column: x => x.ClientsID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Rooms_RoomsID",
                        column: x => x.RoomsID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duties = table.Column<string>(nullable: true),
                    Name_of_the_position = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Requirements = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positions_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ClientsID",
                table: "Employee",
                column: "ClientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RoomsID",
                table: "Employee",
                column: "RoomsID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EmployeeID",
                table: "Positions",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ClientsID",
                table: "Rooms",
                column: "ClientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ClientsID",
                table: "Services",
                column: "ClientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ClientsID1",
                table: "Services",
                column: "ClientsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ClientsID2",
                table: "Services",
                column: "ClientsID2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
