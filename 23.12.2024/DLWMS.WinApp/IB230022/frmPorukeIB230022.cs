using DLWMS.Data;
using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
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
    public partial class frmPorukeIB230022 : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();
        List<StudentiPorukeIB230022> lista = new List<StudentiPorukeIB230022>();
        public frmPorukeIB230022(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmIzvjestaji(lista, student).Show();
        }

        private void frmPorukeIB230022_Load(object sender, EventArgs e)
        {
            lblStudent.Text = $"Poruke studenta {student.Ime} {student.Prezime}";
            cmbPredmet.UcitajPodatke<Predmet>(db.Predmeti.ToList());
            editDgv();
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            var lista2 = new List<StudentiPorukeIB230022>();
            foreach (var item in db.StudentiPoruke.Include(s => s.Student).Include(s => s.Predmet).ToList())
            {
                var datum = item.Validnost;
                if (item.StudentId == student.Id && datum > DateTime.Now)
                    lista2.Add(item);
            }
            if (lista2.Count > 0)
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;
            lista = lista2;
            dgv.DataSource = null;
            dgv.DataSource = lista;
            Text = $"Broj poruka: {lista.Count}";
        }

        private void editDgv()
        {
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var br = int.Parse(txtBrojPoruka.Text);
            int predemtId = (cmbPredmet.SelectedItem as Predmet).Id;
            var validnost = dtpValidnost.Value;
            Thread trd = new Thread(() => dodajInfo(br, predemtId, validnost));
            trd.Start();
        }

        private void dodajInfo(int br, int predmetId, DateTime validnost)
        {
            for (int i = 0; i < br; i++)
            {
                var nova = new StudentiPorukeIB230022();
                nova.Validnost = validnost;
                nova.StudentId = student.Id;
                nova.PredmetId = predmetId;
                nova.Sadrzaj = $"{i + 1}. GENERISANA PORUKA";
                nova.Slika = lista.ElementAt(0).Slika;
                nova.Hitnost = "Srednja";

                db.StudentiPoruke.Add(nova);
                db.SaveChanges();

                BeginInvoke(() => Ispis((cmbPredmet.SelectedItem as Predmet).Naziv));
                Thread.Sleep(300);
            }
            Invoke(() => ucitajDgv());
            Invoke(() => MessageBox.Show($"Dodali ste {br} novih poruka za studenta {student.ImePrezime} na predmetu {(cmbPredmet.SelectedItem as Predmet).Id}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }

        private void Ispis(string predmet)
        {
            txtInfo.Text += $"{DateTime.Now} -> generisana nova poruka za {student.ImePrezime} na predmetu {predmet} {Environment.NewLine}";
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ToolTipText == "Brisi")
            {
                lista.RemoveAt(e.RowIndex);
                dgv.DataSource = null;
                dgv.DataSource = lista;

                if (lista.Count == 0)
                    btnDodaj.Enabled = false;
            }
        }

        private void izbrisi(int rowIndex)
        {
            lista.RemoveAt(rowIndex);
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            if (new frmNovaPorukaIB230022(student).ShowDialog() == DialogResult.OK)
                ucitajDgv();
        }
    }
}
