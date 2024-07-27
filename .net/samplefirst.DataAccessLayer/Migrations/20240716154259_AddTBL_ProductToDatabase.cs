using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace samplefirst.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addTBL_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                  name: "Products",
                  columns: table => new
                  {
                      ID = table.Column<int>(type: "int", nullable: false)
                          .Annotation("SqlServer:Identity", "1, 1"),
                      Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                      Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                      Price = table.Column<double>(type: "float", nullable: false),
                      ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                      CategoryID = table.Column<int>(type: "int", nullable: false),
                      CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                      ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                  },
                  constraints: table =>
                  {
                      table.PrimaryKey("PK_TBL_Product", x => x.ID);
                      table.ForeignKey(
                          name: "FK_TBL_Product_Categories_CategoryID",
                          column: x => x.CategoryID,
                          principalTable: "Categories",
                          principalColumn: "ID",
                          onDelete: ReferentialAction.Cascade);
                  });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
