﻿// <auto-generated />
using MVC_SONASID.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_SONASID.Migrations
{
    [DbContext(typeof(SonacidDbContext))]
    partial class SonacidDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_SONASID.Models.COURONNES", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Derogeable")
                        .HasColumnType("int");

                    b.Property<string>("Idicateur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Moyenne")
                        .HasColumnType("float");

                    b.Property<int>("Non_Conforme")
                        .HasColumnType("int");

                    b.Property<int>("conforme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Couronnes");
                });

            modelBuilder.Entity("MVC_SONASID.Models.FARDEAUX", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Derogeable")
                        .HasColumnType("int");

                    b.Property<string>("Idicateur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Moyenne")
                        .HasColumnType("float");

                    b.Property<int>("Non_Conforme")
                        .HasColumnType("int");

                    b.Property<int>("conforme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fardeaux");
                });

            modelBuilder.Entity("Sonacid.Models.H_V", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diametre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Max")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Poste")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HV");
                });

            modelBuilder.Entity("Sonacid.Models.Masse_Lineique_I", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cible")
                        .HasColumnType("int");

                    b.Property<int>("Conforme")
                        .HasColumnType("int");

                    b.Property<int>("MLDivMoy")
                        .HasColumnType("int");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Mesures")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<int>("N_ech")
                        .HasColumnType("int");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.Property<float>("Reduction")
                        .HasColumnType("real");

                    b.Property<int>("SP_EBOU")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MLI");
                });

            modelBuilder.Entity("Sonacid.Models.Masse_Lineique_II", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cible")
                        .HasColumnType("int");

                    b.Property<int>("Conforme")
                        .HasColumnType("int");

                    b.Property<int>("MLDivMoy")
                        .HasColumnType("int");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Mesures")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<int>("N_ech")
                        .HasColumnType("int");

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.Property<float>("Reduction")
                        .HasColumnType("real");

                    b.Property<int>("SP_EBOU")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MLII");
                });
#pragma warning restore 612, 618
        }
    }
}