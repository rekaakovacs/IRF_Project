﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaracsonyfaRendeles
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KaracsonyfaEntities : DbContext
    {
        public KaracsonyfaEntities()
            : base("name=KaracsonyfaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fenyo> Fenyo { get; set; }
        public virtual DbSet<Ugyfel> Ugyfel { get; set; }
        public virtual DbSet<Rendeles> Rendeles { get; set; }
    }
}
