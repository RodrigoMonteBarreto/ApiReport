using System;
using ApiFastReport.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApiFastReport.Data
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<EmpresaEntity> Empresas { get; set; }
        public DbSet<CategoriaEntity> Categorias { get; set; }
        public DbSet<ProdutoEntity> Produtos { get; set; }
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<VendaEntity> Vendas { get; set; }
        public DbSet<VendaItemEntity> VendaItens { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmpresaEntity>().HasData(
                new EmpresaEntity
                {
                    Id = 1,
                    Nome = "Posto de gasolina Monte Cidade",
                    Email = "postocidade@gmail.com",
                    Foto = "",
                    CreatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<CategoriaEntity>().HasData(
                new CategoriaEntity
                {
                    Id = 1,
                    Descricao = "Combustivel",
                    CreatedAt = DateTime.UtcNow
                },
                new CategoriaEntity
                {
                    Id = 2,
                    Descricao = "Lubrificantes",
                    CreatedAt = DateTime.UtcNow
                },
                 new CategoriaEntity
                 {
                     Id = 3,
                     Descricao = "Diversos",
                     CreatedAt = DateTime.UtcNow
                 }
            );

            modelBuilder.Entity<ProdutoEntity>().HasData(
                new ProdutoEntity
                {
                    Id = 1,
                    Descricao = "Gasolina Aditivada",
                    Ean = "2007040003594",
                    Preco = 6.01m,
                    CreatedAt = DateTime.UtcNow,
                    CategoriaId = 1
                },
                 new ProdutoEntity
                 {
                     Id = 2,
                     Descricao = "Gasolina Comum",
                     Ean = "78989877383837",
                     Preco = 5.51m,
                     CreatedAt = DateTime.UtcNow,
                     CategoriaId = 1
                 },
                  new ProdutoEntity
                  {
                      Id = 3,
                      Descricao = "Alcool Comum",
                      Ean = "78945637385703",
                      Preco = 4.47m,
                      CreatedAt = DateTime.UtcNow,
                      CategoriaId = 1
                  },
                  new ProdutoEntity
                  {
                      Id = 4,
                      Descricao = "Alcool Aditivado",
                      Ean = "789456373834321",
                      Preco = 4.89m,
                      CreatedAt = DateTime.UtcNow,
                      CategoriaId = 1
                  },
                  new ProdutoEntity
                  {
                      Id = 5,
                      Descricao = "Diesel",
                      Ean = "78945637382273",
                      Preco = 3.82m,
                      CreatedAt = DateTime.UtcNow,
                      CategoriaId = 1
                  },
                   new ProdutoEntity
                   {
                       Id = 6,
                       Descricao = "Óleo lubrificante Motor 20w",
                       Ean = "7894563738266033",
                       Preco = 23.50m,
                       CreatedAt = DateTime.UtcNow,
                       CategoriaId = 2
                   },
                    new ProdutoEntity
                    {
                        Id = 7,
                        Descricao = "Óleo lubrificante Motor 40w",
                        Ean = "7894563738266711",
                        Preco = 26.50m,
                        CreatedAt = DateTime.UtcNow,
                        CategoriaId = 2
                    },
                     new ProdutoEntity
                     {
                         Id = 8,
                         Descricao = "Água sem gás",
                         Ean = "9874564564720",
                         Preco = 2.00m,
                         CreatedAt = DateTime.UtcNow,
                         CategoriaId = 3
                     },
                     new ProdutoEntity
                     {
                         Id = 9,
                         Descricao = "Água com gás",
                         Ean = "9874564564721",
                         Preco = 2.40m,
                         CreatedAt = DateTime.UtcNow,
                         CategoriaId = 3
                     }
            );

            modelBuilder.Entity<UsuarioEntity>().HasData(
                new UsuarioEntity
                {
                    Id = 1,
                    Nome = "Rodrigo Monte",
                    Email = "rodrigo@gmail.com",
                    CreatedAt = DateTime.UtcNow
                },
                 new UsuarioEntity
                 {
                     Id = 2,
                     Nome = "Flávia Monte",
                     Email = "flavia@gmail.com",
                     CreatedAt = DateTime.UtcNow
                 },
                 new UsuarioEntity
                 {
                     Id = 3,
                     Nome = "Marcos Silva",
                     Email = "marcos@gmail.com",
                     CreatedAt = DateTime.UtcNow
                 },
                 new UsuarioEntity
                 {
                     Id = 4,
                     Nome = "Helena Santos",
                     Email = "helena@gmail.com",
                     CreatedAt = DateTime.UtcNow
                 },
                 new UsuarioEntity
                 {
                     Id = 5,
                     Nome = "Tiago Oliveira",
                     Email = "tiago@gmail.com",
                     CreatedAt = DateTime.UtcNow
                 },
                 new UsuarioEntity
                 {
                     Id = 6,
                     Nome = "Jonas Madureira",
                     Email = "jonas@gmail.com",
                     CreatedAt = DateTime.UtcNow
                 },
                 new UsuarioEntity
                 {
                     Id = 7,
                     Nome = "Maria Joaquina",
                     Email = "maria@gmail.com",
                     CreatedAt = DateTime.UtcNow
                 }
            );

            modelBuilder.Entity<ClienteEntity>().HasData(
                    new ClienteEntity
                    {
                        Id = 1,
                        Nome = "Sofia Porto",
                        Email = "sofia@gmail.com",
                        CreatedAt = DateTime.UtcNow
                    },
                     new ClienteEntity
                     {
                         Id = 2,
                         Nome = "Leticia Barbosa",
                         Email = "leticia@gmail.com",
                         CreatedAt = DateTime.UtcNow
                     },
                      new ClienteEntity
                      {
                          Id = 3,
                          Nome = "Bianca Kushisk",
                          Email = "bianca@gmail.com",
                          CreatedAt = DateTime.UtcNow
                      }
            );

            modelBuilder.Entity<VendaEntity>().HasData(
                new VendaEntity
                {
                    Id = 1,
                    ClienteId = 2,
                    DataVenda = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    Totalvenda = 100.00m
                },
                 new VendaEntity
                 {
                     Id = 2,
                     ClienteId = 3,
                     DataVenda = DateTime.UtcNow,
                     CreatedAt = DateTime.UtcNow,
                     Totalvenda = 75.00m
                 },
                 new VendaEntity
                 {
                     Id = 3,
                     ClienteId = 1,
                     DataVenda = DateTime.UtcNow.AddDays(2),
                     CreatedAt = DateTime.UtcNow.AddDays(2),
                     Totalvenda = 200.00m
                 }
            );

            modelBuilder.Entity<VendaItemEntity>().HasData(
                new VendaItemEntity
                {
                    Id = 1,
                    ProdutoId = 2,
                    VendaId = 1,
                    Quantidade = 16.63m,
                    ValorProduto = 6.01m,
                    TotalProduto = 100.00m
                },
                 new VendaItemEntity
                 {
                     Id = 2,
                     ProdutoId = 1,
                     VendaId = 2,
                     Quantidade = 9.07m,
                     ValorProduto = 5.51m,
                     TotalProduto = 50.00m
                 },
                  new VendaItemEntity
                  {
                      Id = 3,
                      ProdutoId = 9,
                      VendaId = 2,
                      Quantidade = 10.50m,
                      ValorProduto = 2.40m,
                      TotalProduto = 25.00m
                  },
                   new VendaItemEntity
                   {
                       Id = 4,
                       ProdutoId = 5,
                       VendaId = 3,
                       Quantidade = 52.34m,
                       ValorProduto = 3.82m,
                       TotalProduto = 200.00m
                   }

            );
        }
    }
}