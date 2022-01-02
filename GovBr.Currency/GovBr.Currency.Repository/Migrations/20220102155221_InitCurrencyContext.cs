using Microsoft.EntityFrameworkCore.Migrations;

namespace GovBr.Currency.Repository.Migrations
{
    public partial class InitCurrencyContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    Country = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Country);
                });

            migrationBuilder.InsertData(
                table: "Exchanges",
                columns: new[] { "Country", "Code", "Currency", "Number" },
                values: new object[] { "ÍNDIA", "INR", "Rupia indiana", 356 });

            migrationBuilder.InsertData(
                table: "Exchanges",
                columns: new[] { "Country", "Code", "Currency", "Number" },
                values: new object[] { "ÁUSTRIA", "EUR", "Euro", 978 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exchanges");
        }
    }
}
