using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logiciel_de_Paiement
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial" + " Catalog=LogicielDePaiement;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private void show()
        {
            SqlCommand cmd = new SqlCommand("select * from Paiement where date_Remise_chèq=getdate()", cnx);
            cnx.Open();
            dr = cmd.ExecuteReader();

            if (dt.Rows.Count == 0)
                dt.Load(dr);

            dataGridView2.DataSource = dt;
            dr.Close();
            cnx.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
