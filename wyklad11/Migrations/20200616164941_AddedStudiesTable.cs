using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wyklad11.Migrations
{
    public partial class AddedStudiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    IdStudies = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.IdStudies);
                });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudies", "Description", "Name" },
                values: new object[] { 1, "AAA", "IT" });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudies", "Description", "Name" },
                values: new object[] { 2, "BBB", "Graphic Design" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studies");
        }
    }
}
