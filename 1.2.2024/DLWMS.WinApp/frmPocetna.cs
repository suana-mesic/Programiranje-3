using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.IB230022;
using DLWMS.WinApp.Izvjestaji;

namespace DLWMS.WinApp
{
    public partial class frmPocetna : Form
    {
        DLWMSContext db = new DLWMSContext();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnDrzaveIGradovi_Click(object sender, EventArgs e)
        {
            new frmDrzaveIB230022().Show();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            new frmPretragaIB230022().ShowDialog();
        }

    }
}
