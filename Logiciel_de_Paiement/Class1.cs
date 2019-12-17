using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Logiciel_de_Paiement
{
    class Class1
    {
        public static string secu()
        {
            string val = "";
            ManagementObjectSearcher ma = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            try
            {
                foreach (ManagementObject mo  in ma.Get())
                {
                    val = mo["SerialNumbre"].ToString();
                    return val;
                }
            }
            catch (ManagementException)
            {
                return "";
            }
            return val;
        }
    }
}
