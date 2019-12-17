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
    public partial class CodeRg : Form
    {
        public CodeRg()
        {
            InitializeComponent();
        }
        const int productCode = 1;
        private void CodeRg_Load(object sender, EventArgs e)
        {
            tbProductID.Text = ComputerInfo.GetComputerId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(tbProductID.Text);
            string productKey = tbProductKey.Text;
            if(km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if(km.DisassembleKey(productKey,ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Imad khamkhami";
                    if(kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("You Have been successfully registred", "Message",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    this.Dispose();
                }
            }else
                MessageBox.Show("Your Product Key is Invalide ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
