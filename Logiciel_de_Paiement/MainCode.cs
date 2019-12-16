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
    public partial class MainCode : Form
    {
        public MainCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivatorCode F1 = new ActivatorCode();
            F1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CodeRg cr = new CodeRg();
            cr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCode sc = new ShowCode();
            sc.Show();
        }
    }
}
