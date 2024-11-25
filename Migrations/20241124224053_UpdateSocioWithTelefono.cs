using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabajoFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSocioWithTelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Socios");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Socios",
                newName: "NumeroDeTelefono");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroDeTelefono",
                table: "Socios",
                newName: "Email");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Socios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
