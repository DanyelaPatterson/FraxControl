using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoFraccionamiento.Entities;

namespace FraxControl
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //public DbSet<VehiculoEntity> Vehiculos { get; set; }

        public DbSet<VehiculoEntity> Vehiculos => Set<VehiculoEntity>();
        public DbSet <VisitaEntity> Visitas => Set<VisitaEntity>();
        public DbSet <SocialAreaEntity> AreasSociales=> Set<SocialAreaEntity>();
    }
}