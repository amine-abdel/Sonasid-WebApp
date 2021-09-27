using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_SONASID.Migrations
{
    public partial class CreatSonacidDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Couronnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idicateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Non_Conforme = table.Column<int>(type: "int", nullable: false),
                    Derogeable = table.Column<int>(type: "int", nullable: false),
                    conforme = table.Column<int>(type: "int", nullable: false),
                    Moyenne = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couronnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fardeaux",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idicateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Non_Conforme = table.Column<int>(type: "int", nullable: false),
                    Derogeable = table.Column<int>(type: "int", nullable: false),
                    conforme = table.Column<int>(type: "int", nullable: false),
                    Moyenne = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fardeaux", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diametre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Min = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Max = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poste = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MLI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_ech = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    SP_EBOU = table.Column<int>(type: "int", nullable: false),
                    Mesures = table.Column<int>(type: "int", nullable: false),
                    MLDivMoy = table.Column<int>(type: "int", nullable: false),
                    Min = table.Column<int>(type: "int", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false),
                    Cible = table.Column<int>(type: "int", nullable: false),
                    Reduction = table.Column<float>(type: "real", nullable: false),
                    Conforme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MLI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MLII",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_ech = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    SP_EBOU = table.Column<int>(type: "int", nullable: false),
                    Mesures = table.Column<int>(type: "int", nullable: false),
                    MLDivMoy = table.Column<int>(type: "int", nullable: false),
                    Min = table.Column<int>(type: "int", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false),
                    Cible = table.Column<int>(type: "int", nullable: false),
                    Reduction = table.Column<float>(type: "real", nullable: false),
                    Conforme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MLII", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Couronnes");

            migrationBuilder.DropTable(
                name: "Fardeaux");

            migrationBuilder.DropTable(
                name: "HV");

            migrationBuilder.DropTable(
                name: "MLI");

            migrationBuilder.DropTable(
                name: "MLII");
        }
    }
}
