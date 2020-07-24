using Microsoft.EntityFrameworkCore.Migrations;

namespace trash.Migrations
{
    public partial class changedcustomerModelForWeeklyPickUpDayToHaveStringDatattype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9524f2d7-9ec0-4de2-ad61-92707eaf585e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ef84ed-de18-40b0-8898-afa0e5843bcc");

            migrationBuilder.AlterColumn<string>(
                name: "WeeklyPickUpDay",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac413b73-78dd-4ead-aedb-a38f140abb86", "6c357d46-c890-4273-8b56-5286ab02c0e4", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2cd9db3-c628-492c-9357-87c53c57c634", "f5927be0-543a-4d9c-ac30-c10d3c8e9abf", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac413b73-78dd-4ead-aedb-a38f140abb86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2cd9db3-c628-492c-9357-87c53c57c634");

            migrationBuilder.AlterColumn<int>(
                name: "WeeklyPickUpDay",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8ef84ed-de18-40b0-8898-afa0e5843bcc", "3d4fe6e0-494e-412c-b6a5-6882635b4c26", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9524f2d7-9ec0-4de2-ad61-92707eaf585e", "9838e1d6-81ef-450e-9288-50153079c892", "Customer", "CUSTOMER" });
        }
    }
}
