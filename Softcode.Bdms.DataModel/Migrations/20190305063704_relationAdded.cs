using Microsoft.EntityFrameworkCore.Migrations;

namespace Softcode.Bdms.DataModel.Migrations
{
    public partial class relationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MarketingInquiry",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarketingInquiry_InstituteId",
                table: "MarketingInquiry",
                column: "InstituteId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketingInquiry_MarketSoftware_InstituteId",
                table: "MarketingInquiry",
                column: "InstituteId",
                principalTable: "MarketSoftware",
                principalColumn: "InstituteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketingInquiry_MarketSoftware_InstituteId",
                table: "MarketingInquiry");

            migrationBuilder.DropIndex(
                name: "IX_MarketingInquiry_InstituteId",
                table: "MarketingInquiry");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MarketingInquiry");
        }
    }
}
