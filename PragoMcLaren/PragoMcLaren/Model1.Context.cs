﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PragoMcLaren
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class McLarenEntities : DbContext
    {
        public McLarenEntities()
            : base("name=McLarenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Автомобили> Автомобили { get; set; }
        public virtual DbSet<Запчасти> Запчасти { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Продажи> Продажи { get; set; }
        public virtual DbSet<СервисныеВизиты> СервисныеВизиты { get; set; }
        public virtual DbSet<СкладАвтомобилей> СкладАвтомобилей { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<ТестДрайвы> ТестДрайвы { get; set; }
        public virtual DbSet<ФинансовыеУсловия> ФинансовыеУсловия { get; set; }
    }
}
