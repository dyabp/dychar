using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DyCompanyName.DyProjectName.Migrations
{
    public partial class AddedLanguageManagementModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DyabpLanguageCopies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResourceName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CultureName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", maxLength: 67108864, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DyabpLanguageCopies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DyabpLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CultureName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UiCultureName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    FlagIcon = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DyabpLanguages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DyabpLanguageCopies_TenantId_ResourceName_CultureName",
                table: "DyabpLanguageCopies",
                columns: new[] { "TenantId", "ResourceName", "CultureName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DyabpLanguageCopies");

            migrationBuilder.DropTable(
                name: "DyabpLanguages");
        }
    }
}
