using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softcode.Bdms.DataModel.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketingStatus",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingStatus", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "MarketSoftware",
                columns: table => new
                {
                    InstituteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mkid = table.Column<string>(nullable: true),
                    MarketName = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DecisionMaker = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Rdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketSoftware", x => x.InstituteId);
                    table.ForeignKey(
                        name: "FK_MarketSoftware_MarketingStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "MarketingStatus",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketSoftware_StatusId",
                table: "MarketSoftware",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketSoftware");

            migrationBuilder.DropTable(
                name: "MarketingStatus");
        }
    }
}
