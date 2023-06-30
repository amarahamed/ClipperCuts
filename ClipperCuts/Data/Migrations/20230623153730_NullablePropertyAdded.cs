using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClipperCuts.Data.Migrations
{
    public partial class NullablePropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingServices_Bookings_BookingID",
                table: "BookingServices");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "ServiceCarts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BookingID",
                table: "BookingServices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingServices_Bookings_BookingID",
                table: "BookingServices",
                column: "BookingID",
                principalTable: "Bookings",
                principalColumn: "BookingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingServices_Bookings_BookingID",
                table: "BookingServices");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "ServiceCarts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookingID",
                table: "BookingServices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingServices_Bookings_BookingID",
                table: "BookingServices",
                column: "BookingID",
                principalTable: "Bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
