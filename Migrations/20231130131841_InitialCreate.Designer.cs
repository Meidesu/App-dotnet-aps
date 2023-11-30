﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apsdotnet.Models;

#nullable disable

namespace apsdotnet.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231130131841_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("apsdotnet.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("apsdotnet.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("apsdotnet.Models.Aluno", b =>
                {
                    b.HasBaseType("apsdotnet.Models.Pessoa");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Aluno");
                });

            modelBuilder.Entity("apsdotnet.Models.Professor", b =>
                {
                    b.HasBaseType("apsdotnet.Models.Pessoa");

                    b.Property<string>("Formacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Salario")
                        .HasColumnType("double");

                    b.HasDiscriminator().HasValue("Professor");
                });
#pragma warning restore 612, 618
        }
    }
}
