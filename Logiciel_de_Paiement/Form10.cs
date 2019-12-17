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
    }
}
