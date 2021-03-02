using Microsoft.EntityFrameworkCore.Migrations;

namespace torch.database.Migrations
{
    public partial class NullableState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_States_stateId",
                table: "Organizations");

            migrationBuilder.AlterColumn<int>(
                name: "stateId",
                table: "Organizations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_States_stateId",
                table: "Organizations",
                column: "stateId",
                principalTable: "States",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_States_stateId",
                table: "Organizations");

            migrationBuilder.AlterColumn<int>(
                name: "stateId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_States_stateId",
                table: "Organizations",
                column: "stateId",
                principalTable: "States",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
