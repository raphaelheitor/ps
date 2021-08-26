using Microsoft.EntityFrameworkCore.Migrations;

namespace PremierTest.Infra.Data.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Avengers" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Matricula", "Nome", "Password", "Perfil" },
                values: new object[,]
                {
                    { 1, "12345", "Spider Man", "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", "colaborador" },
                    { 2, "54321", "Doctor Strange", "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", "colaborador" },
                    { 3, "111", "Ironman", "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", "gestor" }
                });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "Id", "EquipeId", "Nome" },
                values: new object[] { 1, null, "Infinite War" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
