using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Warehouse",
                table: "WarehouseT");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "WarehouseT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AnimalsT",
                columns: new[] { "AnimalId", "AnimalName", "AnimalPrice", "BreedId", "DateOfBirth", "GenderId", "StatusId", "TotalQuantity" },
                values: new object[,]
                {
                    { "BR5", "ButterCup", 4500, null, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "DR1", "Daisy", 1500, null, new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "CL3", "Clover", 3800, null, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "RS19", "Rocky", 3000, null, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "MH12", "Maisie", 2000, null, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "BP6", "Bella", 1400, null, new DateTime(2011, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "TW8", "Titan", 6400, null, new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "MR7", "Molly", 4700, null, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "HR14", "Hazel", 1200, null, new DateTime(2010, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "BS3", "Brutus", 6100, null, new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "MS21", "Maximus", 2800, null, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "AC23", "Aurora", 6600, null, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "AW25", "Atlas", 2300, null, new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "GR25", "Ginger", 2600, null, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "DH12", "Duke", 3600, null, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "DP20", "Delilah", 2000, null, new DateTime(2012, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "TL25", "Thor", 5100, null, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "LH6", "Lola", 2000, null, new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "TP13", "Tommy", 5200, null, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 },
                    { "MH28", "Maverick", 1400, null, new DateTime(2011, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "BreedT",
                columns: new[] { "BreedId", "BreedName" },
                values: new object[,]
                {
                    { "7e2f0744-d1f4-4a76-87b5-29fcf955871f", "Hereford" },
                    { "07d6ba26-26e4-4ae6-a664-965a1707e851", "Simmental" },
                    { "f2abeed2-df8e-45b5-b06e-9326ed16d211", "Charolais" },
                    { "5ed72cbc-1939-4b5c-957b-7e1135cabe9f", "Piedmontese" },
                    { "c1441ce2-3c84-425c-86aa-9cc9b95fc921", "Limousin" },
                    { "5d3aefe9-cdc1-4c48-8834-6a7003414ef1", "Red Angus" },
                    { "e030d28a-dea8-432d-b6be-62f1c7a623cb", "Watusi" }
                });

            migrationBuilder.InsertData(
                table: "GenderT",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { "640f9f68-79ca-4313-8ab8-f74f68a35fac", "Male" },
                    { "021abfd5-05a2-474d-837c-cf365d83c3f6", "Female" }
                });

            migrationBuilder.InsertData(
                table: "StatusT",
                columns: new[] { "StatusId", "StatusName" },
                values: new object[,]
                {
                    { "ad5e21e1-c205-44c7-811c-83681361611a", "Active" },
                    { "fdfa02da-c241-4acd-b71c-4f79727c29a7", "Inactive" }
                });

            migrationBuilder.InsertData(
                table: "WarehouseT",
                columns: new[] { "WarehouseId", "WarehouseName" },
                values: new object[,]
                {
                    { "f7c70d02-eb85-40a7-b7c9-13c25896ac52", "Available" },
                    { "b8903df6-7e9c-4f99-ae1f-c3f3b09fe4d8", "Sold" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "AC23");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "AW25");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "BP6");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "BR5");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "BS3");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "CL3");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "DH12");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "DP20");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "DR1");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "GR25");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "HR14");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "LH6");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "MH12");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "MH28");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "MR7");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "MS21");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "RS19");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "TL25");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "TP13");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "TW8");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "07d6ba26-26e4-4ae6-a664-965a1707e851");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "5d3aefe9-cdc1-4c48-8834-6a7003414ef1");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "5ed72cbc-1939-4b5c-957b-7e1135cabe9f");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "7e2f0744-d1f4-4a76-87b5-29fcf955871f");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "c1441ce2-3c84-425c-86aa-9cc9b95fc921");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "e030d28a-dea8-432d-b6be-62f1c7a623cb");

            migrationBuilder.DeleteData(
                table: "BreedT",
                keyColumn: "BreedId",
                keyValue: "f2abeed2-df8e-45b5-b06e-9326ed16d211");

            migrationBuilder.DeleteData(
                table: "GenderT",
                keyColumn: "GenderId",
                keyValue: "021abfd5-05a2-474d-837c-cf365d83c3f6");

            migrationBuilder.DeleteData(
                table: "GenderT",
                keyColumn: "GenderId",
                keyValue: "640f9f68-79ca-4313-8ab8-f74f68a35fac");

            migrationBuilder.DeleteData(
                table: "StatusT",
                keyColumn: "StatusId",
                keyValue: "ad5e21e1-c205-44c7-811c-83681361611a");

            migrationBuilder.DeleteData(
                table: "StatusT",
                keyColumn: "StatusId",
                keyValue: "fdfa02da-c241-4acd-b71c-4f79727c29a7");

            migrationBuilder.DeleteData(
                table: "WarehouseT",
                keyColumn: "WarehouseId",
                keyValue: "b8903df6-7e9c-4f99-ae1f-c3f3b09fe4d8");

            migrationBuilder.DeleteData(
                table: "WarehouseT",
                keyColumn: "WarehouseId",
                keyValue: "f7c70d02-eb85-40a7-b7c9-13c25896ac52");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "WarehouseT");

            migrationBuilder.AddColumn<string>(
                name: "Warehouse",
                table: "WarehouseT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
