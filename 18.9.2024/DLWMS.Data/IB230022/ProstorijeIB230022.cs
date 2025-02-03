using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230022
{
    [Table("ProstorijeIB230022")]
    public class ProstorijeIB230022
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public byte[] Logo { get; set; }
        public int Kapacitet { get; set; }
        [NotMapped]
        public int BrPredmeta { get; set; }
    }
}
