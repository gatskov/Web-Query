using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebQuery.Migrations
{
    /// <inheritdoc />
    public partial class InstallQuery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Вх_N = table.Column<string>(type: "text", nullable: false),
                    Заказчик = table.Column<string>(type: "text", nullable: false),
                    Предмет_запроса = table.Column<string>(type: "text", nullable: false),
                    Объект = table.Column<string>(type: "text", nullable: false),
                    Примечание = table.Column<string>(type: "text", nullable: false),
                    На_сервере = table.Column<string>(type: "text", nullable: false),
                    Реестр_ТКП = table.Column<string>(type: "text", nullable: false),
                    Ответственный = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
