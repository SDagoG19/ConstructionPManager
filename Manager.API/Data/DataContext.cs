﻿using Manager.Share.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace Manager.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Tarea> tareas { get; set; }

        public DbSet<Material> materiales { get; set; }
        public DbSet <Proyecto_Construccion> Proyectos_Construccion { get; set; }
        public DbSet <Equipos_Construccion> Equipo_Construccion { get; set; }
        public DbSet<Maquinaria> maquinaria { get; set; }
        public DbSet<Presupuesto> presupuesto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}