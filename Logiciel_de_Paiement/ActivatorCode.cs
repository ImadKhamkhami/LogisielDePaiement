using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Win32;//registre
using System.IO;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System.Windows.Forms;
using FoxLearn.License;

namespace Logiciel_de_Paiement
{ 
    public partial class ActivatorCode : Form
    {
        
        public ActivatorCode()
        {
            InitializeComponent();
        }
        const int prodactCode = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(tb_ProductID.Text);
            KeyValuesClass kv;
            string productKey = string.Empty;
            if (ComboLicenceType.SelectedIndex == 0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)prodactCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                };
                if (!km.GenerateKey(kv, ref productKey))
                    tbProductKey.Text = "Error";
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)prodactCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(TBExprirationDate.Text))
                };
                if (!km.GenerateKey(kv, ref productKey))

                    tbProductKey.Text = "Error";
            }
                tbProductKey.Text = productKey;
        }

        private void ActivatorCode_Load(object sender, EventArgs e)
        {
            ComboLicenceType.SelectedIndex = 0;
            tb_ProductID.Text = ComputerInfo.GetComputerId();
        }
    }
}
