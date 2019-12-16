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
    public partial class Form4 : Form
    {
        private static int numF = 1;
        public Form4()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial" + " Catalog=LogicielDePaiement;Integrated Security=True");

        private void tb_Especes_Fr_Enter(object sender, EventArgs e)
        {
            if (tb_Especes_Fr.Text == "0")
            {
                tb_Especes_Fr.Text = "";
                tb_Especes_Fr.ForeColor = Color.Black;
            }
        }

        private void tb_Especes_Fr_Leave(object sender, EventArgs e)
        {
            if (tb_Especes_Fr.Text == "")
            {
                tb_Especes_Fr.Text = "0";
                tb_Especes_Fr.ForeColor = Color.White;
            }
        }

        private void tb_Especes_Sc_Enter(object sender, EventArgs e)
        {
            if (tb_Especes_Sc.Text == "0")
            {
                tb_Especes_Sc.Text = "";
                tb_Especes_Sc.ForeColor = Color.Black;
            }
        }

        private void tb_Especes_Sc_Leave(object sender, EventArgs e)
        {
            if (tb_Especes_Sc.Text == "")
            {
                tb_Especes_Sc.Text = "0";
                tb_Especes_Sc.ForeColor = Color.White;
            }
        }

        private void tb_Especes_Tr_Enter(object sender, EventArgs e)
        {
            if (tb_Especes_Tr.Text == "0")
            {
                tb_Especes_Tr.Text = "";
                tb_Especes_Tr.ForeColor = Color.Black;
            }
        }

        private void tb_Especes_Tr_Leave(object sender, EventArgs e)
        {
            if (tb_Especes_Tr.Text == "")
            {
                tb_Especes_Tr.Text = "0";
                tb_Especes_Tr.ForeColor = Color.White;
            }
        }

        private void tb_Especes_Ps1_Enter(object sender, EventArgs e)
        {
            if (tb_Especes_Ps1.Text == "0")
            {
                tb_Especes_Ps1.Text = "";
                tb_Especes_Ps1.ForeColor = Color.Black;
            }
        }

        private void tb_Especes_Ps1_Leave(object sender, EventArgs e)
        {
            if (tb_Especes_Ps1.Text == "")
            {
                tb_Especes_Ps1.Text = "0";
                tb_Especes_Ps1.ForeColor = Color.White;
            }
        }

        private void tb_Especes_Ps2_Enter(object sender, EventArgs e)
        {
            if (tb_Especes_Ps2.Text == "0")
            {
                tb_Especes_Ps2.Text = "";
                tb_Especes_Ps2.ForeColor = Color.Black;
            }
        }

        private void tb_Especes_Ps2_Leave(object sender, EventArgs e)
        {
            if (tb_Especes_Ps2.Text == "")
            {
                tb_Especes_Ps2.Text = "0";
                tb_Especes_Ps2.ForeColor = Color.White;
            }
        }

        private void tb_Especes_Ps3_Enter(object sender, EventArgs e)
        {
            if (tb_Especes_Ps3.Text == "0")
            {
                tb_Especes_Ps3.Text = "";
                tb_Especes_Ps3.ForeColor = Color.Black;
            }
        }

        private void tb_Especes_Ps3_Leave(object sender, EventArgs e)
        {
            if (tb_Especes_Ps3.Text == "")
            {
                tb_Especes_Ps3.Text = "0";
                tb_Especes_Ps3.ForeColor = Color.White;
            }
        }

        private void tb_Cheque_Fr_Enter(object sender, EventArgs e)
        {
            if (tb_Cheque_Fr.Text == "0")
            {
                tb_Cheque_Fr.Text = "";
                tb_Cheque_Fr.ForeColor = Color.Black;
            }
        }

        private void tb_Cheque_Fr_Leave(object sender, EventArgs e)
        {
            if (tb_Cheque_Fr.Text == "")
            {
                tb_Cheque_Fr.Text = "0";
                tb_Cheque_Fr.ForeColor = Color.White;
            }
        }

        private void tb_Cheque_Sc_Enter_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Sc.Text == "0")
            {
                tb_Cheque_Sc.Text = "";
                tb_Cheque_Sc.ForeColor = Color.Black;
            }
        }

        private void tb_Cheque_Sc_Leave(object sender, EventArgs e)
        {
            if (tb_Cheque_Sc.Text == "")
            {
                tb_Cheque_Sc.Text = "0";
                tb_Cheque_Sc.ForeColor = Color.White;
            }
        }

        private void tb_Cheque_Tr_Enter(object sender, EventArgs e)
        {

            if (tb_Cheque_Tr.Text == "0")
            {
                tb_Cheque_Tr.Text = "";
                tb_Cheque_Tr.ForeColor = Color.Black;
            }
        }

        private void tb_Cheque_Tr_Leave(object sender, EventArgs e)
        {
            if (tb_Cheque_Tr.Text == "")
            {
                tb_Cheque_Tr.Text = "0";
                tb_Cheque_Tr.ForeColor = Color.White;
            }
        }

        private void tb_Cheque_Ps1_Enter_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Ps1.Text == "0")
            {
                tb_Cheque_Ps1.Text = "";
                tb_Cheque_Ps1.ForeColor = Color.Black;
            }
        }

        private void tb_Cheque_Ps1_Leave_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Ps1.Text == "")
            {
                tb_Cheque_Ps1.Text = "0";
                tb_Cheque_Ps1.ForeColor = Color.White;
            }
        }

        private void tb_Cheque_Ps2_Enter_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Ps2.Text == "0")
            {
                tb_Cheque_Ps2.Text = "";
                tb_Cheque_Ps2.ForeColor = Color.Black;
            }
        }

        private void tb_Cheque_Ps2_Leave_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Ps2.Text == "")
            {
                tb_Cheque_Ps2.Text = "0";
                tb_Cheque_Ps2.ForeColor = Color.White;
            }
        }

        private void tb_Cheque_Ps3_Enter_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Ps3.Text == "0")
            {
                tb_Cheque_Ps3.Text = "";
                tb_Cheque_Ps3.ForeColor = Color.Black;
            }
        }

        private void tb_Cheque_Ps3_Leave_1(object sender, EventArgs e)
        {
            if (tb_Cheque_Ps3.Text == "")
            {
                tb_Cheque_Ps3.Text = "0";
                tb_Cheque_Ps3.ForeColor = Color.White;
            }
        }

        private void tb_Trait_Fr_Enter_1(object sender, EventArgs e)
        {
            if (tb_Trait_Fr.Text == "0")
            {
                tb_Trait_Fr.Text = "";
                tb_Trait_Fr.ForeColor = Color.Black;
            }
        }

        private void tb_Trait_Fr_Leave_1(object sender, EventArgs e)
        {
            if (tb_Trait_Fr.Text == "")
            {
                tb_Trait_Fr.Text = "0";
                tb_Trait_Fr.ForeColor = Color.White;
            }
        }

        private void tb_Trait_Sc_Enter_1(object sender, EventArgs e)
        {
            if (tb_Trait_Sc.Text == "0")
            {
                tb_Trait_Sc.Text = "";
                tb_Trait_Sc.ForeColor = Color.Black;
            }
        }

        private void tb_Trait_Sc_Leave_1(object sender, EventArgs e)
        {
            if (tb_Trait_Sc.Text == "")
            {
                tb_Trait_Sc.Text = "0";
                tb_Trait_Sc.ForeColor = Color.White;
            }
        }

        private void tb_Trait_Tr_Enter_1(object sender, EventArgs e)
        {
            if (tb_Trait_Tr.Text == "0")
            {
                tb_Trait_Tr.Text = "";
                tb_Trait_Tr.ForeColor = Color.Black;
            }
        }

        private void tb_Trait_Tr_Leave_1(object sender, EventArgs e)
        {
            if (tb_Trait_Tr.Text == "")
            {
                tb_Trait_Tr.Text = "0";
                tb_Trait_Tr.ForeColor = Color.White;
            }
        }

        private void tb_Trait_Ps1_Enter_1(object sender, EventArgs e)
        {
            if (tb_Trait_Ps1.Text == "0")
            {
                tb_Trait_Ps1.Text = "";
                tb_Trait_Ps1.ForeColor = Color.Black;
            }
        }

        private void tb_Trait_Ps1_Leave_1(object sender, EventArgs e)
        {
            if (tb_Trait_Ps1.Text == "")
            {
                tb_Trait_Ps1.Text = "0";
                tb_Trait_Ps1.ForeColor = Color.White;
            }
        }

        private void tb_Trait_Ps2_Enter_1(object sender, EventArgs e)
        {
            if (tb_Trait_Ps2.Text == "0")
            {
                tb_Trait_Ps2.Text = "";
                tb_Trait_Ps2.ForeColor = Color.Black;
            }
        }

        private void tb_Trait_Ps2_Leave_1(object sender, EventArgs e)
        {
            if (tb_Trait_Ps2.Text == "")
            {
                tb_Trait_Ps2.Text = "0";
                tb_Trait_Ps2.ForeColor = Color.White;
            }
        }

        private void tb_Trait_Ps3_Enter_1(object sender, EventArgs e)
        {
            if (tb_Trait_Ps3.Text == "0")
            {
                tb_Trait_Ps3.Text = "";
                tb_Trait_Ps3.ForeColor = Color.Black;
            }
        }

        private void tb_Trait_Ps3_Leave_1(object sender, EventArgs e)
        {
            if (tb_Trait_Ps3.Text == "")
            {
                tb_Trait_Ps3.Text = "0";
                tb_Trait_Ps3.ForeColor = Color.White;
            }
        }

        private void tb_Virement_Fr_Enter_1(object sender, EventArgs e)
        {
            if (tb_Virement_Fr.Text == "0")
            {
                tb_Virement_Fr.Text = "";
                tb_Virement_Fr.ForeColor = Color.Black;
            }
        }

        private void tb_Virement_Fr_Leave_1(object sender, EventArgs e)
        {
            if (tb_Virement_Fr.Text == "")
            {
                tb_Virement_Fr.Text = "0";
                tb_Virement_Fr.ForeColor = Color.White;
            }
        }

        private void tb_Virement_Sc_Enter_1(object sender, EventArgs e)
        {
            if (tb_Virement_Sc.Text == "0")
            {
                tb_Virement_Sc.Text = "";
                tb_Virement_Sc.ForeColor = Color.Black;
            }
        }

        private void tb_Virement_Sc_Leave_1(object sender, EventArgs e)
        {
            if (tb_Virement_Sc.Text == "")
            {
                tb_Virement_Sc.Text = "0";
                tb_Virement_Sc.ForeColor = Color.White;
            }
        }

        private void tb_Virement_Tr_Enter_1(object sender, EventArgs e)
        {
            if (tb_Virement_Tr.Text == "0")
            {
                tb_Virement_Tr.Text = "";
                tb_Virement_Tr.ForeColor = Color.Black;
            }
        }

        private void tb_Virement_Tr_Leave_1(object sender, EventArgs e)
        {
            if (tb_Virement_Tr.Text == "")
            {
                tb_Virement_Tr.Text = "0";
                tb_Virement_Tr.ForeColor = Color.White;
            }
        }

        private void tb_Virement_Ps1_Enter_1(object sender, EventArgs e)
        {
            if (tb_Virement_Ps1.Text == "0")
            {
                tb_Virement_Ps1.Text = "";
                tb_Virement_Ps1.ForeColor = Color.Black;
            }
        }

        private void tb_Virement_Ps1_Leave_1(object sender, EventArgs e)
        {
            if (tb_Virement_Ps1.Text == "")
            {
                tb_Virement_Ps1.Text = "0";
                tb_Virement_Ps1.ForeColor = Color.White;
            }
        }

        private void tb_Virement_Ps2_Enter_1(object sender, EventArgs e)
        {
            if (tb_Virement_Ps2.Text == "0")
            {
                tb_Virement_Ps2.Text = "";
                tb_Virement_Ps2.ForeColor = Color.Black;
            }
        }

        private void tb_Virement_Ps2_Leave_1(object sender, EventArgs e)
        {
            if (tb_Virement_Ps2.Text == "")
            {
                tb_Virement_Ps2.Text = "0";
                tb_Virement_Ps2.ForeColor = Color.White;
            }
        }

        private void tb_Virement_Ps3_Enter_1(object sender, EventArgs e)
        {
            if (tb_Virement_Ps3.Text == "0")
            {
                tb_Virement_Ps3.Text = "";
                tb_Virement_Ps3.ForeColor = Color.Black;
            }
        }

        private void tb_Virement_Ps3_Leave_1(object sender, EventArgs e)
        {
            if (tb_Virement_Ps3.Text == "")
            {
                tb_Virement_Ps3.Text = "0";
                tb_Virement_Ps3.ForeColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int idRecherche = int.Parse(TextBox_Matricule.Text);
            int id_Rech = int.Parse(TextBox_Matricule.Text);

            SqlCommand cmd = new SqlCommand("select * from etudiant where Matricule='" + idRecherche + "' ", conn);
            SqlCommand cmmd = new SqlCommand("select * from Detaile where Matricule='" + id_Rech + "' ", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label_Nom.Text = dr[1].ToString();
                label_Prenom.Text = dr[2].ToString();
                label_Classe.Text = dr[6].ToString();
                label_AnnesSc.Text = dr[7].ToString();

            }
            dr.Close();
            cmd.Dispose();
            SqlDataReader drr = cmmd.ExecuteReader();
            while (drr.Read())
            {
                label_Mt_Fr.Text = String.Format("{0:0.00}", drr[1]);
                label_Mt_Sc.Text = String.Format("{0:0.00}", drr[7]);
                label_Mt_Tr.Text = String.Format("{0:0.00}", drr[13]);
                label_Mt_Ps1.Text = String.Format("{0:0.00}", drr[19]);
                label_Mt_Ps2.Text = String.Format("{0:0.00}", drr[25]);
                label_Mt_Ps3.Text = String.Format("{0:0.00}", drr[31]);
                label_Savp_Fr.Text = String.Format("{0:0.00}", drr[5]);
                label_Savp_Sc.Text = String.Format("{0:0.00}", drr[11]);
                label_Savp_Tr.Text = String.Format("{0:0.00}", drr[17]);
                label_Savp_Ps1.Text = String.Format("{0:0.00}", drr[23]);
                label_Savp_Ps2.Text = String.Format("{0:0.00}", drr[29]);
                label_Savp_Ps3.Text = String.Format("{0:0.00}", drr[35]);
            }
            drr.Close();
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadMethod();
        }

        private void loadMethod()
        {
            TextBox_Matricule.Focus();
            label60.Text = Form1.userN;
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select MAX(N_Reçu) from Paiement", conn);
            SqlDataReader rd = sqlCmd.ExecuteReader();

            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    if (rd[0].ToString() != "")
                    {
                        numF = (int)rd[0] + 1;

                    }
                    else
                    {
                        numF = 1;

                    }
                }
                // 
            }

            conn.Close();

            label_NumeroRecu.Text = numF.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void chaineVide()
        {
            if(label_Totpy_Fr.Text== ".............")
            {
                label_Totpy_Fr.Text = "0";
            }
            else if (label_Totpy_Sc.Text == ".............")
            {
                label_Totpy_Sc.Text = "0";
            }
            else if (label_Totpy_Tr.Text == ".............")
            {
                label_Totpy_Tr.Text = "0";
            }
            else if (label_Totpy_Ps1.Text == ".............")
            {
                label_Totpy_Ps1.Text = "0";
            }
            else if (label_Totpy_Ps2.Text == ".............")
            {
                label_Totpy_Ps2.Text = "0";
            }
            else if (label_Totpy_Ps3.Text == ".............") 
            {
                label_Totpy_Ps3.Text = "0";
            }
            else if (label_Sapp_Fr.Text == ".............")
            {
                label_Sapp_Fr.Text = "0";
            }
            else if (label_Sapp_Sc.Text == ".............")
            {
                label_Sapp_Sc.Text = "0";
            }
            else if (label_Sapp_Tr.Text == ".............")
            {
                label_Sapp_Tr.Text = "0";
            }
            else if (label_Sapp_Ps1.Text == ".............")
            {
                label_Sapp_Ps1.Text = "0";
            }
            else if (label_Sapp_Ps2.Text == ".............")
            {
                label_Sapp_Ps2.Text = "0";
            }
            else if (label_Sapp_Ps3.Text == ".............")
            {
                label_Sapp_Ps3.Text = "0";
            }
            else if (label_pyEspeces.Text == ".............")
            {
                label_pyEspeces.Text = "0";
            }
            else if (label_pyCheque.Text == ".............")
            {
                label_pyCheque.Text = "0";
            }
            else if (label_pyTraite.Text == ".............")
            {
                label_pyTraite.Text = "0";
            }
            else if (label_pyVirement.Text == ".............")
            {
                label_pyVirement.Text = "0";
            }
        }
        private void Button_VALIDER_Click(object sender, EventArgs e)
        {
            if (TextBox_Matricule.Text == "")
            {
                MessageBox.Show("error");
            }
            else
            {
                conn.Open();

                string sql = "insert into Paiement(N_Reçu, Matricule,Nom_Complet, classe,Années_Sc,date_Paiement,Nom_Utl,Detaile,Espèces,date_Vers_Espèces,chèque,N_chèque,date_éch_chèq,Traite,N_Traite,date_éch_Trt,Virement,date_Virement,Bnq_Remise_Vrm,TotalPayé)";
                sql = sql + "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p18,@p19,@p20,@p25,@p26,@p27,@p28)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                chaineVide();
                cmd.Parameters.AddWithValue("p1", numF);
                cmd.Parameters.AddWithValue("p2", TextBox_Matricule.Text);
                cmd.Parameters.AddWithValue("p3", label_Nom.Text + " " + label_Prenom.Text);
                cmd.Parameters.AddWithValue("p4", label_Classe.Text);
                cmd.Parameters.AddWithValue("p5", label_AnnesSc.Text);
                cmd.Parameters.AddWithValue("p6", dateTimePicker_Djeur.Value);
                cmd.Parameters.AddWithValue("p7", label60.Text);
                cmd.Parameters.AddWithValue("p8", textBox_Commantaire.Text);
                double P_Es = double.Parse(label_pyEspeces.Text);
                double P_ch = double.Parse(label_pyCheque.Text);
                double P_Tr = double.Parse(label_pyTraite.Text);
                double P_Vm = double.Parse(label_pyVirement.Text);
                cmd.Parameters.AddWithValue("p9", P_Es);
                cmd.Parameters.AddWithValue("p10", dateTimePicker_Es.Value);
                cmd.Parameters.AddWithValue("p11", P_ch);
                cmd.Parameters.AddWithValue("p12", tb_Ncheque_Ch.Text);
                cmd.Parameters.AddWithValue("p13", dateTimePicker_Ch.Value);
                cmd.Parameters.AddWithValue("p18", P_Tr);
                cmd.Parameters.AddWithValue("p19", tb_Ncheque_Tr.Text);
                cmd.Parameters.AddWithValue("p20", dateTimePicker_Tr.Value);
                cmd.Parameters.AddWithValue("p25", P_Vm);
                cmd.Parameters.AddWithValue("p26", dateTimePicker_Vm.Value);
                cmd.Parameters.AddWithValue("p27", dateTimePicker_Vm.Value);
                cmd.Parameters.AddWithValue("p28", label_TotalPaye.Text);
                cmd.ExecuteNonQuery();
                SqlCommand sqlcmd = new SqlCommand("select Total_Fr,Solde_Fr,Total_Sc,Solde_Sc,Total_Tr,Solde_Tr,Total_Ps1 ,Solde_Ps1 ,Total_Ps2,Solde_Ps2,Total_Ps3,Solde_Ps3   from Detaile where Matricule = @mtr", conn);
                sqlcmd.Parameters.AddWithValue("@mtr", TextBox_Matricule.Text);
                SqlDataReader rdcmd = sqlcmd.ExecuteReader();
                double totfr = 0;
                double soldefr = 0;
                double totSc = 0;
                double soldeSc = 0;
                double totTr = 0;
                double soldeTr = 0;
                double totPs1 = 0;
                double soldePs1 = 0;
                double totPs2 = 0;
                double soldePs2 = 0;
                double totPs3 = 0;
                double soldePs3 = 0;
                while (rdcmd.Read())
                {
                    totfr = Convert.ToDouble(rdcmd[0]);
                    soldefr = Convert.ToDouble(rdcmd[1]);
                    totSc = Convert.ToDouble(rdcmd[2]);
                    soldeSc = Convert.ToDouble(rdcmd[3]);
                    totTr = Convert.ToDouble(rdcmd[4]);
                    soldeTr = Convert.ToDouble(rdcmd[5]);
                    totPs1 = Convert.ToDouble(rdcmd[6]);
                    soldePs1 = Convert.ToDouble(rdcmd[7]);
                    totPs2 = Convert.ToDouble(rdcmd[8]);
                    soldePs2 = Convert.ToDouble(rdcmd[9]);
                    totPs3 = Convert.ToDouble(rdcmd[10]);
                    soldePs3 = Convert.ToDouble(rdcmd[11]);
                }

                chaineVide();
                rdcmd.Close();
                SqlCommand cmdupdte = new SqlCommand("update Detaile set  Total_Fr = @totFr,Solde_Fr = @soldeFr ,   Total_Sc = @totSc,Solde_Sc = @soldeSc   ,Total_Tr = @totTr,Solde_Tr = @soldeTr    ,  Total_Ps1 = @totPs1,Solde_Ps1 = @soldePs1   ,Total_Ps2 = @totPs2,Solde_Ps2 = @soldePs2   ,Total_Ps3 = @totPs3,Solde_Ps3 = @soldePs3      where Matricule = @mtr", conn);

                //Frais d'inscription
                cmdupdte.Parameters.AddWithValue("@totFr", double.Parse(label_Totpy_Fr.Text) + totfr);
                cmdupdte.Parameters.AddWithValue("@soldeFr", soldefr - double.Parse(label_Totpy_Fr.Text));
                //Scolarité
                cmdupdte.Parameters.AddWithValue("@totSc", double.Parse(label_Totpy_Sc.Text) + totSc);
                cmdupdte.Parameters.AddWithValue("@soldeSc", soldeSc - double.Parse(label_Totpy_Sc.Text));
                //Transport
                cmdupdte.Parameters.AddWithValue("@totTr", double.Parse(label_Totpy_Tr.Text) + totTr);
                cmdupdte.Parameters.AddWithValue("@soldeTr", soldeTr - double.Parse(label_Totpy_Tr.Text));
                //Prestation1
                cmdupdte.Parameters.AddWithValue("@totPs1", double.Parse(label_Totpy_Ps1.Text) + totPs1);
                cmdupdte.Parameters.AddWithValue("@soldePs1", soldePs1 - double.Parse(label_Totpy_Ps1.Text));
                //Prestation2
                cmdupdte.Parameters.AddWithValue("@totPs2", double.Parse(label_Totpy_Ps2.Text) + totPs2);
                cmdupdte.Parameters.AddWithValue("@soldePs2", soldePs2 - double.Parse(label_Totpy_Ps2.Text));
                //Prestation3
                cmdupdte.Parameters.AddWithValue("@totPs3", double.Parse(label_Totpy_Ps3.Text) + totPs3);
                cmdupdte.Parameters.AddWithValue("@soldePs3", soldePs3 - double.Parse(label_Totpy_Ps3.Text));


                cmdupdte.Parameters.AddWithValue("@mtr", TextBox_Matricule.Text);
                cmdupdte.ExecuteNonQuery();

                MessageBox.Show("Paiement Valider");
                conn.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button_Vider_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            loadMethod();
        }

        private void calculeEsp()
        {
            try
            {
                double fr = double.Parse(tb_Especes_Fr.Text.Equals("") ? "0" : tb_Especes_Fr.Text);
                double sc = double.Parse(tb_Especes_Sc.Text.Equals("") ? "0" : tb_Especes_Sc.Text);
                double tr = double.Parse(tb_Especes_Tr.Text.Equals("") ? "0" : tb_Especes_Tr.Text);
                double ps1 = double.Parse(tb_Especes_Ps1.Text.Equals("") ? "0" : tb_Especes_Ps1.Text);
                double ps2 = double.Parse(tb_Especes_Ps2.Text.Equals("") ? "0" : tb_Especes_Ps2.Text);
                double ps3 = double.Parse(tb_Especes_Ps3.Text.Equals("") ? "0" : tb_Especes_Ps3.Text);

                double TotalEps = fr + sc + tr + ps1 + ps2 + ps3;
                //if (TotalEps == 0)
                //{
                //    label_pyEspeces.Text = ".............";
                //    calculeTotal();

                //    return;
                //}
                label_pyEspeces.Text = String.Format("{0:0.00}", TotalEps);
                calculeTotal();

            }
            catch(Exception ex)
            {

            }
        }

        private void calculeChèq()
        {
            try
            {
                double fr = double.Parse(tb_Cheque_Fr.Text.Equals("") ? "0" : tb_Cheque_Fr.Text);
                double sc = double.Parse(tb_Cheque_Sc.Text.Equals("") ? "0" : tb_Cheque_Sc.Text);
                double tr = double.Parse(tb_Cheque_Tr.Text.Equals("") ? "0" : tb_Cheque_Tr.Text);
                double ps1 = double.Parse(tb_Cheque_Ps1.Text.Equals("") ? "0" : tb_Cheque_Ps1.Text);
                double ps2 = double.Parse(tb_Cheque_Ps2.Text.Equals("") ? "0" : tb_Cheque_Ps2.Text);
                double ps3 = double.Parse(tb_Cheque_Ps3.Text.Equals("") ? "0" : tb_Cheque_Ps3.Text);

                double TotalEcheq = fr + sc + tr + ps1 + ps2 + ps3;
                //if (TotalEcheq == 0)
                //{
                //    label_pyCheque.Text = ".............";
                //    calculeTotal();

                //    return;
                //}
                label_pyCheque.Text = String.Format("{0:0.00}", TotalEcheq);
                calculeTotal();

            }
            catch (Exception ex)
            {

            }
        }

        private void calculeTraite()
        {
            try
            {
                double fr = double.Parse(tb_Trait_Fr.Text.Equals("") ? "0" : tb_Trait_Fr.Text);
                double sc = double.Parse(tb_Trait_Sc.Text.Equals("") ? "0" : tb_Trait_Sc.Text);
                double tr = double.Parse(tb_Trait_Tr.Text.Equals("") ? "0" : tb_Trait_Tr.Text);
                double ps1 = double.Parse(tb_Trait_Ps1.Text.Equals("") ? "0" : tb_Trait_Ps1.Text);
                double ps2 = double.Parse(tb_Trait_Ps2.Text.Equals("") ? "0" : tb_Trait_Ps2.Text);
                double ps3 = double.Parse(tb_Trait_Ps3.Text.Equals("") ? "0" : tb_Trait_Ps3.Text);

                double TotalTrait = fr + sc + tr + ps1 + ps2 + ps3;
                //if (TotalTrait == 0)
                //{
                //    label_pyTraite.Text = ".............";
                //    calculeTotal();

                //    return;
                //}
                label_pyTraite.Text = String.Format("{0:0.00}", TotalTrait);
                calculeTotal();

            }
            catch (Exception ex)
            {

            }
        }

        private void calculeTVirement()
        {
            try
            {
                double fr = double.Parse(tb_Virement_Fr.Text.Equals("") ? "0" : tb_Virement_Fr.Text);
                double sc = double.Parse(tb_Virement_Sc.Text.Equals("") ? "0" : tb_Virement_Sc.Text);
                double tr = double.Parse(tb_Virement_Tr.Text.Equals("") ? "0" : tb_Virement_Tr.Text);
                double ps1 = double.Parse(tb_Virement_Ps1.Text.Equals("") ? "0" : tb_Virement_Ps1.Text);
                double ps2 = double.Parse(tb_Virement_Ps2.Text.Equals("") ? "0" : tb_Virement_Ps2.Text);
                double ps3 = double.Parse(tb_Virement_Ps3.Text.Equals("") ? "0" : tb_Virement_Ps3.Text);

                double TotalVirement = fr + sc + tr + ps1 + ps2 + ps3;
                //if (TotalVirement == 0)
                //{
                //    label_pyVirement.Text = ".............";
                //    calculeTotal();

                //    return;
                //}
                label_pyVirement.Text = String.Format("{0:0.00}", TotalVirement);
                calculeTotal();

            }
            catch (Exception ex)
            {

            }
        }

        private void calculeTotal()
        {
            try
            {
                double TotalEsp = double.Parse(label_pyEspeces.Text.Equals(".............") ? "0" : label_pyEspeces.Text);
                double TotalCheq = double.Parse(label_pyCheque.Text.Equals(".............") ? "0" : label_pyCheque.Text);
                double TotalTr = double.Parse(label_pyTraite.Text.Equals(".............") ? "0" : label_pyTraite.Text);
                double TotalVr = double.Parse(label_pyVirement.Text.Equals(".............") ? "0" : label_pyVirement.Text);
                double ttl = TotalEsp + TotalCheq + TotalTr + TotalVr;
                //if (ttl == 0)
                //{
                //    label_TotalPaye.Text = ".............";
                //    return;
                //}

                label_TotalPaye.Text = String.Format("{0:0.00}",ttl); 
            }
            catch (Exception ex)
            {

            }
        }


        private void calculeFr()
        {
            
            try
            {

            
            double u = double.Parse(label_Savp_Fr.Text);
            double F = double.Parse(tb_Especes_Fr.Text.Equals("") ? "0" : tb_Especes_Fr.Text);
            double R = double.Parse(tb_Cheque_Fr.Text.Equals("") ? "0" : tb_Cheque_Fr.Text);
            double t = double.Parse(tb_Trait_Fr.Text.Equals("") ? "0" : tb_Trait_Fr.Text);
            double o = double.Parse(tb_Virement_Fr.Text.Equals("") ? "0" : tb_Virement_Fr.Text);
            double TotalFr = (F + R + t + o);
            double TotalFrais = (u - F - R - t - o);
           

            if (TotalFr > double.Parse(label_Savp_Fr.Text))
            {
                MessageBox.Show("error","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                    calculeTotal();

                    //if (TotalFr == 0)
                    //{
                        
                    //    TotalFrais = 0;
                    //    label_Totpy_Fr.Text = ".............";
                    //    label_Sapp_Fr.Text = ".............";
                    //    return;
                    //}
                    label_Totpy_Fr.Text = String.Format("{0:0.00}", TotalFr);
                label_Sapp_Fr.Text = String.Format("{0:0.00}", TotalFrais);
            }
            }
            catch (Exception ex)
            {

            }
        }

      
        private void tb_Especes_Fr_TextChanged(object sender, EventArgs e)
        {
            //Solde avant paiement Frais
            calculeFr();
            calculeEsp();
        }
        private void tb_Cheque_Fr_TextChanged(object sender, EventArgs e)
        {
            //Solde avant paiement Frais
            calculeFr();
            calculeChèq();
        }

        private void tb_Trait_Fr_TextChanged(object sender, EventArgs e)
        {
            //Solde avant paiement Frais
            calculeFr();
            calculeTraite();
        }

        private void tb_Virement_Fr_TextChanged(object sender, EventArgs e)
        {
            //Solde avant paiement Frais
            calculeFr();
            calculeTVirement();
        }
        private void calculeSc()
        {
            try
            {

           
            double u = double.Parse(label_Savp_Sc.Text);
            double F = double.Parse(tb_Especes_Sc.Text.Equals("") ? "0" : tb_Especes_Sc.Text);
            double R = double.Parse(tb_Cheque_Sc.Text.Equals("") ? "0" : tb_Cheque_Sc.Text);
            double t = double.Parse(tb_Trait_Sc.Text.Equals("") ? "0" : tb_Trait_Sc.Text);
            double o = double.Parse(tb_Virement_Sc.Text.Equals("") ? "0" : tb_Virement_Sc.Text);
            double TotalSc = (F + R + t + o);
            double TotalScolarite = (u - F - R - t - o);

            if (TotalSc > double.Parse(label_Savp_Sc.Text))
            {
                MessageBox.Show("error", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if (TotalSc == 0)
                //    {
                        
                //        TotalScolarite = 0;
                //        label_Totpy_Sc.Text = ".............";
                //        label_Sapp_Sc.Text = ".............";
                //        return;
                //    }
                label_Totpy_Sc.Text = String.Format("{0:0.00}", TotalSc);
                label_Sapp_Sc.Text = String.Format("{0:0.00}", TotalScolarite);
            }
            }
            catch (Exception ex)
            {

            }

        }
        private void tb_Especes_Sc_TextChanged(object sender, EventArgs e)
        {
            calculeSc();
            calculeEsp();
        }

        private void tb_Cheque_Sc_TextChanged(object sender, EventArgs e)
        {
            calculeSc();
            calculeChèq();

        }

        private void tb_Trait_Sc_TextChanged(object sender, EventArgs e)
        {
            calculeSc();
            calculeTraite();
        }

        private void tb_Virement_Sc_TextChanged(object sender, EventArgs e)
        {
            calculeSc();
            calculeTVirement();
        }
        private void calculeTr()
        {
            try
            {
                double u = double.Parse(label_Savp_Tr.Text);
                double F = double.Parse(tb_Especes_Tr.Text.Equals("") ? "0" : tb_Especes_Tr.Text);
                double R = double.Parse(tb_Cheque_Tr.Text.Equals("") ? "0" : tb_Cheque_Tr.Text);
                double t = double.Parse(tb_Trait_Tr.Text.Equals("") ? "0" : tb_Trait_Tr.Text);
                double o = double.Parse(tb_Virement_Tr.Text.Equals("") ? "0" : tb_Virement_Tr.Text);
                double TotalTr = (F + R + t + o);
                double TotalTransport = (u - F - R - t - o);

                if (TotalTr > double.Parse(label_Savp_Tr.Text))
                {
                    MessageBox.Show("error", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    calculeTotal();

                    //if (TotalTr == 0)
                    //{

                    //    TotalTransport = 0;
                    //    label_Totpy_Tr.Text = ".............";
                    //    label_Sapp_Tr.Text = ".............";
                    //    return;
                    //}
                    label_Totpy_Tr.Text = String.Format("{0:0.00}", TotalTr);
                    label_Sapp_Tr.Text = String.Format("{0:0.00}", TotalTransport);
                }

            }
            catch (Exception ex)
            {

            }
           
        }

        private void tb_Especes_Tr_TextChanged(object sender, EventArgs e)
        {
            calculeTr();
            calculeEsp();

        }

        private void tb_Cheque_Tr_TextChanged(object sender, EventArgs e)
        {
            calculeTr();
            calculeChèq();
        }

        private void tb_Trait_Tr_TextChanged(object sender, EventArgs e)
        {
            calculeTr();
            calculeTraite();
        }

        private void tb_Virement_Tr_TextChanged(object sender, EventArgs e)
        {
            calculeTr();
            calculeTVirement();
        }
        private void calculePs1()
        {
            try
            {
                double u = double.Parse(label_Savp_Ps1.Text);
                double F = double.Parse(tb_Especes_Ps1.Text.Equals("") ? "0" : tb_Especes_Ps1.Text);
                double R = double.Parse(tb_Cheque_Ps1.Text.Equals("") ? "0" : tb_Cheque_Ps1.Text);
                double t = double.Parse(tb_Trait_Ps1.Text.Equals("") ? "0" : tb_Trait_Ps1.Text);
                double o = double.Parse(tb_Virement_Ps1.Text.Equals("") ? "0" : tb_Virement_Ps1.Text);
                double TotalPs1 = (F + R + t + o);
                double TotalPrestation1 = (u - F - R - t - o);

                if (TotalPs1 > double.Parse(label_Savp_Ps1.Text))
                {
                    MessageBox.Show("error", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    calculeTotal();

                    //if (TotalPs1 == 0)
                    //{

                    //    TotalPrestation1 = 0;
                    //    label_Totpy_Ps1.Text = ".............";
                    //    label_Sapp_Ps1.Text = ".............";
                    //    return;
                    //}
                    label_Totpy_Ps1.Text = String.Format("{0:0.00}", TotalPs1);
                    label_Sapp_Ps1.Text = String.Format("{0:0.00}", TotalPrestation1);
                }

            }
            catch (Exception ex)
            {

            }
            
        }

        private void tb_Especes_Ps1_TextChanged(object sender, EventArgs e)
        {
            calculePs1();
            calculeEsp();

        }

        private void tb_Cheque_Ps1_TextChanged(object sender, EventArgs e)
        {
            calculePs1();
            calculeChèq();
        }

        private void tb_Trait_Ps1_TextChanged(object sender, EventArgs e)
        {
            calculePs1();
            calculeTraite();
        }

        private void tb_Virement_Ps1_TextChanged(object sender, EventArgs e)
        {
            calculePs1();
            calculeTVirement();
        }
        private void calculePs2()
        {
            try
            {
                double u = double.Parse(label_Savp_Ps2.Text);
                double F = double.Parse(tb_Especes_Ps2.Text.Equals("") ? "0" : tb_Especes_Ps2.Text);
                double R = double.Parse(tb_Cheque_Ps2.Text.Equals("") ? "0" : tb_Cheque_Ps2.Text);
                double t = double.Parse(tb_Trait_Ps2.Text.Equals("") ? "0" : tb_Trait_Ps2.Text);
                double o = double.Parse(tb_Virement_Ps2.Text.Equals("") ? "0" : tb_Virement_Ps2.Text);
                double TotalPs2 = (F + R + t + o);
                double TotalPrestation2 = (u - F - R - t - o);

                if (TotalPs2 > double.Parse(label_Savp_Ps2.Text))
                {
                    MessageBox.Show("error", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    calculeTotal();

                    //if (TotalPs2 == 0)
                    //{

                    //    TotalPrestation2 = 0;
                    //    label_Totpy_Ps2.Text = ".............";
                    //    label_Sapp_Ps2.Text = ".............";
                    //    return;
                    //}
                    label_Totpy_Ps2.Text = String.Format("{0:0.00}", TotalPs2);
                    label_Sapp_Ps2.Text = String.Format("{0:0.00}", TotalPrestation2);
                }
            }
            catch(Exception ex)
            {

            }
           

        }

        private void tb_Especes_Ps2_TextChanged(object sender, EventArgs e)
        {
            calculePs2();
            calculeEsp();

        }

        private void tb_Cheque_Ps2_TextChanged(object sender, EventArgs e)
        {
            calculePs2();
            calculeChèq();
        }

        private void tb_Trait_Ps2_TextChanged(object sender, EventArgs e)
        {
            calculePs2();
            calculeTraite();
        }

        private void tb_Virement_Ps2_TextChanged(object sender, EventArgs e)
        {
            calculePs2();
            calculeTVirement();
        }
        private void calculePs3()
        {
            try
            {
                double u = double.Parse(label_Savp_Ps3.Text);
                double F = double.Parse(tb_Especes_Ps3.Text.Equals("") ? "0" : tb_Especes_Ps3.Text);
                double R = double.Parse(tb_Cheque_Ps3.Text.Equals("") ? "0" : tb_Cheque_Ps3.Text);
                double t = double.Parse(tb_Trait_Ps3.Text.Equals("") ? "0" : tb_Trait_Ps3.Text);
                double o = double.Parse(tb_Virement_Ps3.Text.Equals("") ? "0" : tb_Virement_Ps3.Text);
                double TotalPs3 = (F + R + t + o);
                double TotalPrestation3 = (u - F - R - t - o);

                if (TotalPs3 > double.Parse(label_Savp_Ps3.Text))
                {
                    MessageBox.Show("error", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    calculeTotal();

                    //if (TotalPs3 == 0)
                    //{

                    //    TotalPrestation3 = 0;
                    //    label_Totpy_Ps3.Text = ".............";
                    //    label_Sapp_Ps3.Text = ".............";
                    //    return;
                    //}
                    label_Totpy_Ps3.Text = String.Format("{0:0.00}", TotalPs3);
                    label_Sapp_Ps3.Text = String.Format("{0:0.00}", TotalPrestation3);
                }
            }
            catch(Exception ex)
            {

            }
           

        }

        private void tb_Especes_Ps3_TextChanged(object sender, EventArgs e)
        {
            calculePs3();
            calculeEsp();

        }

        private void tb_Cheque_Ps3_TextChanged(object sender, EventArgs e)
        {
            calculePs3();
            calculeChèq();
        }

        private void tb_Trait_Ps3_TextChanged(object sender, EventArgs e)
        {
            calculePs3();
            calculeTraite();
        }

        private void tb_Virement_Ps3_TextChanged(object sender, EventArgs e)
        {
            calculePs3();
            calculeTVirement();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label_Nom_ecole.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black,10, 15);
            e.Graphics.DrawString("\n" + "école primaire à Tanger" + "\n", new Font("Century Gothic", 10), Brushes.Black, 20, 25);
            e.Graphics.DrawImage(pictureBox3.Image, 340,0,150,70) ;
            e.Graphics.DrawString(label_Ns_Arabe.Text, new Font("Arabic Typesetting", 22, FontStyle.Bold), Brushes.Black, 660, 10);
            e.Graphics.DrawString("\n" + "مدرسة إبتدائية بطنجة", new Font("Arabic Typesetting", 20), Brushes.Black, 670, 5);

            //
            e.Graphics.DrawString("\n\n\n" + "Tanger le :", new Font("Century Gothic", 10), Brushes.Black, 188,20);
            e.Graphics.DrawString("\n\n"+dateTimePicker_Djeur.Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 25);
            e.Graphics.DrawString("\n\n\n" + ": طنجة في", new Font("Arabic Typesetting", 18), Brushes.Black, 570, -15);
            //
            e.Graphics.DrawString("\n\n\n" + "Reçu de paiement N° :", new Font("Century Gothic", 10), Brushes.Black, 96, 45);
            e.Graphics.DrawString("\n" +"00"+label_NumeroRecu.Text+"/"+DateTime.Today.Year, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 70);
            e.Graphics.DrawString("\n\n\n" + ": توصيل أداء رقم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 7);
            //
            e.Graphics.DrawString("\n\n\n\n" + "Années Scolaire:", new Font("Century Gothic", 10), Brushes.Black, 140, 55);
            e.Graphics.DrawString("\n\n" + label_AnnesSc.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 74);
            e.Graphics.DrawString("\n\n\n\n" + ":السنة الدراسية", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 5);

            //  
            e.Graphics.DrawString("\n\n\n\n\n\n" + "Matricule de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 110, 45);
            e.Graphics.DrawString("\n\n\n\n" +"00"+ TextBox_Matricule.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 370, 55);
            e.Graphics.DrawString("\n\n\n\n\n\n" + ":(رقم تسجيل التلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570,-30);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n" + "Nom et Prénom de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 65, 55);
            e.Graphics.DrawString("\n\n\n\n\n" + label_Nom.Text+" "+ label_Prenom.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 57);
            e.Graphics.DrawString("\n\n\n\n\n\n\n" + ":(الإسم العائلي و الشخصي للتلميذ (ة" , new Font("Arabic Typesetting", 18), Brushes.Black, 570, -30);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + "Classe :", new Font("Century Gothic", 10), Brushes.Black, 195, 60);
            e.Graphics.DrawString("\n\n\n\n\n\n" + label_Classe.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 60);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + ": القسم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, -37);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + "Reçu de parent/tuteur de l'élève le paiement détaillé comme suite :", new Font("Century Gothic", 9), Brushes.Black, 6, 95);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n"+"توصلت الإدارة من ولي أمر التلميذ (ة"+ ") بالأداءالمفصل كالتالي", new Font("Arabic Typesetting", 16), Brushes.Black, 500,13);
            //Table 1
            e.Graphics.DrawRectangle(Pens.Black,40,240,500,183);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 275, 740, 275);
            e.Graphics.DrawLine(Pens.Black, 40, 295, 740, 295);
            e.Graphics.DrawLine(Pens.Black, 40, 315, 740, 315);
            e.Graphics.DrawLine(Pens.Black, 40, 335, 740, 335);
            e.Graphics.DrawLine(Pens.Black, 40, 355, 740, 355);
            e.Graphics.DrawLine(Pens.Black, 40, 375, 740, 375);
            e.Graphics.DrawLine(Pens.Black, 40, 395, 740, 395);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 370, 240,370, e.PageBounds.Height-745);
            e.Graphics.DrawLine(Pens.Black, 200, 240, 200, e.PageBounds.Height - 745);
            e.Graphics.DrawLine(Pens.Black, 740, 275,740, e.PageBounds.Height - 775);
            ///////
            e.Graphics.DrawString("Frais d'inscription  "+"رسوم التسجيل ",new Font("Arabic Typesetting", 13), Brushes.Black, 560, 275);
            e.Graphics.DrawString("Scolarité Mensuelle   " + "الواجب الشهري ", new Font("Arabic Typesetting", 13), Brushes.Black, 553, 295);
            e.Graphics.DrawString("Frais de Transport    " + "واجب النقل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 315);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 1 ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 335);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 2", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 355);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 3", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 375);
            e.Graphics.DrawString("Détail du mode de ce paiement  " + "تفصيل طريقة هذا الأداء", new Font("Arabic Typesetting", 13), Brushes.Black, 410, 425);
            e.Graphics.DrawString("Désignation : ", new Font("verdana", 10), Brushes.Black, 50, 532);
            e.Graphics.DrawString(": تعيين  ", new Font("verdana", 10), Brushes.Black, 650, 532);
            e.Graphics.DrawString(textBox_Commantaire.Text, new Font("verdana", 10), Brushes.Black, 165, 532); 
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------- ", new Font("verdana", 10), Brushes.Black, 0, 573);

            //////
            e.Graphics.DrawString("الرصيد السنوي السابق",new Font("Arabic Typesetting", 14),Brushes.Black,400,240);
            e.Graphics.DrawString("\n" + "Ancien solde annuel ", new Font("Century Gothic", 9), Brushes.Black, 390, 242);
            e.Graphics.DrawString("\n" + label_Savp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 260);
            e.Graphics.DrawString("\n" + label_Savp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 280);
            e.Graphics.DrawString("\n" + label_Savp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 300);
            e.Graphics.DrawString("\n" + label_Savp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 320);
            e.Graphics.DrawString("\n" + label_Savp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 340);
            e.Graphics.DrawString("\n" + label_Savp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 360);
            e.Graphics.DrawString("\n" + ": مجموع الأداء بالدرهم", new Font("Arabic Typesetting", 15), Brushes.Black, 405, 375);
            //
            e.Graphics.DrawString("مبلغ الأداء الحالي", new Font("Arabic Typesetting", 14), Brushes.Black, 250, 240);
            e.Graphics.DrawString("\n" + "Montant payé actuel", new Font("Century Gothic", 9), Brushes.Black, 220, 242);
            e.Graphics.DrawString("\n" + label_Totpy_Fr.Text, new Font("Century Gothic", 10,FontStyle.Bold), Brushes.Black, 255, 260);
            e.Graphics.DrawString("\n" + label_Totpy_Sc.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 280);
            e.Graphics.DrawString("\n" + label_Totpy_Tr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 300);
            e.Graphics.DrawString("\n" + label_Totpy_Ps1.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 320);
            e.Graphics.DrawString("\n" + label_Totpy_Ps2.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 340);
            e.Graphics.DrawString("\n" + label_Totpy_Ps3.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 360);
            e.Graphics.DrawString("\n" + label_TotalPaye.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, 240, 363);
            e.Graphics.DrawString("\n" + "i", new Font("Wingdings 3", 20, FontStyle.Bold), Brushes.Black, 330, 389);
            //
            e.Graphics.DrawString("الرصيد السنوي الجديد", new Font("Arabic Typesetting", 14), Brushes.Black, 70, 240);
            e.Graphics.DrawString("\n" + "Nouveau solde annuel", new Font("Century Gothic", 9), Brushes.Black, 50, 242);
            e.Graphics.DrawString("\n" + label_Sapp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 260);
            e.Graphics.DrawString("\n" + label_Sapp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 280);
            e.Graphics.DrawString("\n" + label_Sapp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 300);
            e.Graphics.DrawString("\n" + label_Sapp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 320);
            e.Graphics.DrawString("\n" + label_Sapp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 340);
            e.Graphics.DrawString("\n" + label_Sapp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 360);
            e.Graphics.DrawString("\n" + "Total payé en Dirhame :", new Font("Arabic Typesetting", 15), Brushes.Black, 45, 375);
            //Table 2
            e.Graphics.DrawRectangle(Pens.Black, 300, 445, 400, 80);
            //Line
            if(tb_Ncheque_Ch.Text=="" || tb_Ncheque_Tr.Text == "")
            {
                tb_Ncheque_Ch.Text = ".................";
                tb_Ncheque_Tr.Text = ".................";
            }
            e.Graphics.DrawLine(Pens.Black, 300, 465, 700, 465);
            e.Graphics.DrawLine(Pens.Black, 300, 485, 700, 485);
            e.Graphics.DrawLine(Pens.Black, 300, 505, 700, 505);
            //colonne
            e.Graphics.DrawLine(Pens.Black, 390, 445, 390, e.PageBounds.Height - 645);
            //
            e.Graphics.DrawString("Espèces du                " +"                             نقدا في", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 445);
            e.Graphics.DrawString( dateTimePicker_Es.Value.ToString("dd/MM/yyyy"), new Font("Verdana", 9,FontStyle.Bold), Brushes.Black, 505, 447);
            e.Graphics.DrawString("\n" + label_pyEspeces.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 430);

            e.Graphics.DrawString("Chèque Numéro        "+"                             شيك رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 467);
            e.Graphics.DrawString( tb_Ncheque_Ch.Text, new Font("Century Gothic", 11,FontStyle.Bold), Brushes.Black, 520, 463);
            e.Graphics.DrawString("\n" + label_pyCheque.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 450);

            e.Graphics.DrawString("Traite Numéro             "+"                           كمبيالة رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 487);
            e.Graphics.DrawString(tb_Ncheque_Tr.Text , new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 484);
            e.Graphics.DrawString("\n" + label_pyTraite.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 470);

            e.Graphics.DrawString("Virement du             "+ "                          تحويل بنكي في", new Font("Arabic Typesetting", 14), Brushes.Black, 393, 505);
            e.Graphics.DrawString( dateTimePicker_Vm.Value.ToString("dd/MM/yyyy") , new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 495, 507);
            e.Graphics.DrawString("\n" + label_pyVirement.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 490);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            












            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label_Nom_ecole.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, 10, 60);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n" + "école primaire à Tanger" + "\n", new Font("Century Gothic", 10), Brushes.Black, 20,70);
            e.Graphics.DrawImage(pictureBox4.Image, 340, 590, 150, 70);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label_Ns_Arabe.Text, new Font("Arabic Typesetting", 22, FontStyle.Bold), Brushes.Black, 660, 45);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+"\n" + "مدرسة إبتدائية بطنجة", new Font("Arabic Typesetting", 20), Brushes.Black, 670, 52);

            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + "Tanger le :", new Font("Century Gothic", 10), Brushes.Black, 188, 47);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n" + dateTimePicker_Djeur.Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 165);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+"\n\n\n" + ": طنجة في", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 78);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + "Reçu de paiement N° :", new Font("Century Gothic", 10), Brushes.Black, 96, 175);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n" + "00" + label_NumeroRecu.Text + "/" + DateTime.Today.Year, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 145);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + ": توصيل أداء رقم", new Font("Arabic Typesetting", 18), Brushes.Black, 570,45);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n\n" + "Années Scolaire:", new Font("Century Gothic", 10), Brushes.Black, 140, 150);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n" + label_AnnesSc.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 105);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ":السنة الدراسية", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 45);



            //  
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Matricule de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 110, 227);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "00" + TextBox_Matricule.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 370, 87);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ":(رقم تسجيل التلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 72);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Nom et Prénom de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 65, 255);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label_Nom.Text + " " + label_Prenom.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 115);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"+ ":(الإسم العائلي و الشخصي للتلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 100);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Classe :", new Font("Century Gothic", 10), Brushes.Black, 195, 279);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label_Classe.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 137);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ": القسم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 125);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Reçu de parent/tuteur de l'élève le paiement détaillé comme suite :", new Font("Century Gothic", 9), Brushes.Black, 6,350);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "توصلت الإدارة من ولي أمر التلميذ (ة" + ") بالأداءالمفصل كالتالي", new Font("Arabic Typesetting", 16), Brushes.Black, 500, 145);
            //Table 1
            e.Graphics.DrawRectangle(Pens.Black, 40, 830, 500, 183);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 865, 740, 865);
            e.Graphics.DrawLine(Pens.Black, 40, 885, 740, 885);
            e.Graphics.DrawLine(Pens.Black, 40, 905, 740, 905);
            e.Graphics.DrawLine(Pens.Black, 40, 925, 740, 925);
            e.Graphics.DrawLine(Pens.Black, 40, 945, 740, 945);
            e.Graphics.DrawLine(Pens.Black, 40, 965, 740, 965);
            e.Graphics.DrawLine(Pens.Black, 40, 985, 740, 985);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 740, 865, 740, e.PageBounds.Height -185);
            e.Graphics.DrawLine(Pens.Black, 370, 830, 370, e.PageBounds.Height - 155);
            e.Graphics.DrawLine(Pens.Black, 200, 830, 200, e.PageBounds.Height - 155);
            ///////
            e.Graphics.DrawString("Frais d'inscription  " + "رسوم التسجيل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 865);
            e.Graphics.DrawString("Scolarité Mensuelle   " + "الواجب الشهري ", new Font("Arabic Typesetting", 13), Brushes.Black, 553, 885);
            e.Graphics.DrawString("Frais de Transport    " + "واجب النقل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 905);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 1 ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 925);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 2", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 945);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 3", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 965);
            e.Graphics.DrawString("Détail du mode de ce paiement  " + "تفصيل طريقة هذا الأداء", new Font("Arabic Typesetting", 13), Brushes.Black, 410, 1015);
            e.Graphics.DrawString("Désignation : ", new Font("verdana", 10), Brushes.Black, 50, 1127);
            e.Graphics.DrawString(": تعيين  ", new Font("verdana", 10), Brushes.Black, 650, 1127);
            e.Graphics.DrawString(textBox_Commantaire.Text, new Font("verdana", 10), Brushes.Black, 165, 1127);


            //////
            e.Graphics.DrawString("الرصيد السنوي السابق", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 830);
            e.Graphics.DrawString("\n" + "Ancien solde annuel ", new Font("Century Gothic", 9), Brushes.Black, 390, 830);
            e.Graphics.DrawString("\n" + label_Savp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 850);
            e.Graphics.DrawString("\n" + label_Savp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 870);
            e.Graphics.DrawString("\n" + label_Savp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 890);
            e.Graphics.DrawString("\n" + label_Savp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 910);
            e.Graphics.DrawString("\n" + label_Savp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 930);
            e.Graphics.DrawString("\n" + label_Savp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 950);
            e.Graphics.DrawString("\n" + ": مجموع الأداء بالدرهم", new Font("Arabic Typesetting", 15), Brushes.Black, 405, 963);
            //
            e.Graphics.DrawString("مبلغ الأداء الحالي", new Font("Arabic Typesetting", 14), Brushes.Black, 250, 830);
            e.Graphics.DrawString("\n" + "Montant payé actuel", new Font("Century Gothic", 9), Brushes.Black, 220, 830);
            e.Graphics.DrawString("\n" + label_Totpy_Fr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 850);
            e.Graphics.DrawString("\n" + label_Totpy_Sc.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 870);
            e.Graphics.DrawString("\n" + label_Totpy_Tr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 890);
            e.Graphics.DrawString("\n" + label_Totpy_Ps1.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 910);
            e.Graphics.DrawString("\n" + label_Totpy_Ps2.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 930);
            e.Graphics.DrawString("\n" + label_Totpy_Ps3.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 950);
            e.Graphics.DrawString("\n" + label_TotalPaye.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, 240, 953);
            e.Graphics.DrawString("\n" + "i", new Font("Wingdings 3", 20, FontStyle.Bold), Brushes.Black, 330, 979);
            //
            e.Graphics.DrawString("الرصيد السنوي الجديد", new Font("Arabic Typesetting", 14), Brushes.Black, 70, 830);
            e.Graphics.DrawString("\n" + "Nouveau solde annuel", new Font("Century Gothic", 9), Brushes.Black, 50, 830);
            e.Graphics.DrawString("\n" + label_Sapp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 850);
            e.Graphics.DrawString("\n" + label_Sapp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 870);
            e.Graphics.DrawString("\n" + label_Sapp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 890);
            e.Graphics.DrawString("\n" + label_Sapp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 910);
            e.Graphics.DrawString("\n" + label_Sapp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 930);
            e.Graphics.DrawString("\n" + label_Sapp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 950);
            e.Graphics.DrawString("\n" + "Total payé en Dirhame :", new Font("Arabic Typesetting", 15), Brushes.Black, 45, 965);
            //Table 2
            e.Graphics.DrawRectangle(Pens.Black, 300, 1035, 400, 80);
            //Line
            if (tb_Ncheque_Ch.Text == "" || tb_Ncheque_Tr.Text == "")
            {
                tb_Ncheque_Ch.Text = ".................";
                tb_Ncheque_Tr.Text = ".................";
            }
            e.Graphics.DrawLine(Pens.Black, 300, 1055, 700, 1055);
            e.Graphics.DrawLine(Pens.Black, 300, 1075, 700, 1075);
            e.Graphics.DrawLine(Pens.Black, 300, 1095, 700, 1095);
            //colonne
            e.Graphics.DrawLine(Pens.Black, 390, 1035, 390, e.PageBounds.Height - 55);
            //
            e.Graphics.DrawString("Espèces du                " + "                             نقدا في", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 1035);
            e.Graphics.DrawString(dateTimePicker_Es.Value.ToString("dd/MM/yyyy"), new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 505,1037);
            e.Graphics.DrawString("\n" + label_pyEspeces.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 1020);

            e.Graphics.DrawString("Chèque Numéro        " + "                             شيك رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 1057);
            e.Graphics.DrawString(tb_Ncheque_Ch.Text, new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 1053);
            e.Graphics.DrawString("\n" + label_pyCheque.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 1040);

            e.Graphics.DrawString("Traite Numéro             " + "                           كمبيالة رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395,1077);
            e.Graphics.DrawString(tb_Ncheque_Tr.Text, new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 1074);
            e.Graphics.DrawString("\n" + label_pyTraite.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 1060);

            e.Graphics.DrawString("Virement du             " + "                          تحويل بنكي في", new Font("Arabic Typesetting", 14), Brushes.Black, 393, 1095);
            e.Graphics.DrawString(dateTimePicker_Vm.Value.ToString("dd/MM/yyyy"), new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 495, 1097);
            e.Graphics.DrawString("\n" + label_pyVirement.Text, new Font("Century Gothic", 10), Brushes.Black, 320, 1080);
            
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Table 3
            e.Graphics.DrawRectangle(Pens.Black, 150, 1122, 500, 30);
            //Line
            //Table 3
            e.Graphics.DrawRectangle(Pens.Black, 150, 530, 500, 30);
            //Line
        }
        private void Button_imprimer_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void tb_Especes_Fr_Enter_1(object sender, EventArgs e)
        {
            if (tb_Especes_Fr.Text == "0")
            {
                tb_Especes_Fr.Text = "";
                tb_Especes_Fr.ForeColor = Color.Black;
            }
        }
    }
}
