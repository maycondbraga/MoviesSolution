using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesWeb.Migrations
{
    public partial class InitialCreateLocalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
