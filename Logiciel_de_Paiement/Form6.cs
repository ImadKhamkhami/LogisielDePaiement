using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Logiciel_de_Paiement
{
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial Catalog=LogicielDePaiement;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }
        Form9 f;
        public Form6(Form9 f):this()
        {
            this.f = f;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            afficherCmptBn();
        }

        private void afficherCmptBn()
        {
            SqlCommand sqlCmd = new SqlCommand("select * from CompteBnq", conn);
            conn.Open();
            SqlDataReader rd = sqlCmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd[0]);
            }
            conn.Close();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox_Comptebnq.Text == " Banque+N°Compte")
            {
                textBox_Comptebnq.Text = "";
                textBox_Comptebnq.ForeColor = Color.Black;
            }
        }

        private void textBox_Comptebnq_Leave(object sender, EventArgs e)
        {
            if (textBox_Comptebnq.Text == "")
            {
                textBox_Comptebnq.Text = " Banque+N°Compte";
                textBox_Comptebnq.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("insert into CompteBnq values (@compte)",conn);
            sqlCmd.Parameters.AddWithValue("compte", textBox_Comptebnq.Text);
            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();
            f.showDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Comptebnq.Text == "")
            {
                MessageBox.Show("Cherchez Compte Bancaire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string CompteRecherche = textBox_Comptebnq.Text;

                SqlCommand cmd = new SqlCommand("select * from CompteBnq where Compte='" + CompteRecherche + "' ", conn);
                conn.Open();
                SqlDataReader ddr = cmd.ExecuteReader();

                while (ddr.Read())
                {

                    textBox_Comptebnq.Text = ddr[0].ToString();

                }
                ddr.Close();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_Comptebnq.Text == "")
            {
                MessageBox.Show("Cherchez Compte Bancaire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update etudiant set Compte = @Compte", conn);
                cmd.Parameters.AddWithValue("compte",textBox_Comptebnq.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_Comptebnq.Text == "")
            {
                MessageBox.Show("Cherchez Compte Bancaire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete etudiant set Compte = @Compte", conn);
                cmd.Parameters.AddWithValue("compte", textBox_Comptebnq.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem==null)
            {
                comboBox1.ForeColor = Color.Gray;
                comboBox1.Text = "Liste des comptes";
            }
        }
    }
}
