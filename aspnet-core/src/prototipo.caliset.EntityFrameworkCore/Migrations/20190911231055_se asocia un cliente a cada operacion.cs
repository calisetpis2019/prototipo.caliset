using Microsoft.EntityFrameworkCore.Migrations;

namespace prototipo.caliset.Migrations
{
    public partial class seasociaunclienteacadaoperacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Operations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Operations_ClientId",
                table: "Operations",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Clients_ClientId",
                table: "Operations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Clients_ClientId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_ClientId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Operations");
        }
    }
}
