﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Rotten_Potatoes.Api.Entity;

#nullable disable

namespace Rotten_Potatoes.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240522125129_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Rotten_Potatoes.Domain.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FilmeId"));

                    b.Property<string>("Categoria")
                        .HasColumnType("text");

                    b.Property<string>("Direcao")
                        .HasColumnType("text");

                    b.Property<string>("Duracao")
                        .HasColumnType("text");

                    b.Property<string>("Elenco")
                        .HasColumnType("text");

                    b.Property<string>("Lancamento")
                        .HasColumnType("text");

                    b.Property<string>("Resumo")
                        .HasColumnType("text");

                    b.Property<string>("Slide")
                        .HasColumnType("text");

                    b.Property<string>("Thumb")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.HasKey("FilmeId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Rotten_Potatoes.Domain.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<int?>("FilmeId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("ReviewId");

                    b.HasIndex("FilmeId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Rotten_Potatoes.Domain.Models.Review", b =>
                {
                    b.HasOne("Rotten_Potatoes.Domain.Models.Filme", null)
                        .WithMany("Reviews")
                        .HasForeignKey("FilmeId");
                });

            modelBuilder.Entity("Rotten_Potatoes.Domain.Models.Filme", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
