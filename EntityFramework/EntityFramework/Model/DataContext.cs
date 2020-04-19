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
            Database.SetInitializer<DataContext>(new TaoDataBase());

        }
        public class TaoDataBase : CreateDatabaseIfNotExists<DataContext>
        {
            protected override void Seed(DataContext context)
            {
                context.SinhViens.Add(new SinhVien
                {
                    MSSV = "101",
                    Name = "Nguyễn Văn A",
                    Age = 19,
                    Gender = true
                });
                context.SinhViens.Add(new SinhVien
                {
                    MSSV = "102",
                    Name = "Nguyễn Văn B",
                    Age = 19,
                    Gender = false
                });
                

                context.SaveChanges();
            }
        }

    }
    



}