using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softcode.Bdms.DataModel.Migrations
{
    public partial class MarketingInquiryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketingInquiry",
                columns: table => new
                {
                    InquiryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InquiryDate = table.Column<DateTime>(nullable: true),
                    InstituteId = table.Column<int>(nullable: false),
                    InquiryContactPerson = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FurtherContactType = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingInquiry", x => x.InquiryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketingInquiry");
        }
    }
}
