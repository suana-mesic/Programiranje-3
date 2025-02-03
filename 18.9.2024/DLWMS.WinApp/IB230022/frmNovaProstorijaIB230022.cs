using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB230022
{
    public partial class frmNovaProstorijaIB230022 : Form
    {
        ProstorijeIB230022 prostorija;
        DLWMSContext db = new DLWMSContext();
        public frmNovaProstorijaIB230022(ProstorijeIB230022 prostorija = null)
        {
            InitializeComponent();
            this.prostorija = prostorija;
        }

        private void frmNovaProstorijaIB230022_Load(object sender, EventArgs e)
        {
            if (prostorija != null)
                UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pictureBox1.Image = prostorija.Logo.ToImage();
            txtNaziv.Text = prostorija.Naziv;
            txtOznaka.Text = prostorija.Oznaka;
            txtKapacitet.Text = prostorija.Kapacitet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (podaciUneseni())
            {
                try
                {
                    int.Parse(txtKapacitet.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste unijeli broj u polju kapacitet", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (prostorija == null)
                    prostorija = new ProstorijeIB230022();

                prostorija.Naziv = txtNaziv.Text;
                prostorija.Oznaka = txtOznaka.Text;
                prostorija.Kapacitet = int.Parse(txtKapacitet.Text);
                prostorija.Logo = pictureBox1.Image.ToByteArray();

                if (prostorija.Id == 0)
                    db.Prostorije.Add(prostorija);
                else
                    db.Entry(prostorija).State = EntityState.Modified;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool podaciUneseni()
        {
            return Helpers.Validator.ProvjeriUnos(pictureBox1, err, Kljucevi.RequiredField) &&
                  Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.RequiredField) &&
                  Helpers.Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.RequiredField) &&
                  Helpers.Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.RequiredField);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
