using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230022
{
    [Table("StudentiPorukeIB230022")]
    public class StudentiPorukeIB230022
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public DateTime Validnost { get; set; }
        public string Sadrzaj { get; set; }
        public string Hitnost { get; set; }
        public byte[] Slika { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
    }
}
