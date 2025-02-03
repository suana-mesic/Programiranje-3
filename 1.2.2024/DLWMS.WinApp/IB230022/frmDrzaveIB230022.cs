using DLWMS.Data;
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
    public partial class frmDrzaveIB230022 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Drzava> lista = new List<Drzava>();

        public frmDrzaveIB230022()
        {
            InitializeComponent();
        }

        private void frmDrzaveIB230022_Load(object sender, EventArgs e)
        {
            editDgv();
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            lista.Clear();
            foreach (var item in db.Drzave.ToList())
            {
                item.BrGradova = db.Gradovi.Where(x => x.DrzavaId == item.Id).Count();
                lista.Add(item);
            }
            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = lista;
        }

        private void editDgv()
        {
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = $"Trenutno vrijeme {DateTime.Now.ToString("HH:mm:ss")}";

        }

        private void btnprintaj_Click(object sender, EventArgs e)
        {
            int index = dgvDrzave.CurrentRow.Index;
            new frmIzvjestaji(lista.ElementAt(index)).Show();
        }

        private void btnNovadrzava_Click(object sender, EventArgs e)
        {
            new frmNovaDrzavaIB230022().ShowDialog();
            ucitajDgv();
        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDrzave.CurrentCell.ToolTipText != "Gradovi")
            {
                new frmNovaDrzavaIB230022(lista.ElementAt(e.RowIndex)).ShowDialog();
                ucitajDgv();
            }
        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDrzave.CurrentCell.ToolTipText == "Gradovi")
            {
                new frmGradoviIB230022(lista.ElementAt(e.RowIndex)).ShowDialog();
                ucitajDgv();
            }
        }
    }
}
