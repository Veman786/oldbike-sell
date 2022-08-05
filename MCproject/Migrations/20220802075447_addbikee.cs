using Microsoft.EntityFrameworkCore.Migrations;

namespace MCproject.Migrations
{
    public partial class addbikee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_makes_makeid",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_models_modelsid",
                table: "Bikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bikes",
                table: "Bikes");

            migrationBuilder.RenameTable(
                name: "Bikes",
                newName: "bikes");

            migrationBuilder.RenameIndex(
                name: "IX_Bikes_modelsid",
                table: "bikes",
                newName: "IX_bikes_modelsid");

            migrationBuilder.RenameIndex(
                name: "IX_Bikes_makeid",
                table: "bikes",
                newName: "IX_bikes_makeid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bikes",
                table: "bikes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "bikeees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakeID = table.Column<int>(nullable: false),
                    ModelID = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Features = table.Column<string>(nullable: true),
                    SellerName = table.Column<string>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    currency = table.Column<string>(nullable: true),
                    Imagepath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bikeees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_bikeees_makes_MakeID",
                        column: x => x.MakeID,
                        principalTable: "makes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_bikeees_models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "models",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bikeees_MakeID",
                table: "bikeees",
                column: "MakeID");

            migrationBuilder.CreateIndex(
                name: "IX_bikeees_ModelID",
                table: "bikeees",
                column: "ModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_bikes_makes_makeid",
                table: "bikes",
                column: "makeid",
                principalTable: "makes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bikes_models_modelsid",
                table: "bikes",
                column: "modelsid",
                principalTable: "models",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bikes_makes_makeid",
                table: "bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_bikes_models_modelsid",
                table: "bikes");

            migrationBuilder.DropTable(
                name: "bikeees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bikes",
                table: "bikes");

            migrationBuilder.RenameTable(
                name: "bikes",
                newName: "Bikes");

            migrationBuilder.RenameIndex(
                name: "IX_bikes_modelsid",
                table: "Bikes",
                newName: "IX_Bikes_modelsid");

            migrationBuilder.RenameIndex(
                name: "IX_bikes_makeid",
                table: "Bikes",
                newName: "IX_Bikes_makeid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bikes",
                table: "Bikes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_makes_makeid",
                table: "Bikes",
                column: "makeid",
                principalTable: "makes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_models_modelsid",
                table: "Bikes",
                column: "modelsid",
                principalTable: "models",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
