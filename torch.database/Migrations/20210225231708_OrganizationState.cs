using Microsoft.EntityFrameworkCore.Migrations;

namespace torch.database.Migrations
{
    public partial class OrganizationState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Organizations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2",
                table: "Organizations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Organizations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Organizations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Organizations",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stateId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "zip",
                table: "Organizations",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_stateId",
                table: "Organizations",
                column: "stateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_States_stateId",
                table: "Organizations",
                column: "stateId",
                principalTable: "States",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_States_stateId",
                table: "Organizations");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_stateId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "address2",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "stateId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "zip",
                table: "Organizations");
        }
    }
}
