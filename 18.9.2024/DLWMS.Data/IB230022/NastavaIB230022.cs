using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230022
{
    [Table("NastavaIB230022")]
    public class NastavaIB230022
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public int PredmetId { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
        public ProstorijeIB230022 Prostorija{ get; set; }
        public Predmet Predmet { get; set; }
        [NotMapped]
        public string NazivPredmeta => Predmet.Naziv;
    }
}
