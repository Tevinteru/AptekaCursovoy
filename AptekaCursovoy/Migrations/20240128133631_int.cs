using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace AptekaCursovoy.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Имя = table.Column<string>(type: "longtext", nullable: false),
                    Фамилия = table.Column<string>(type: "longtext", nullable: false),
                    Должность = table.Column<string>(type: "longtext", nullable: false),
                    ДатаРождения = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Адрес = table.Column<string>(type: "longtext", nullable: false),
                    Телефон = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Зарплата = table.Column<int>(type: "int", nullable: false),
                    Фото = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empoyee", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tovar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Название = table.Column<string>(type: "longtext", nullable: false),
                    Категория = table.Column<string>(type: "longtext", nullable: false),
                    Цена = table.Column<int>(type: "int", nullable: false),
                    Количество = table.Column<string>(type: "longtext", nullable: false),
                    Производитель = table.Column<string>(type: "longtext", nullable: false),
                    Поставщик = table.Column<string>(type: "longtext", nullable: false),
                    ДатаПоступления = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Описание = table.Column<string>(type: "longtext", nullable: false),
                    Фото = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tovar", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empoyee");

            migrationBuilder.DropTable(
                name: "Tovar");
        }
    }
}
