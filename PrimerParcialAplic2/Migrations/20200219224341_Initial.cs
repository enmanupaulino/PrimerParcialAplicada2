using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcialAplic2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inscripciones",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Semestre = table.Column<string>(nullable: true),
                    Limite = table.Column<int>(nullable: false),
                    Tomado = table.Column<int>(nullable: false),
                    Disponible = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripciones", x => x.InscripcionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inscripciones");
        }
    }
}
