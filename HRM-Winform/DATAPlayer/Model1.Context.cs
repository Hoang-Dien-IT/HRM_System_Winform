﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATAPlayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRMEntities : DbContext
    {
        public HRMEntities()
            : base("name=HRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DM_ChucVu> DM_ChucVu { get; set; }
        public virtual DbSet<DM_Luong> DM_Luong { get; set; }
        public virtual DbSet<Luong> Luong { get; set; }
        public virtual DbSet<NgayNghi> NgayNghi { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhongBan> PhongBan { get; set; }
        public virtual DbSet<QT_CongTac> QT_CongTac { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
    }
}
