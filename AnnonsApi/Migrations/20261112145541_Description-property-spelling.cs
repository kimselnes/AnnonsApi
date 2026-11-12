using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnnonsApi.Migrations
{
    /// <inheritdoc />
    public partial class Descriptionpropertyspelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desciption",
                table: "Ads",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Ads",
                newName: "Desciption");
        }
    }
}
