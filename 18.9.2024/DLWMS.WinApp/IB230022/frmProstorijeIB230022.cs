using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Izvjestaji;
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
    public partial class frmProstorijeIB230022 : Form
    {
        List<ProstorijeIB230022> lista = new List<ProstorijeIB230022>();
        DLWMSContext db = new DLWMSContext();
        public frmProstorijeIB230022()
        {
            InitializeComponent();
        }

        private void frmProstorijeIB230022_Load(object sender, EventArgs e)
        {
            editDgv();
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            lista.Clear();

            foreach (var item in db.Prostorije.ToList())
            {
                item.BrPredmeta = db.Nastava.Where(nastava => nastava.ProstorijaId == item.Id).ToList().Count();
                lista.Add(item);
            }
            dgvProstorije.DataSource = null;
            dgvProstorije.DataSource = lista;
        }

        private void editDgv()
        {
            dgvProstorije.AutoGenerateColumns = false;
            dgvProstorije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvProstorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrani = dgvProstorije.CurrentCell.ToolTipText;
            var prostorija = lista.ElementAt(e.RowIndex);
            if (odabrani != "Nastava" && odabrani != "Prisustvo")
                new frmNovaProstorijaIB230022(prostorija).ShowDialog();
            if (odabrani == "Nastava")
                new Nastava(prostorija).ShowDialog();
            if (odabrani == "Prisustvo")
                new frmPrisustvoIB230022(prostorija).ShowDialog();
            ucitajDgv();
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            new frmNovaProstorijaIB230022().ShowDialog();
            ucitajDgv();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            int index = dgvProstorije.CurrentRow.Index;
            new frmIzvjestaji(lista.ElementAt(index)).Show();
        }
    }
}
