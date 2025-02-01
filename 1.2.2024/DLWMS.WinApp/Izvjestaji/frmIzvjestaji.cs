using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Drzava drzava;
        DLWMSContext db = new DLWMSContext();
        public frmIzvjestaji(Drzava drzava)
        {
            InitializeComponent();            
            this.drzava = drzava;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            ReportDataSource rds = new ReportDataSource();

            int brojac = 0;
            dsDLWMS.DataTable1DataTable tabela = new dsDLWMS.DataTable1DataTable();
            foreach (var item in db.Gradovi.Where(x=>x.DrzavaId==drzava.Id).ToList())
            {
                var red = tabela.NewDataTable1Row();
                red.Rb = $"{brojac + 1}";
                red.Grad = item.Naziv;
                red.Drzava = drzava.Naziv;
                red.Aktivan = (item.Aktivan) ? "DA" : "NE";
                tabela.Rows.Add(red);
                brojac ++;
            }
            rds.Value = tabela;
            rds.Name = "DataSet1";

            rpc.Add(new ReportParameter("prikazano",tabela.Count().ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport(); 
        }
    }
}
