using DLWMS.Data;
using DLWMS.Data.IB230022;
using DLWMS.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiPorukeIB230022> lista;
        DLWMSContext db = new DLWMSContext();
        Student student;
        public frmIzvjestaji(List<StudentiPorukeIB230022> lista, Student student)
        {
            InitializeComponent();
            this.lista = lista;
            this.student = student;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            ReportDataSource rds = new ReportDataSource();

            int i = 0;
            double prosjekKaraktea = 0;
            var tabela = new dsDLWMS.DataTable1DataTable();

            foreach (var item in lista)
            {
                var red = tabela.NewDataTable1Row();
                red.Rb = $"{i + 1}";
                red.Predmet = item.Predmet.Naziv;
                red.Poruka = item.Sadrzaj;
                red.BrojZnakova = item.Sadrzaj.Length.ToString();
                prosjekKaraktea += item.Sadrzaj.Length;
                red.Validnost = item.Validnost.ToString();
                tabela.Rows.Add(red);
                i++;
            }
            rds.Value = tabela;
            rds.Name = "DataSet1";

            rpc.Add(new ReportParameter("student", student.ImePrezime));
            rpc.Add(new ReportParameter("ukupno", lista.Count.ToString()));
            rpc.Add(new ReportParameter("prosjecno", Math.Round(prosjekKaraktea / lista.Count, 2).ToString()));


            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
