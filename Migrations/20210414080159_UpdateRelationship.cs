using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_12_04.Migrations
{
    public partial class UpdateRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestDetail_Request_RequestID",
                table: "RequestDetail");

            migrationBuilder.AlterColumn<int>(
                name: "RequestID",
                table: "RequestDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestDetail_Request_RequestID",
                table: "RequestDetail",
                column: "RequestID",
                principalTable: "Request",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestDetail_Request_RequestID",
                table: "RequestDetail");

            migrationBuilder.AlterColumn<int>(
                name: "RequestID",
                table: "RequestDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestDetail_Request_RequestID",
                table: "RequestDetail",
                column: "RequestID",
                principalTable: "Request",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
