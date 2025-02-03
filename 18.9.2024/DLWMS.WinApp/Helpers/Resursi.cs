using DLWMS.WinApp.IB230022;
using System.Resources;

namespace DLWMS.WinApp.Helpers
{
    public class Resursi
    {
        static ResourceManager Manager = new ResourceManager("DLWMS.WinApp.Resource1",
                                                    typeof(frmProstorijeIB230022).Assembly);
        public static string Get(string key)
        {
            return Manager.GetString(key);
        }
    }
}
