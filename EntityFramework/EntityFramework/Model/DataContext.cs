namespace EntityFramework.Model
{
    using EntityFramework.Model.Schema;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DataContext()
            : base("name=DataContext")
        {

        }
        

    }
    



}