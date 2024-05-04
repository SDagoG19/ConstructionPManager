﻿// <auto-generated />
using System;
using Manager.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Manager.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240502234523_Rela")]
    partial class Rela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Manager.Share.Entities.Equipos_Construccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especialidades")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ListaMiembros")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Equipo_Construccion");
                });

            modelBuilder.Entity("Manager.Share.Entities.Equipos_Proy_Construccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("equiposId")
                        .HasColumnType("int");

                    b.Property<int?>("proyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("equiposId");

                    b.HasIndex("proyectoId");

                    b.ToTable("proy_Construccions");
                });

            modelBuilder.Entity("Manager.Share.Entities.Maquinaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("capacidad")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("disponibilidad")
                        .HasColumnType("bit");

                    b.Property<string>("estadoMantenimiento")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("maquinaria");
                });

            modelBuilder.Entity("Manager.Share.Entities.MaquinariaTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaquinariaId")
                        .HasColumnType("int");

                    b.Property<int?>("TareaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaquinariaId");

                    b.HasIndex("TareaId");

                    b.ToTable("maquinariaTareas");
                });

            modelBuilder.Entity("Manager.Share.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("deliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("materialName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("materialStock")
                        .HasColumnType("int");

                    b.Property<string>("proveedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("Manager.Share.Entities.MaterialTarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("TareaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("TareaId");

                    b.ToTable("MaterialTareas");
                });

            modelBuilder.Entity("Manager.Share.Entities.Presupuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ManoObra")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Maquinaria")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Materiales")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Presupuesto");
                });

            modelBuilder.Entity("Manager.Share.Entities.Proyecto_Construccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PresupuestoId")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PresupuestoId");

                    b.ToTable("Proyectos_Construccion");
                });

            modelBuilder.Entity("Manager.Share.Entities.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProyectoDeConstruccionId")
                        .HasColumnType("int");

                    b.Property<int?>("Proyecto_ConstruccionId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("taskName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Proyecto_ConstruccionId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("Manager.Share.Entities.Equipos_Proy_Construccion", b =>
                {
                    b.HasOne("Manager.Share.Entities.Equipos_Construccion", "equipos")
                        .WithMany("Equipos_Proy")
                        .HasForeignKey("equiposId");

                    b.HasOne("Manager.Share.Entities.Proyecto_Construccion", "proyecto")
                        .WithMany("proy_Construccions")
                        .HasForeignKey("proyectoId");

                    b.Navigation("equipos");

                    b.Navigation("proyecto");
                });

            modelBuilder.Entity("Manager.Share.Entities.MaquinariaTarea", b =>
                {
                    b.HasOne("Manager.Share.Entities.Maquinaria", "Maquinaria")
                        .WithMany("MaquinariaTareas")
                        .HasForeignKey("MaquinariaId");

                    b.HasOne("Manager.Share.Entities.Tarea", "Tarea")
                        .WithMany("MaquinariasTarea")
                        .HasForeignKey("TareaId");

                    b.Navigation("Maquinaria");

                    b.Navigation("Tarea");
                });

            modelBuilder.Entity("Manager.Share.Entities.MaterialTarea", b =>
                {
                    b.HasOne("Manager.Share.Entities.Material", "Material")
                        .WithMany("MaterialTarea")
                        .HasForeignKey("MaterialId");

                    b.HasOne("Manager.Share.Entities.Tarea", "Tarea")
                        .WithMany("MaterialTarea")
                        .HasForeignKey("TareaId");

                    b.Navigation("Material");

                    b.Navigation("Tarea");
                });

            modelBuilder.Entity("Manager.Share.Entities.Proyecto_Construccion", b =>
                {
                    b.HasOne("Manager.Share.Entities.Presupuesto", "Presupuesto")
                        .WithMany("construcciones")
                        .HasForeignKey("PresupuestoId");

                    b.Navigation("Presupuesto");
                });

            modelBuilder.Entity("Manager.Share.Entities.Tarea", b =>
                {
                    b.HasOne("Manager.Share.Entities.Proyecto_Construccion", "Proyecto_Construccion")
                        .WithMany("Tareas")
                        .HasForeignKey("Proyecto_ConstruccionId");

                    b.Navigation("Proyecto_Construccion");
                });

            modelBuilder.Entity("Manager.Share.Entities.Equipos_Construccion", b =>
                {
                    b.Navigation("Equipos_Proy");
                });

            modelBuilder.Entity("Manager.Share.Entities.Maquinaria", b =>
                {
                    b.Navigation("MaquinariaTareas");
                });

            modelBuilder.Entity("Manager.Share.Entities.Material", b =>
                {
                    b.Navigation("MaterialTarea");
                });

            modelBuilder.Entity("Manager.Share.Entities.Presupuesto", b =>
                {
                    b.Navigation("construcciones");
                });

            modelBuilder.Entity("Manager.Share.Entities.Proyecto_Construccion", b =>
                {
                    b.Navigation("Tareas");

                    b.Navigation("proy_Construccions");
                });

            modelBuilder.Entity("Manager.Share.Entities.Tarea", b =>
                {
                    b.Navigation("MaquinariasTarea");

                    b.Navigation("MaterialTarea");
                });
#pragma warning restore 612, 618
        }
    }
}
