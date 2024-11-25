using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabajoFinal.Migrations
{
    /// <inheritdoc />
    public partial class NombreDeLaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuposDisponibles",
                table: "Clases");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuposDisponibles",
                table: "Clases",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
