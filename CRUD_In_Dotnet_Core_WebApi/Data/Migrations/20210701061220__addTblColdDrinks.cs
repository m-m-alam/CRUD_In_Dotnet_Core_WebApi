using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_In_Dotnet_Core_WebApi.Data.Migrations
{
    public partial class _addTblColdDrinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblColdDrinks",
                columns: table => new
                {
                    intColdDrinksId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strColdDrinksName = table.Column<string>(nullable: true),
                    numQuantity = table.Column<double>(nullable: false),
                    numUnitPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblColdDrinks", x => x.intColdDrinksId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblColdDrinks");
        }
    }
}
