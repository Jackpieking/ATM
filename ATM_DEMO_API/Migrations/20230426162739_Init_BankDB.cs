using Microsoft.EntityFrameworkCore.Migrations;


namespace ATM_DEMO_API.Migrations;

public partial class Init_BankDB : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "BankUserInfo",
            columns: table => new
            {
                CardID = table.Column<string>(type: "VARCHAR(19)", nullable: false),
                Name = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                Money = table.Column<decimal>(type: "DECIMAL(12,0)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_BankUserInfo", x => x.CardID);
            });

        migrationBuilder.CreateTable(
            name: "BankUserLoginInfo",
            columns: table => new
            {
                CardID = table.Column<string>(type: "VARCHAR(19)", nullable: false),
                PIN = table.Column<string>(type: "VARCHAR(6)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_BankUserLoginInfo", x => x.CardID);
                table.ForeignKey(
                    name: "FK_BankUserLoginInfo_BankUserInfo_CardID",
                    column: x => x.CardID,
                    principalTable: "BankUserInfo",
                    principalColumn: "CardID",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.InsertData(
            table: "BankUserInfo",
            columns: new[] { "CardID", "Money", "Name" },
            values: new object[] { "4122-8934-5678-9010", 10000000m, "Le Thanh" });

        migrationBuilder.InsertData(
            table: "BankUserLoginInfo",
            columns: new[] { "CardID", "PIN" },
            values: new object[] { "4122-8934-5678-9010", "654321" });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "BankUserLoginInfo");

        migrationBuilder.DropTable(
            name: "BankUserInfo");
    }
}
