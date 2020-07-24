using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace Restaurante.Infra.Data.Config
{
    public class RestauranteDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Refeicao> Refeicao { get; set; }
        public DbSet<Adicional> Adicional { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public RestauranteDbContext()
        {

        }
        public RestauranteDbContext(DbContextOptions<RestauranteDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var prop in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                if (prop.GetColumnType() == null)
                    prop.SetColumnType("varchar(255)");
            }

            //modelBuilder.ApplyConfiguration(new AlunoConfiguracao());
        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

        private string GetConnectionString()
        {
            return @"Data Source=191.232.55.193,8400;Initial Catalog=Restaurante;User ID=restaurante;Password=Aa123456";
        }
    }
}
