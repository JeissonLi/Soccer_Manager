﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoccerManager.App.Persistencia;

namespace SoccerManager.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SoccerManager.App.Dominio.Campo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha_Horario_Final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Horario_Inicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abreviatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num_Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ciudadId")
                        .HasColumnType("int");

                    b.Property<int?>("generoId")
                        .HasColumnType("int");

                    b.Property<int?>("perfilId")
                        .HasColumnType("int");

                    b.Property<int?>("tipo_documentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ciudadId");

                    b.HasIndex("generoId");

                    b.HasIndex("perfilId");

                    b.HasIndex("tipo_documentoId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Tipo_Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abreviatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Documentos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Persona", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Ciudad", "ciudad")
                        .WithMany()
                        .HasForeignKey("ciudadId");

                    b.HasOne("SoccerManager.App.Dominio.Genero", "genero")
                        .WithMany()
                        .HasForeignKey("generoId");

                    b.HasOne("SoccerManager.App.Dominio.Perfil", "perfil")
                        .WithMany()
                        .HasForeignKey("perfilId");

                    b.HasOne("SoccerManager.App.Dominio.Tipo_Documento", "tipo_documento")
                        .WithMany()
                        .HasForeignKey("tipo_documentoId");

                    b.Navigation("ciudad");

                    b.Navigation("genero");

                    b.Navigation("perfil");

                    b.Navigation("tipo_documento");
                });
#pragma warning restore 612, 618
        }
    }
}
