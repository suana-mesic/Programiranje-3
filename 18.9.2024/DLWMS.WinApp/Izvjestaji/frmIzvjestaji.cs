using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        ProstorijeIB230022 prostorija;
        DLWMSContext db = new DLWMSContext();

        public frmIzvjestaji(ProstorijeIB230022 prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            ReportDataSource rds = new ReportDataSource();

            int studenti = 0;
            var tabela =
             new dsDLWMS.DataTable1DataTable();
            var lista = db.Prisustvo.Include(x => x.Nastava).Include(x => x.Nastava.Prostorija).Include(x => x.Nastava.Predmet).Include(x => x.Student).Where(x => x.Nastava.Prostorija.Id == prostorija.Id);
            for (int i = 0; i < lista.Count(); i++)
            {
                var red = tabela.NewDataTable1Row();
                red.Rb = $"{i + 1}";
                red.Predmet = $"{lista.ElementAt(i).Nastava.Predmet.Naziv}";
                red.Vrijeme = $"{lista.ElementAt(i).Nastava.Vrijeme}";
                red.BrojIndeksa = $"{lista.ElementAt(i).Student.BrojIndeksa}";
                red.ImePrezime = $"{lista.ElementAt(i).Student.Ime} {lista.ElementAt(i).Student.Prezime}";
                tabela.Rows.Add(red);
                studenti++;

            }
            rds.Value = tabela;
            rds.Name = "DataSet1";
            rpc.Add(new ReportParameter("brojstudenata", studenti.ToString()));
            rpc.Add(new ReportParameter("prostorija", prostorija.Naziv));

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            reportViewer1.RefreshReport();
        }
    }
}
