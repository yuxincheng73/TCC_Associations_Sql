using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCAssociation.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Associations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    name_tc = table.Column<string>(nullable: true),
                    name_sc = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    description_tc = table.Column<string>(nullable: true),
                    description_sc = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    url_tc = table.Column<string>(nullable: true),
                    url_sc = table.Column<string>(nullable: true),
                    logo = table.Column<string>(nullable: true),
                    discoverable = table.Column<bool>(nullable: false),
                    sorting_order = table.Column<int>(nullable: false),
                    launch_date = table.Column<DateTime>(nullable: false),
                    time_zone = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    deleted_at = table.Column<DateTime>(nullable: true),
                    is_deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associations");
        }
    }
}
