using DLWMS.Data;
using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
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
    public partial class frmPretragaIB230022 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> lista = new List<Student>();
        public frmPretragaIB230022()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230022_Load(object sender, EventArgs e)
        {
            editDgv();
            ucitajCmb();
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            if (Form.ActiveForm == this)
            {
                var lista2 = new List<Student>();
                foreach (var item in db.StudentiUloge.Include(x => x.Student).Include(x => x.Uloga).ToList())
                {
                    if (ispunjavaUslov(item))
                    {
                        var listaOcjena = db.StudentiPredmeti.Where(sp => sp.StudentId == item.StudentId).Select(sp=>sp.Ocjena).ToList();
                        item.Student.ProsjecnaOcjena = (listaOcjena.Count == 0) ? 0 : listaOcjena.Average();
                        item.Student.Uloga = item.Uloga.Naziv;
                        lista2.Add(item.Student);
                    }
                }
                lista = lista2;
                dgv.DataSource = null;
                dgv.DataSource = lista;
                if (lista.Count == 0)
                {
                    MessageBox.Show($"U bazi nisu evidentirani studenti rođeni u periodu od {dtpod.Value} – {dtpdo.Value} godine, a koji su upisani u {cmbSemestar.Text} i posjeduju ulogu {cmbUloga.Text}", "Infromacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ispunjavaUslov(StudentiUlogeIB230022 item)
        {
            var semestarId = (cmbSemestar.SelectedItem as SemestriIB230022).Id;
            var ulogaId = (cmbUloga.SelectedItem as UlogaIB230022).Id;
            var datumod = dtpod.Value;
            var datumdo = dtpdo.Value;


            return (item.Student.SemestarId == semestarId && item.UlogaId == ulogaId && item.Student.DatumRodjenja >= datumod && item.Student.DatumRodjenja <= datumdo);
        }

        private void ucitajCmb()
        {
            cmbSemestar.DataSource = db.Semestri.ToList();
            cmbSemestar.ValueMember = "Id";
            cmbSemestar.DisplayMember = "Naziv";

            cmbUloga.DataSource = db.Uloge.ToList();
            cmbUloga.ValueMember = "Id";
            cmbUloga.DisplayMember = "Naziv";
            dtpod.Value = new DateTime(1888, 1, 1);
        }

        private void editDgv()
        {
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();
        }

        private void cmbUloga_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();
        }

        private void dtpod_ValueChanged(object sender, EventArgs e)
        {
            ucitajDgv();
        }

        private void dtpdo_ValueChanged(object sender, EventArgs e)
        {
            ucitajDgv();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ToolTipText == "Poruke")
                new frmPorukeIB230022(lista.ElementAt(e.RowIndex)).ShowDialog();
        }
    }
}
