using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountNo = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 1, null, new byte[] { 226, 90, 232, 54, 15, 6, 114, 129, 161, 32, 104, 61, 224, 76, 207, 152, 165, 105, 171, 13, 239, 211, 81, 105, 90, 14, 39, 48, 253, 63, 61, 22, 180, 147, 39, 138, 237, 101, 132, 180, 111, 162, 149, 115, 178, 219, 72, 166, 37, 97, 88, 226, 216, 71, 122, 196, 89, 198, 182, 162, 122, 193, 72, 237 }, new byte[] { 252, 5, 161, 178, 112, 65, 74, 254, 180, 194, 253, 132, 160, 134, 118, 228, 124, 233, 190, 240, 207, 75, 132, 6, 217, 99, 82, 235, 123, 100, 30, 128, 22, 149, 158, 207, 22, 223, 10, 100, 7, 185, 53, 10, 140, 216, 106, 8, 34, 88, 100, 7, 241, 187, 232, 68, 22, 69, 80, 91, 143, 218, 60, 87, 0, 2, 105, 167, 100, 130, 60, 61, 238, 146, 181, 207, 68, 227, 226, 87, 132, 125, 46, 120, 255, 199, 105, 187, 206, 24, 223, 73, 102, 113, 129, 225, 98, 168, 11, 89, 240, 94, 183, 150, 36, 214, 229, 15, 217, 224, 36, 239, 224, 175, 163, 136, 104, 190, 139, 16, 78, 215, 66, 185, 180, 175, 3, 92 }, "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 2, null, new byte[] { 226, 90, 232, 54, 15, 6, 114, 129, 161, 32, 104, 61, 224, 76, 207, 152, 165, 105, 171, 13, 239, 211, 81, 105, 90, 14, 39, 48, 253, 63, 61, 22, 180, 147, 39, 138, 237, 101, 132, 180, 111, 162, 149, 115, 178, 219, 72, 166, 37, 97, 88, 226, 216, 71, 122, 196, 89, 198, 182, 162, 122, 193, 72, 237 }, new byte[] { 252, 5, 161, 178, 112, 65, 74, 254, 180, 194, 253, 132, 160, 134, 118, 228, 124, 233, 190, 240, 207, 75, 132, 6, 217, 99, 82, 235, 123, 100, 30, 128, 22, 149, 158, 207, 22, 223, 10, 100, 7, 185, 53, 10, 140, 216, 106, 8, 34, 88, 100, 7, 241, 187, 232, 68, 22, 69, 80, 91, 143, 218, 60, 87, 0, 2, 105, 167, 100, 130, 60, 61, 238, 146, 181, 207, 68, 227, 226, 87, 132, 125, 46, 120, 255, 199, 105, 187, 206, 24, 223, 73, 102, 113, 129, 225, 98, 168, 11, 89, 240, 94, 183, 150, 36, 214, 229, 15, 217, 224, 36, 239, 224, 175, 163, 136, 104, 190, 139, 16, 78, 215, 66, 185, 180, 175, 3, 92 }, "Customer", "customer" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 1, "GR32882957347263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 73, DateTimeKind.Local).AddTicks(8154), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 35, "GR16632489265422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4965), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 36, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4967), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 37, "GR32882957227263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4969), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 38, "GR00324711152634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4971), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 39, "GR12309845325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4973), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 40, "GR12309845325299065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4975), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 41, "GR16632489222422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4977), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 42, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4979), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 43, "GR32882957457263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4981), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 44, "GR00324443252634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4984), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 45, "GR12309845325265400", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4986), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 46, "GR12309845325200065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4988), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 47, "GR16632489765422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4990), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 34, "GR12309845005290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4963), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 48, "GR72347888234865443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4992), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 50, "GR00324788852634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4996), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 51, "GR12309845885265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4998), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 52, "GR12309845388290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5001), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 53, "GR16632489265882345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5003), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 54, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5005), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 55, "GR32882957388263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5007), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 56, "GR00324783252004532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5009), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 57, "GR12309845112265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5011), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 58, "GR12309811325290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5013), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 59, "GR16632489261122345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5015), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 60, "GR72347888237765464", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5017), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 61, "GR12309845325265492", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5019), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 62, "GR12309845325290023", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5021), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 49, "GR32882988347263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4994), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 33, "GR12309845325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4960), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 32, "GR00324783992634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4958), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 31, "GR32882957347063523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4956), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 2, "GR00324783252634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4870), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 3, "GR12309848325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4894), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 4, "GR12309845325290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4898), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 5, "GR16632489265422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4900), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 6, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4903), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 7, "GR32882957367263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4905), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 8, "GR00324783252634032", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4907), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 9, "GR12309845325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4909), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 10, "GR12339845325290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4911), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 11, "GR16632489265422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4913), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 12, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4916), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 13, "GR32882957747263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4918), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 14, "GR00324783252631532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4920), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 15, "GR12309845325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4922), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 16, "GR12309845329290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4924), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 17, "GR16632489265422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4926), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 18, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4928), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 19, "GR32882957387263523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4930), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 20, "GR01324783252634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4932), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 21, "GR12309845325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4934), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 22, "GR12309845305290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4936), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 23, "GR16632489265422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4939), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 24, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4941), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 25, "GR32882957347293523", 5000.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4943), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 26, "GR00774783252634532", 18500.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4945), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 27, "GR12309845325265443", 25450.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4947), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 28, "GR12309840025290065", 13670.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4950), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 29, "GR16632489265422345", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4952), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 30, "GR72347888234265443", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(4954), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 63, "GR16632489265422388", 72344.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5023), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNo", "Amount", "CreatedAt", "UserId" },
                values: new object[] { 64, "GR72347888234265464", 2114.0, new DateTime(2021, 10, 4, 22, 9, 48, 75, DateTimeKind.Local).AddTicks(5068), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
