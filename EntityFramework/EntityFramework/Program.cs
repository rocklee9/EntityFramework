using EntityFramework.Model;
using EntityFramework.Model.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EntityFramworkMamager ql = new EntityFramworkMamager();
            string kt;
            SinhVien sv=new SinhVien();
            Console.WriteLine("--------------------------------Entity Framework----------------------------");
            Console.WriteLine("               *********************************************                ");
            Console.WriteLine("1. Get list sinh viên ");
            Console.WriteLine("2. Thêm sinh viên");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.WriteLine("---------------------------------------------------------------------------");
            while (true)
            {
                Console.WriteLine("Chon : ");
                kt = Console.ReadLine();
                switch (kt)
                {
                    case "1":
                        {
                            List<SinhVien> sinhViens = ql.GetSinhViens();
                            Console.WriteLine("Tong so sinh viên {0}",sinhViens.Count);
                            foreach(var sinhVien in sinhViens)
                            {
                                Console.WriteLine("{0}", sinhVien.Name);
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("MSSV =");
                            sv.MSSV = Console.ReadLine();
                            Console.WriteLine("Name =");
                            sv.Name = Console.ReadLine();
                            Console.WriteLine("Age =");
                            sv.Age = Convert.ToInt32(Console.ReadLine());
                            sv.Gender = true;
                            ql.AddSinhVien(sv);
                            break;
                        }
                }
                Console.ReadKey();
            }
             
        }
    }
}
