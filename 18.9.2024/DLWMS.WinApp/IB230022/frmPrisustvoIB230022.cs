using DLWMS.Data;
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
    public partial class frmPrisustvoIB230022 : Form
    {
        ProstorijeIB230022 prostorija;
        DLWMSContext db = new DLWMSContext();
        List<PrisustvoIB230022> lista = new List<PrisustvoIB230022>();
        public frmPrisustvoIB230022(ProstorijeIB230022 prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
        }

        private void frmPrisustvoIB230022_Load(object sender, EventArgs e)
        {
            lblProstorija.Text = $"{prostorija.Naziv} - {prostorija.Oznaka}";
            editDgv();
            ucitajCmb();
            ucitajDgv();
        }

        private void ucitajCmb()
        {
            cmbNastava.UcitajPodatke<NastavaIB230022>(db.Nastava.Where(x => x.ProstorijaId == prostorija.Id).ToList(), "Oznaka", "Id");
            cmbStudent.UcitajPodatke<Student>(db.Studenti.ToList(), "IIP", "Id");
        }

        private void ucitajDgv()
        {
            if (db.Nastava.Where(x => x.ProstorijaId == prostorija.Id).Count() > 0)
            {
                lista.Clear();
                //ovdje se čuva id odabrane nastave
                var odabranaNastava = (cmbNastava.SelectedItem as NastavaIB230022).Id;
                foreach (var item in db.Prisustvo.Include(x => x.Student).Include(x => x.Nastava).Include(x => x.Nastava.Predmet).Include(x => x.Nastava.Prostorija).Include(x => x.Nastava.Predmet).Where(x => x.Nastava.Id == odabranaNastava).ToList())
                    lista.Add(item);
                dgvPrisustvo.DataSource = null;
                dgvPrisustvo.DataSource = lista;

                lblRazlomak.Text = $"{db.Prisustvo.Where(x => x.NastavaId == odabranaNastava).Count()}/{prostorija.Kapacitet}";
            }
        }

        private void editDgv()
        {
            dgvPrisustvo.AutoGenerateColumns = false;
            dgvPrisustvo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbNastava_SelectedValueChanged(object sender, EventArgs e)
        {
            ucitajDgv();
        }
        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojZapisa = int.Parse(txtBrojZapisa.Text);
            int studentId = (cmbStudent.SelectedItem as Student).Id;
            Thread trd = new Thread(() => Dodaj(brojZapisa, studentId));
            trd.Start();
        }

        private void Dodaj(int brojZapisa, int studentID)
        {
            int uspjesniZapisi = 0;

            foreach (var item in db.Nastava.Include(x => x.Predmet).Where(x => x.ProstorijaId == prostorija.Id).ToList())
            {
                for (int i = 0; i < brojZapisa; i++)
                {
                    if (!PrekoračenKapacitet())
                    {
                        var p = new PrisustvoIB230022();
                        p.StudentId = studentID;
                        p.NastavaId = item.Id;
                        db.Prisustvo.Add(p);
                        db.SaveChanges();

                        uspjesniZapisi++;

                        BeginInvoke(() => Upisi(studentID, p.PPV));
                        Thread.Sleep(300);
                    }
                    else
                    {
                        MessageBox.Show("Generisanje prisustva je zaustavljeno zbog prekoračenog kapaciteta", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucitajDgv();
                        return;
                    }
                }
            }
            if (uspjesniZapisi > 0)
                MessageBox.Show($"Uspješno ste dodali {uspjesniZapisi}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Svi kapaciteti su popunjeni", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucitajDgv();
        }

        private void Upisi(int studentId, string PPV)
        {
            txtInfo.Text += $"{DateTime.Now} -> {db.Studenti.Where(x => x.Id == studentId).First().IIP} za {PPV} {Environment.NewLine}";
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int studentID = (cmbStudent.SelectedItem as Student).Id;
            int nastavaId = (cmbNastava.SelectedItem as NastavaIB230022).Id;

            int brZapisa = db.Prisustvo.Where(x => x.StudentId == studentID && x.NastavaId == nastavaId).Count();
            if (brZapisa > 0)
            {
                MessageBox.Show("Već je evidentirano prisustvo studenta na odabranoj nastavi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!PrekoračenKapacitet())
            {
                var p = new PrisustvoIB230022();
                p.StudentId = studentID;
                p.NastavaId = nastavaId;
                db.Prisustvo.Add(p);
                db.SaveChanges();
                ucitajDgv();
            }
        }

        private bool PrekoračenKapacitet()
        {
            var kapacitet = prostorija.Kapacitet;
            var idOdabraneNastave = (cmbNastava.SelectedItem as NastavaIB230022).Id;
            int popunjenost = db.Prisustvo.Where(x => x.NastavaId == idOdabraneNastave).Count();
            if (kapacitet == popunjenost)
            {
                MessageBox.Show("Nije moguće dodati veći broj studenata od broja koji je definisan kapacitetom prostorije!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }
    }
}
