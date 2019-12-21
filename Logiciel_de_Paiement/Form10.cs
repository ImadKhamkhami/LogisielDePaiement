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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox_Nom_adm.Text == " Nom Administrateur")
            {
                textBox_Nom_adm.Text = "";
                textBox_Nom_adm.ForeColor = Color.Black;
            }
        }

        private void textBox_Nom_adm_Leave(object sender, EventArgs e)
        {
            if (textBox_Nom_adm.Text == "")
            {
                textBox_Nom_adm.Text = " Nom Administrateur";
                textBox_Nom_adm.ForeColor = Color.DarkGray;
            }
        }

        private void textBox_mp_adm_Enter(object sender, EventArgs e)
        {
            if (textBox_mp_adm.Text == " Mot de passe")
            {
                textBox_mp_adm.Text = "";
                textBox_mp_adm.ForeColor = Color.Black;
            }
        }

        private void textBox_mp_adm_Leave(object sender, EventArgs e)
        {
            if (textBox_mp_adm.Text == "")
            {
                textBox_mp_adm.Text = " Mot de passe";
                textBox_mp_adm.ForeColor = Color.DarkGray;
            }
        }

        private void textBox_Nom_utl_Enter(object sender, EventArgs e)
        {
            if (textBox_Nom_utl.Text == " Nom Utilisateur")
            {
                textBox_Nom_utl.Text = "";
                textBox_Nom_utl.ForeColor = Color.Black;
            }
        }

        private void textBox_Nom_utl_Leave(object sender, EventArgs e)
        {
            if (textBox_Nom_utl.Text == "")
            {
                textBox_Nom_utl.Text = " Nom Utilisateur";
                textBox_Nom_utl.ForeColor = Color.DarkGray;
            }
        }

        private void textBox_mp_utl_Enter(object sender, EventArgs e)
        {
            if (textBox_mp_utl.Text == " Mot de passe")
            {
                textBox_mp_utl.Text = "";
                textBox_mp_utl.ForeColor = Color.Black;
            }
        }

        private void textBox_mp_utl_Leave(object sender, EventArgs e)
        {
            if (textBox_mp_utl.Text == "")
            {
                textBox_mp_utl.Text = " Mot de passe";
                textBox_mp_utl.ForeColor = Color.DarkGray;
            }
        }

        private void btn_compte_Click(object sender, EventArgs e)
        {
            string nomAdmin = textBox_Nom_adm.Text;
            string codeAdmin = textBox_mp_adm.Text;
            if(nomAdmin.Equals("")|| codeAdmin.Equals(""))
            {
                MessageBox.Show("entree nom Admin et code Admin valide");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial Catalog=LogicielDePaiement;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Logiin",conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
          
            if (!rd.HasRows)
            {
                MessageBox.Show("nom Admin ou code Admin n'est pas valide");
                conn.Close();
                return;
            }
            while (rd.Read())
            {
                if(!rd[0].ToString().Equals(nomAdmin) || !rd[1].ToString().Equals(codeAdmin))
                {
                    MessageBox.Show("nom Admin ou code Admin n'est pas valide");
                    conn.Close();
                    return;
                }
                break;
            }
            rd.Close();
            cmd = new SqlCommand("insert into Logiin values (@nom,@code)",conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("nom", textBox_Nom_utl.Text);
            cmd.Parameters.AddWithValue("code", textBox_mp_utl.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
