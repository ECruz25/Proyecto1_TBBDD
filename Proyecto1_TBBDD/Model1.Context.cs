﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1_TBBDD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<employeetype> employeetypes { get; set; }
        public virtual DbSet<incident> incidents { get; set; }
        public virtual DbSet<urgency> urgencies { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}