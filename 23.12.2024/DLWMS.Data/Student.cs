﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public int GradId { get; set; }
        public int SpolId { get; set; }
        public Spol Spol { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public int SemestarId { get; set; }

        [NotMapped]
        public string ImePrezimeGodina => $"{Ime} {Prezime} ({DateTime.Now.Year - DatumRodjenja.Year})";
        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";
        [NotMapped]
        public double ProsjecnaOcjena { get; set; }
        [NotMapped]
        public string Uloga { get; set; }
    }
}