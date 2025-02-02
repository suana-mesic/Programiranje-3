using DLWMS.WinApp.IB230022;

namespace DLWMS.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var startnaForma = new frmProstorijeIB230022();
            Application.Run(startnaForma);
        }
    }
}