using DLWMS.Data;
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
    public partial class frmPretragaIB230022 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> lista = new List<Student>();
        public frmPretragaIB230022()
        {
            InitializeComponent();
        }

        private void frmPretragaFinal_Load(object sender, EventArgs e)
        {
            editDgv();
            ucitajDrzave();
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            lista.Clear();
            foreach (var item in db.Studenti.ToList())
            {
                if (ispunjavaUslov(item.GradId))
                {
                    item.NazivGrada = cmbGrad.Text;
                    item.NazivDrzave = cmbDrzava.Text;
                    var ocjene = db.StudentiPredmeti.Where(sp => sp.StudentId == item.Id).Select(x => x.Ocjena).ToList();
                    item.Prosjek = (ocjene.Count() == 0) ? 5 : ocjene.Average();
                    lista.Add(item);
                }
            }
            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = lista;
        }

        private bool ispunjavaUslov(int gradId)
        {
            var odabraniGradId = (cmbGrad.SelectedItem as Grad).Id;
            return (odabraniGradId == gradId);
        }

        private void ucitajDrzave()
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.UcitajPodatke<Drzava>(db.Drzave.ToList());

            ucitajGradove();
        }

        private bool ucitajGradove()
        {
            int prvaDrzava = (cmbDrzava.SelectedItem as Drzava).Id;
            var listaGradova = db.Gradovi.Where(x => x.DrzavaId == prvaDrzava).ToList();
            cmbGrad.UcitajPodatke<Grad>(listaGradova);
            return listaGradova.Count == 0;
        }
        private void editDgv()
        {
            dgvPretraga.AutoGenerateColumns = false;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbDrzava_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ako država ima više od jednog evidentiranog grada u bazi
            if (!ucitajGradove())
                ucitajDgv();
            else
                dgvPretraga.DataSource = null;
        }

        private void cmbGrad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();
        }
    }

}
