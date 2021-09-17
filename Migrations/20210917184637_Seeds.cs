using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFastReport.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 17, 18, 46, 36, 891, DateTimeKind.Utc).AddTicks(8771), "Combustivel", null },
                    { 2, new DateTime(2021, 9, 17, 18, 46, 36, 891, DateTimeKind.Utc).AddTicks(8786), "Lubrificantes", null },
                    { 3, new DateTime(2021, 9, 17, 18, 46, 36, 891, DateTimeKind.Utc).AddTicks(8789), "Diversos", null }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CreatedAt", "Email", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(4302), "sofia@gmail.com", "Sofia Porto", null },
                    { 2, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(4310), "leticia@gmail.com", "Leticia Barbosa", null },
                    { 3, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(4312), "bianca@gmail.com", "Bianca Kushisk", null }
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "CreatedAt", "Email", "Foto", "Nome", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2021, 9, 17, 18, 46, 36, 890, DateTimeKind.Utc).AddTicks(2872), "postocidade@gmail.com", "", "Posto de gasolina Monte Cidade", null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "CreatedAt", "Email", "Nome", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2888), "rodrigo@gmail.com", "Rodrigo Monte", null },
                    { 2, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2895), "flavia@gmail.com", "Flávia Monte", null },
                    { 3, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2897), "marcos@gmail.com", "Marcos Silva", null },
                    { 4, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2900), "helena@gmail.com", "Helena Santos", null },
                    { 5, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2902), "tiago@gmail.com", "Tiago Oliveira", null },
                    { 6, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2904), "jonas@gmail.com", "Jonas Madureira", null },
                    { 7, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(2906), "maria@gmail.com", "Maria Joaquina", null }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "CreatedAt", "Descricao", "Ean", "Preco", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(985), "Gasolina Aditivada", "2007040003594", 6.01m, null },
                    { 2, 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1382), "Gasolina Comum", "78989877383837", 5.51m, null },
                    { 3, 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1387), "Alcool Comum", "78945637385703", 4.47m, null },
                    { 4, 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1391), "Alcool Aditivado", "789456373834321", 4.89m, null },
                    { 5, 1, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1393), "Diesel", "78945637382273", 3.82m, null },
                    { 6, 2, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1395), "Óleo lubrificante Motor 20w", "7894563738266033", 23.50m, null },
                    { 7, 2, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1397), "Óleo lubrificante Motor 40w", "7894563738266711", 26.50m, null },
                    { 8, 3, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1399), "Água sem gás", "9874564564720", 2.00m, null },
                    { 9, 3, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(1402), "Água com gás", "9874564564721", 2.40m, null }
                });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "DataVenda", "Totalvenda", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2021, 9, 19, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(6543), new DateTime(2021, 9, 19, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(6424), 200.00m, null },
                    { 1, 2, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(5973), new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(5514), 100.00m, null },
                    { 2, 3, new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(6420), new DateTime(2021, 9, 17, 18, 46, 36, 892, DateTimeKind.Utc).AddTicks(6418), 75.00m, null }
                });

            migrationBuilder.InsertData(
                table: "VendaItens",
                columns: new[] { "Id", "CreatedAt", "ProdutoId", "Quantidade", "TotalProduto", "UpdatedAt", "ValorProduto", "VendaId" },
                values: new object[,]
                {
                    { 4, null, 5, 52.34m, 200.00m, null, 3.82m, 3 },
                    { 1, null, 2, 16.63m, 100.00m, null, 6.01m, 1 },
                    { 2, null, 1, 9.07m, 50.00m, null, 5.51m, 2 },
                    { 3, null, 9, 10.50m, 25.00m, null, 2.40m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VendaItens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VendaItens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VendaItens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VendaItens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vendas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
