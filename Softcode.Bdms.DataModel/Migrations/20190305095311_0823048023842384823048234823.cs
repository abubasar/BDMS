using Microsoft.EntityFrameworkCore.Migrations;

namespace Softcode.Bdms.DataModel.Migrations
{
    public partial class _0823048023842384823048234823 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketingInquiry_MarketSoftware_InstituteId",
                table: "MarketingInquiry");

            migrationBuilder.AlterColumn<int>(
                name: "InstituteId",
                table: "MarketingInquiry",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MarketingInquiry_MarketSoftware_InstituteId",
                table: "MarketingInquiry",
                column: "InstituteId",
                principalTable: "MarketSoftware",
                principalColumn: "InstituteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketingInquiry_MarketSoftware_InstituteId",
                table: "MarketingInquiry");

            migrationBuilder.AlterColumn<int>(
                name: "InstituteId",
                table: "MarketingInquiry",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MarketingInquiry_MarketSoftware_InstituteId",
                table: "MarketingInquiry",
                column: "InstituteId",
                principalTable: "MarketSoftware",
                principalColumn: "InstituteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
