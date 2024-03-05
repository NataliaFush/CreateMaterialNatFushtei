using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CGST",
                table: "Taxes",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_TaxId",
                table: "Items",
                column: "TaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Taxes_TaxId",
                table: "Items",
                column: "TaxId",
                principalTable: "Taxes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Taxes_TaxId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_TaxId",
                table: "Items");

            migrationBuilder.AlterColumn<double>(
                name: "CGST",
                table: "Taxes",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
