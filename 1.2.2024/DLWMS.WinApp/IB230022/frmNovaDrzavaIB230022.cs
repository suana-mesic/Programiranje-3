using ClosedXML.Excel;
using DLWMS.Data;
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
    public partial class frmNovaDrzavaIB230022 : Form
    {
        private Drzava drzava;
        DLWMSContext db = new DLWMSContext();

        public frmNovaDrzavaIB230022(Drzava drzava = null)
        {
            InitializeComponent();
            this.drzava = drzava;
        }

        private void frmNovaDrzavaIB230022_Load(object sender, EventArgs e)
        {
            if (drzava != null)
            {
                pictureBox1.Image = drzava.Zastava.ToImage();
                txtNaziv.Text = drzava.Naziv;
                checkBox1.Checked = drzava.Aktivna;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validanUnos())
            {
                if (drzava == null)
                    drzava = new Drzava();

                drzava.Zastava = pictureBox1.Image.ToByteArray();
                drzava.Naziv = txtNaziv.Text;
                drzava.Aktivna = checkBox1.Checked;
                if (drzava.Id != 0)
                    db.Entry(drzava).State = EntityState.Modified;
                else
                    db.Drzave.Add(drzava);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool validanUnos()
        {
            return Helpers.Validator.ProvjeriUnos(pictureBox1, errorProvider1, Kljucevi.RequiredField) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, errorProvider1, Kljucevi.RequiredField);
        }
    }
}
