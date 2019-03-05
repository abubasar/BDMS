using Microsoft.EntityFrameworkCore.Migrations;

namespace Softcode.Bdms.DataModel.Migrations
{
    public partial class addedbaseentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MarketSoftware",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MarketingStatus",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MarketSoftware");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MarketingStatus");
        }
    }
}
