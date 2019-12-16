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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public static string username;
        public static string userN;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial" + " Catalog=LogicielDePaiement;Integrated Security=True");

        private void textBox_user_Enter_1(object sender, EventArgs e)
        {
            if (textBox_user.Text == " Nom Utilisateur")
            {
                textBox_user.Text = "";
                textBox_user.ForeColor = Color.Black;
            }
        }

        private void textBox_user_Leave_1(object sender, EventArgs e)
        {
            if (textBox_user.Text == "")
            {
                textBox_user.Text = " Nom Utilisateur";
                textBox_user.ForeColor = Color.Silver;
            }
        }

        private void textBox_Password_Enter_1(object sender, EventArgs e)
        {
            if (textBox_Password.Text == " Mot de Passe")
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Password_Leave_1(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            { 
                textBox_Password.Text = " Mot de Passe";
                textBox_Password.ForeColor = Color.Silver;
                textBox_Password.UseSystemPasswordChar = false;
            }
        }

        private void button_Login_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string sq = "select * from Logiin where userName=@user and Passeword=@pass";
            SqlCommand cmd = new SqlCommand(sq, conn);
            
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("user", textBox_user.Text);
            cmd.Parameters.AddWithValue("pass", textBox_Password.Text);
            cmd.ExecuteNonQuery();
            username = textBox_user.Text;
            userN = textBox_user.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Form2 inf = new Form2();
                this.Hide();
                inf.Show();
            }
            else
            {
               // if (textBox_user.Text == "")
                //{
                    MessageBox.Show("Enter Your Username & Password to login", "Empty Username ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                    //if (textBox_Password.Text == "")
               // {
                   // MessageBox.Show("Enter Your Password to login", "Empty Password ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //MessageBox.Show("hh");
            }

            conn.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            foreach (CheckBox r in groupBox3.Controls)
                if (r.Checked)
                {
                    textBox_Password.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox_Password.UseSystemPasswordChar = true;
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }
    }
}
