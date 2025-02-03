using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230022
{
    [Table("StudentiUlogeIB230022")]
    public class StudentiUlogeIB230022
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int UlogaId { get; set; }
        public Student Student { get; set; }
        public UlogaIB230022 Uloga { get; set; }

    }

}
