﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stemma.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STEMMAEntities : DbContext
    {
        public STEMMAEntities()
            : base("name=STEMMAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Career> Careers { get; set; }
        public virtual DbSet<Celebration> Celebrations { get; set; }
        public virtual DbSet<HobbyTable> HobbyTables { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Memory> Memories { get; set; }
        public virtual DbSet<RegisterUser> RegisterUsers { get; set; }
        public virtual DbSet<WorldEvent> WorldEvents { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<EventTable> EventTables { get; set; }
    }
}
