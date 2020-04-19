using EntityFramework.Model;
using EntityFramework.Model.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EntityFramworkMamager
    {
        DataContext context;
        public EntityFramworkMamager()
        {
            context = new DataContext();
        }

        public List<SinhVien> GetSinhViens()
        {
            return context.SinhViens.ToList();
        }

        public SinhVien GetSinhVienByMssv(string mssv)
        {
            return context.SinhViens.FirstOrDefault(x=>x.MSSV==mssv);
        }

        public void AddSinhVien(SinhVien sinhVien)
        {
            context.SinhViens.Add(new SinhVien
            {
                MSSV = sinhVien.MSSV,
                Age = sinhVien.Age,
                Birthday = sinhVien.Birthday,
                Gender = sinhVien.Gender,
                Name = sinhVien.Name
            });
            context.SaveChanges();
        }

        public void UpdateSinhVien(SinhVien sinhVien)
        {
            var sv = context.SinhViens.FirstOrDefault(x => x.MSSV == sinhVien.MSSV);

            sv.Age = sinhVien.Age;
            sv.Birthday = sinhVien.Birthday;
            sv.Gender = sinhVien.Gender;
            sv.Name = sinhVien.Name;
            
            context.SaveChanges();
        }

        public void DeleteSinhVien(string mssv)
        {
            var sv = context.SinhViens.FirstOrDefault(x => x.MSSV == mssv);
            context.SinhViens.Remove(sv);
            context.SaveChanges();
        }
    }
}
