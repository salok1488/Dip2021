//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uargaz
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class uargazEntities : DbContext
    {
        public uargazEntities()
            : base("name=uargazEntities")
        {
        }
        public static uargazEntities GetContext()
        {
            if (_context == null)
                _context = new uargazEntities();

            return _context;

        }
        private static uargazEntities _context;
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Аварийная_работа> Аварийная_работа { get; set; }
        public virtual DbSet<Бригада> Бригада { get; set; }
        public virtual DbSet<Заявка> Заявка { get; set; }
        public virtual DbSet<Смена> Смена { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<Список_использованных_материалов> Список_использованных_материалов { get; set; }
        public virtual DbSet<Транспорт> Транспорт { get; set; }
        public virtual DbSet<Участок> Участок { get; set; }
        public virtual DbSet<Учётная_запись> Учётная_запись { get; set; }
    }
}
