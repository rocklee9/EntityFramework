using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Model.Schema
{
    [Table("LopHocPhan")]
    public class LopHocPhan
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("HocPhan")]
        public int IdHocPhan { get; set; }

        [ForeignKey("SinhVien")]
        public string MSSV { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public virtual HocPhan HocPhan { get; set; }

    }
}
