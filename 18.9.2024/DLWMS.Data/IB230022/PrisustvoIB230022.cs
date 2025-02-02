using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230022
{
    [Table("PrisustvoIB230022")]
    public class PrisustvoIB230022
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB230022 Nastava{ get; set; }
        [NotMapped]
        public string StudentIIP => Student.BrojIndeksa + ' ' + Student.Ime + ' ' + Student.Prezime;
        [NotMapped]
        public string PPV => $"{Nastava.Predmet.Naziv} - u {Nastava.Dan} @  {Nastava.Vrijeme}";
    }
}
