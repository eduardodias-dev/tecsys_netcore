using Microsoft.EntityFrameworkCore.Migrations;

namespace Website_TecSys_NetCore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Chave = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracoes");
        }
    }
}
