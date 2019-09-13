using Microsoft.EntityFrameworkCore.Migrations;

namespace prototipo.caliset.Migrations
{
    public partial class seagregarealaciondeoperacionconcomentario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_OperationId",
                table: "Comments",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Operations_OperationId",
                table: "Comments",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Operations_OperationId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_OperationId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "Comments");
        }
    }
}
