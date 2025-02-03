using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    public class Drzava
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivna { get; set; }
        public byte[] Zastava { get; set; }
        [NotMapped]
        public int BrGradova { get; set; }
    }
}
