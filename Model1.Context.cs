﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP_laba3_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UP_laba_1Entities1 : DbContext
    {
        public UP_laba_1Entities1()
            : base("name=UP_laba_1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PilotsOfShip> PilotsOfShip { get; set; }
        public virtual DbSet<ShipsTypes> ShipsTypes { get; set; }
        public virtual DbSet<SpaceShips> SpaceShips { get; set; }
    }
}
