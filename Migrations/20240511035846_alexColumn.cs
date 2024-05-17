using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATEC_API_Sample.Migrations
{
    /// <inheritdoc />
    public partial class alexColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alex_Palautos",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alex_Palautos",
                table: "Users");
        }
    }
}
