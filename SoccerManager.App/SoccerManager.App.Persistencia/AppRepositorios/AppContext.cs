using System;
using Microsoft.EntityFrameworkCore;
using SoccerManager.App.Dominio;

namespace SoccerManager.App.Persistencia
{
    public class AppContext : DbContext
    {
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Tipo_Documento> Tipos_Documentos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SoccerManager");
        }
    }
    }
}