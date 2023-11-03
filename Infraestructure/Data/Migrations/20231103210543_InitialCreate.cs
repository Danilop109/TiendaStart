using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //     migrationBuilder.AlterDatabase()
        //         .Annotation("MySql:CharSet", "utf8mb4");

        //     migrationBuilder.CreateTable(
        //         name: "driver",
        //         columns: table => new
        //         {
        //             Id = table.Column<int>(type: "int", nullable: false)
        //                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
        //             Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8mb4_0900_ai_ci")
        //                 .Annotation("MySql:CharSet", "utf8mb4"),
        //             Age = table.Column<int>(type: "int", nullable: true)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.Id);
        //         })
        //         .Annotation("MySql:CharSet", "utf8mb4")
        //         .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

        //     migrationBuilder.CreateTable(
        //         name: "team",
        //         columns: table => new
        //         {
        //             Id = table.Column<int>(type: "int", nullable: false)
        //                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
        //             Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
        //                 .Annotation("MySql:CharSet", "utf8mb4")
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.Id);
        //         })
        //         .Annotation("MySql:CharSet", "utf8mb4")
        //         .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

        //     migrationBuilder.CreateTable(
        //         name: "teamdriver",
        //         columns: table => new
        //         {
        //             IdTeamFk = table.Column<int>(type: "int", nullable: false),
        //             IdDriverFk = table.Column<int>(type: "int", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => new { x.IdTeamFk, x.IdDriverFk })
        //                 .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        //             table.ForeignKey(
        //                 name: "IdDriverFk",
        //                 column: x => x.IdDriverFk,
        //                 principalTable: "driver",
        //                 principalColumn: "Id");
        //             table.ForeignKey(
        //                 name: "IdTeamFk",
        //                 column: x => x.IdTeamFk,
        //                 principalTable: "team",
        //                 principalColumn: "Id");
        //         })
        //         .Annotation("MySql:CharSet", "utf8mb4")
        //         .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

        //     migrationBuilder.CreateIndex(
        //         name: "Name_UNIQUE",
        //         table: "team",
        //         column: "Name",
        //         unique: true);

        //     migrationBuilder.CreateIndex(
        //         name: "IdDriverFk_idx",
        //         table: "teamdriver",
        //         column: "IdDriverFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "teamdriver");

            // migrationBuilder.DropTable(
            //     name: "driver");

            // migrationBuilder.DropTable(
            //     name: "team");
        }
    }
}
