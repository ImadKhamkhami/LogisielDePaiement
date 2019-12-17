using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_de_Paiement
{
    public partial class ShowCode : Form
    {
        public ShowCode()
        {
            InitializeComponent();
        }
        const int productCode = 1;
        private void ShowCode_Load(object sender, EventArgs e)
        {
            lblProductID.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(lblProductID.Text);
            LicenseInfo lic = new LicenseInfo();
            int values = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            if(km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if(km.DisassembleKey(productKey,ref kv))
                {
                    lblProductName.Text = "Imad Khamkhami";
                    lblProductKey.Text = productKey;
                    if (kv.Type == LicenseType.TRIAL)
                        lblLicenseType.Text = string.Format("{0}days", (kv.Expiration - DateTime.Now.Date).Days);
                    else
                        lblLicenseType.Text = "Full";
                }
            }
        }
    }
}
