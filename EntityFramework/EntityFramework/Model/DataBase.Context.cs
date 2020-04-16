

namespace EntityFramework.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
    }
}
