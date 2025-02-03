using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class frmGradoviIB230022 : Form
    {
        private Drzava drzava;
        DLWMSContext db = new DLWMSContext();
        List<Grad> lista = new List<Grad>();
        public frmGradoviIB230022(Drzava drzava)
        {
            InitializeComponent();
            this.drzava = drzava;
        }
        private void frmGradoviIB230022_Load(object sender, EventArgs e)
        {
            lblDrzava.Text = drzava.Naziv;
            pictureBox1.Image = drzava.Zastava.ToImage();
            editDgv();
            ucitajDgv();
        }

        private void editDgv()
        {
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (validanUnos())
            {
                var noviGrad = new Grad();
                noviGrad.Aktivan = true;
                noviGrad.Oznaka = "Grad";
                noviGrad.Naziv = txtNazivGrada.Text;
                noviGrad.DrzavaId = drzava.Id;

                db.Gradovi.Add(noviGrad);
                db.SaveChanges();
                ucitajDgv();
            }
            else
                MessageBox.Show("Nije moguće dodati postojeći grad", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ucitajDgv()
        {
            var listaCpy = new List<Grad>();

            foreach (var item in db.Gradovi.ToList())
            {
                if (item.DrzavaId == drzava.Id)
                    listaCpy.Add(item);
            }
            lista = listaCpy;
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }

        private bool validanUnos()
        {
            return Helpers.Validator.ProvjeriUnos(txtNazivGrada, errorProvider1, Kljucevi.RequiredField) &&
                postoji();
        }

        private bool postoji()
        {
            var broj = db.Gradovi.Where(x => x.DrzavaId == drzava.Id && x.Naziv == txtNazivGrada.Text).Count();
            if (broj > 0)
                return false;
            return true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ToolTipText == "Promijeni status")
            {
                bool tr = lista.ElementAt(e.RowIndex).Aktivan;
                db.Gradovi.Where(grad => grad.Id == lista.ElementAt(e.RowIndex).Id).First().Aktivan = !tr;
                db.Gradovi.Update(lista.ElementAt(e.RowIndex));
                db.SaveChanges();
                ucitajDgv();
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var br = int.Parse(txtBrojZapisa.Text);
            var odabran = cbAktivan.Checked;
            Thread trd = new Thread(() => generisiNoviBrojZapisa(br, odabran));
            trd.Start();
        }

        private void generisiNoviBrojZapisa(int br, bool odabran)
        {
            for (int i = 0; i < br; i++)
            {
                var novi = new Grad()
                {
                    Aktivan = odabran,
                    Naziv = $"Grad  {i + 1}",
                    Oznaka = $"G1",
                    DrzavaId = drzava.Id,
                };
                db.Gradovi.Add(novi);
                db.SaveChanges();
                BeginInvoke(() => Ispis($"Grad  {i + 1}"));
                Thread.Sleep(300);
            }
            Invoke(() => MessageBox.Show($"Uspješno ste generisali {br} novih zapisa", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information));
            Invoke(() => ucitajDgv());
        }

        private void Ispis(string v)
        {
            txtInfo.Text += $"{DateTime.Now} -> dodat grad {v} za drzavu {drzava.Naziv} {Environment.NewLine}";
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();

        }
    }
}
