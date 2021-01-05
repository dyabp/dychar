using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DyCompanyName.DyProjectName.Migrations
{
    public partial class LanguageAddTenantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "DyabpLanguages",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "DyabpLanguages");
        }
    }
}
