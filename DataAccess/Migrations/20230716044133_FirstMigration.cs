using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreedT",
                columns: table => new
                {
                    BreedId = table.Column<string>(maxLength: 50, nullable: false),
                    BreedName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedT", x => x.BreedId);
                });

            migrationBuilder.CreateTable(
                name: "GenderT",
                columns: table => new
                {
                    GenderId = table.Column<string>(maxLength: 50, nullable: false),
                    GenderName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderT", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "StatusT",
                columns: table => new
                {
                    StatusId = table.Column<string>(maxLength: 50, nullable: false),
                    StatusName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusT", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseT",
                columns: table => new
                {
                    WarehouseId = table.Column<string>(maxLength: 50, nullable: false),
                    Warehouse = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseT", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "AnimalsT",
                columns: table => new
                {
                    AnimalId = table.Column<string>(maxLength: 10, nullable: false),
                    AnimalName = table.Column<string>(maxLength: 100, nullable: false),
                    AnimalPrice = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    TotalQuantity = table.Column<int>(nullable: false),
                    BreedId = table.Column<string>(nullable: true),
                    GenderId = table.Column<string>(nullable: true),
                    StatusId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalsT", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_AnimalsT_BreedT_BreedId",
                        column: x => x.BreedId,
                        principalTable: "BreedT",
                        principalColumn: "BreedId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalsT_GenderT_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderT",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalsT_StatusT_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusT",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageT",
                columns: table => new
                {
                    StorageId = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    PartialQuantity = table.Column<int>(nullable: false),
                    AnimalId = table.Column<string>(nullable: true),
                    WarehouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageT", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_StorageT_AnimalsT_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "AnimalsT",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StorageT_WarehouseT_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "WarehouseT",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TradeT",
                columns: table => new
                {
                    TradeId = table.Column<string>(maxLength: 50, nullable: false),
                    TradeDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IsInput = table.Column<bool>(nullable: false),
                    StorageId = table.Column<string>(nullable: true),
                    StoragesStorageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeT", x => x.TradeId);
                    table.ForeignKey(
                        name: "FK_TradeT_StorageT_StoragesStorageId",
                        column: x => x.StoragesStorageId,
                        principalTable: "StorageT",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsT_BreedId",
                table: "AnimalsT",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsT_GenderId",
                table: "AnimalsT",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsT_StatusId",
                table: "AnimalsT",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageT_AnimalId",
                table: "StorageT",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageT_WarehouseId",
                table: "StorageT",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeT_StoragesStorageId",
                table: "TradeT",
                column: "StoragesStorageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TradeT");

            migrationBuilder.DropTable(
                name: "StorageT");

            migrationBuilder.DropTable(
                name: "AnimalsT");

            migrationBuilder.DropTable(
                name: "WarehouseT");

            migrationBuilder.DropTable(
                name: "BreedT");

            migrationBuilder.DropTable(
                name: "GenderT");

            migrationBuilder.DropTable(
                name: "StatusT");
        }
    }
}
