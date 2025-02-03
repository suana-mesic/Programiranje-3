using DLWMS.Data;
using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class Nastava : Form
    {
        ProstorijeIB230022 prostorija;
        List<NastavaIB230022> lista = new List<NastavaIB230022>();
        DLWMSContext db = new DLWMSContext();
        public Nastava(ProstorijeIB230022 prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
        }

        private void Nastava_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = prostorija.Naziv;
            editDgv();
            UcitajCmb();
            ucitajDgv();
        }

        private void UcitajCmb()
        {
            cmbPredmet.UcitajPodatke<Predmet>(db.Predmet.ToList());
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
        }

        private void ucitajDgv()
        {
            lista.Clear();
            foreach (var item in db.Nastava.Include(x => x.Predmet).Include(x => x.Prostorija).Where(x => x.ProstorijaId == prostorija.Id).ToList())
                lista.Add(item);
            dgvNastava.DataSource = null;
            dgvNastava.DataSource = lista;
        }

        private void editDgv()
        {
            dgvNastava.AutoGenerateColumns = false;
            dgvNastava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string evidentiraniPredmet = "";
            if (ValidniPodaci(out evidentiraniPredmet, prostorija.Id, cmbDan.Text, cmbVrijeme.Text))
            {
                var predmet = (cmbPredmet.SelectedItem as Predmet).Naziv;
                var nastava = new NastavaIB230022();

                nastava.PredmetId = (cmbPredmet.SelectedItem as Predmet).Id;
                nastava.ProstorijaId = prostorija.Id;
                nastava.Dan = cmbDan.Text;
                nastava.Vrijeme = cmbVrijeme.Text;
                nastava.Oznaka = $"{predmet} :: {cmbDan.Text} :: {cmbVrijeme.Text}";

                db.Nastava.Add(nastava);
                db.SaveChanges();
                ucitajDgv();
            }
           else MessageBox.Show($"Ne može se dodati nova nastava u prostorji {prostorija.Naziv} u periodu {cmbVrijeme.Text} jer je u tom periodu već evidentirana nastava na predmetu {evidentiraniPredmet}.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool ValidniPodaci(out string evidentiraniPredmet, int prostorijaId, string dan, string vrijeme)
        {
            evidentiraniPredmet = "";
            var nastava = db.Nastava.Where(x => x.ProstorijaId == prostorijaId && x.Vrijeme == vrijeme && x.Dan == dan).ToList();

            if (nastava.Count() > 0)
            {
                evidentiraniPredmet = nastava.ElementAt(0).NazivPredmeta;
                return false;
            }
            return true;
        }
    }
}
