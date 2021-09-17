using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFastReport.Migrations
{
    public partial class Cliente_Change_VendaItem_for_venda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaItens_Clientes_ClienteEntityId",
                table: "VendaItens");

            migrationBuilder.DropIndex(
                name: "IX_VendaItens_ClienteEntityId",
                table: "VendaItens");

            migrationBuilder.DropColumn(
                name: "ClienteEntityId",
                table: "VendaItens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteEntityId",
                table: "VendaItens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VendaItens_ClienteEntityId",
                table: "VendaItens",
                column: "ClienteEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaItens_Clientes_ClienteEntityId",
                table: "VendaItens",
                column: "ClienteEntityId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
