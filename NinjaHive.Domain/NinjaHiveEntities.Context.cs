﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NinjaHive.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NinjaHiveContext : DbContext
    {
        public NinjaHiveContext()
            : base("name=NinjaHiveContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GameItemEntity> GameItemEntities { get; set; }
        public virtual DbSet<RaceEntity> RaceEntities { get; set; }
        public virtual DbSet<ClassEntity> ClassEntities { get; set; }
        public virtual DbSet<TierEntity> TierEntities { get; set; }
        public virtual DbSet<LevelEntity> LevelEntities { get; set; }
        public virtual DbSet<SkillEntity> SkillEntities { get; set; }
        public virtual DbSet<StatInfoEntity> StatInfoEntities { get; set; }
        public virtual DbSet<SpecialEntity> SpecialEntities { get; set; }
        public virtual DbSet<MainCategoryEntity> MainCategories { get; set; }
        public virtual DbSet<SubCategoryEntity> SubCategories { get; set; }
    }
}
