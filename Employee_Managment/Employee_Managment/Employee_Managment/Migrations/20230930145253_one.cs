using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Managment.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicAndDA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    PresentDays = table.Column<int>(type: "int", nullable: false),
                    AbsentDays = table.Column<int>(type: "int", nullable: false),
                    SundayHoliday = table.Column<int>(type: "int", nullable: false),
                    CL = table.Column<int>(type: "int", nullable: false),
                    TotalPayableDays = table.Column<int>(type: "int", nullable: false),
                    PayableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfessionalTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ESIC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtraDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmountPayable = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
