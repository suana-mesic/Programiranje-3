using DLWMS.Data;
using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmNovaPorukaIB230022 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student student;

        public frmNovaPorukaIB230022(Student student)
        {
            InitializeComponent();
            this.student = student;
            cmbPredmet.UcitajPodatke<Predmet>(db.Predmeti.ToList());
            cmbHitnost.SelectedIndex = 0;
            dtpValidnost.Checked = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validno())
            {
                var nova = new StudentiPorukeIB230022();
                nova.Validnost = dtpValidnost.Value;
                nova.StudentId = student.Id;
                nova.PredmetId = (cmbPredmet.SelectedItem as Predmet).Id;
                nova.Sadrzaj = txtSadrzaj.Text; ;
                nova.Slika = pictureBox1.Image.ToByteArray();
                nova.Hitnost = cmbHitnost.Text;

                db.StudentiPoruke.Add(nova);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool validno()
        {
            return Helpers.Validator.ProvjeriUnos(cmbHitnost, err, Kljucevi.RequiredField) &&
                   Helpers.Validator.ProvjeriUnos(cmbPredmet, err, Kljucevi.RequiredField) &&
                    Helpers.Validator.ProvjeriUnos(pictureBox1, err, Kljucevi.RequiredField) &&
                     Helpers.Validator.ProvjeriUnos(txtSadrzaj, err, Kljucevi.RequiredField) &&
                      Helpers.Validator.ProvjeriUnos(dtpValidnost, err, Kljucevi.RequiredField);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
