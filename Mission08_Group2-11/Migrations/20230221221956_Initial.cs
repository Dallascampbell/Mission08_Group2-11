using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission08_Group2_11.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    DueDate = table.Column<string>(nullable: true),
                    Quadrant = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 1, 1, false, "2/31/23", 2, "Do the dishes" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 2, 2, true, "3/01/23", 1, "Take Midterm" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 3, 3, false, "3/04/23", 3, "Respond to Coworker's email" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 4, 4, false, "3/15/23", 4, "Get lollipop from Bishop's office" });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryID",
                table: "Responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
