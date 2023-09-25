using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoostEntityFrameworkUygulamaMaraton.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albümler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbümAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbümSanatciGrup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbümCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbümFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AlbümIndirimOrani = table.Column<int>(type: "int", nullable: false),
                    AlbümSatisDevamliligi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albümler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yoneticiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YoneticiKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YoneticiSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoneticiler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albümler");

            migrationBuilder.DropTable(
                name: "Yoneticiler");
        }
    }
}
