﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logiciel_de_Paiement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial" + " Catalog=LogicielDePaiement;Integrated Security=True");
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial" + " Catalog=Fiche_Paiement;Integrated Security=True");

  

        public static double PursontageFr(double echeance , double Total)
        {
            double MM = (Total * 100) / echeance;
            return MM;
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            label39.Text = Form1.username;
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Mypaper", this.Height - 54, this.Width-215);
            //printDocument1.DefaultPageSettings.Landscape = true;
            fillCombo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (CheckBox r in groupBoxAutre.Controls)
            //    if (r.Checked)
            //    {
            //        groupBoxPs1.Visible = true;
            //        groupBoxPs2.Visible = true;
            //        groupBoxPs3.Visible = true;
            //    }
            //    else
            //    {
            //        groupBoxPs1.Visible = false;
            //        groupBoxPs2.Visible = false;
            //        groupBoxPs3.Visible = false;
            //    }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 fp = new Form4();
            fp.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label_UserName1_Click(object sender, EventArgs e)
        {

        }

        private void fillCombo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from annesScolaire",conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable src = new DataTable();
            comboBox_An.Items.Clear();
            while (rd.Read())
            {
                comboBox_An.Items.Add(rd[0]);
            }
            comboBox_An.SelectedIndex = 0;
            conn.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, 730, g);

            //Graphics mg = Graphics.FromImage(bmp);

            //mg.CopyFromScreen(this.Location.X, this.Location.Y, -10, -30, this.Size);

            //e.Graphics.DrawImage(bmp, 0, 0);
            e.Graphics.DrawString(label_Nom_ecole.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, 10, 15);
            e.Graphics.DrawString("\n" + "école primaire à Tanger" + "\n", new Font("Century Gothic", 10), Brushes.Black, 20, 25);
            e.Graphics.DrawImage(pictureBox4.Image, 360, 0, 150, 100);
            e.Graphics.DrawString(label_Ns_Arabe.Text, new Font("Arabic Typesetting", 22, FontStyle.Bold), Brushes.Black, 660, 10);
            e.Graphics.DrawString("\n" + "مدرسة إبتدائية بطنجة", new Font("Arabic Typesetting", 20), Brushes.Black, 670, 5);

            //
            e.Graphics.DrawString("\n\n\n" + "Tanger le :", new Font("Century Gothic", 10), Brushes.Black, 208, 50);
            e.Graphics.DrawString("\n\n" + dateTimePicker_Djeur.Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 340, 55);
            e.Graphics.DrawString("\n\n\n" + ": طنجة في", new Font("Arabic Typesetting", 18), Brushes.Black, 590, 15);
            //
            e.Graphics.DrawString("\n\n\n" + "Années Scolaire:", new Font("Century Gothic", 10), Brushes.Black, 165, 75);
            e.Graphics.DrawString("\n" + comboBox_An.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 380, 100);
            e.Graphics.DrawString("\n\n\n" + ":السنة الدراسية", new Font("Arabic Typesetting", 18), Brushes.Black, 590, 37);
            //


            //  
            e.Graphics.DrawString("\n\n\n\n\n\n" + "Matricule de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 135, 53);
            e.Graphics.DrawString("\n\n\n\n" + "00" + tb_Matricule.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 65);
            e.Graphics.DrawString("\n\n\n\n\n\n" + ":(رقم تسجيل التلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 590, -20);
            ////
            e.Graphics.DrawString("\n\n\n\n\n\n\n" + "Nom et Prénom de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 90, 65);
            e.Graphics.DrawString("\n\n\n\n\n" + tb_Nom.Text + " " + tb_Prenom.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 340, 67);
            e.Graphics.DrawString("\n\n\n\n\n\n\n" + ":(الإسم العائلي و الشخصي للتلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 590, -20);
            ////
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + "Classe :", new Font("Century Gothic", 10), Brushes.Black, 220, 70);
            e.Graphics.DrawString("\n\n\n\n\n\n" + tb_Classe.Text, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 390, 70);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + ": القسم", new Font("Arabic Typesetting", 18), Brushes.Black, 590, -27);
            ////
            //Table1
            e.Graphics.DrawRectangle(Pens.Black, 40, 250, 740, 120);
            e.Graphics.DrawString("Frais d'inscription  " + " رسوم التسجيل ", new Font("Arabic Typesetting", 20), Brushes.Black,270, 250);
            e.Graphics.DrawString(tb_échéance_Fr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 60, 320);
            e.Graphics.DrawString(N_UpDown_Fr.Value.ToString(), new Font("Arabic Typesetting", 20), Brushes.Black, 210, 320);
            e.Graphics.DrawString(label_Base_Fr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 320, 320);
            e.Graphics.DrawString(label_Total_Fr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 470, 320);
            e.Graphics.DrawString(label_Solde_Fr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 590, 320);
            e.Graphics.DrawString(label_eche_NP_Fr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 710, 320);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 280, 780, 280);
            e.Graphics.DrawLine(Pens.Black, 40, 310, 780, 310);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 165, 280, 165, e.PageBounds.Height - 800);
            e.Graphics.DrawLine(Pens.Black, 285, 280, 285, e.PageBounds.Height - 800);
            e.Graphics.DrawLine(Pens.Black, 425, 280, 425, e.PageBounds.Height - 800);
            e.Graphics.DrawLine(Pens.Black, 545, 280, 545, e.PageBounds.Height - 800);
            e.Graphics.DrawLine(Pens.Black, 665, 280, 665, e.PageBounds.Height - 800);
            //Table2
            e.Graphics.DrawRectangle(Pens.Black, 40, 370, 740, 120);
            e.Graphics.DrawString("Scolarité Mensuelle   " + "الواجب الشهري ", new Font("Arabic Typesetting", 20), Brushes.Black, 270, 370);
            e.Graphics.DrawString(tb_échéance_Sc.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 60, 445);
            e.Graphics.DrawString(N_UpDown_Sc.Value.ToString(), new Font("Arabic Typesetting", 20), Brushes.Black, 210, 445);
            e.Graphics.DrawString(label_Base_Sc.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 320, 445);
            e.Graphics.DrawString(label_Total_Sc.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 470, 445);
            e.Graphics.DrawString(label_Solde_Sc.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 590, 445);
            e.Graphics.DrawString(label_eche_NP_Sc.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 710, 445);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 400, 780, 400);
            e.Graphics.DrawLine(Pens.Black, 40, 430, 780, 430);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 165, 400, 165, e.PageBounds.Height - 680);
            e.Graphics.DrawLine(Pens.Black, 285, 400, 285, e.PageBounds.Height - 680);
            e.Graphics.DrawLine(Pens.Black, 425, 400, 425, e.PageBounds.Height - 680);
            e.Graphics.DrawLine(Pens.Black, 545, 400, 545, e.PageBounds.Height - 680);
            e.Graphics.DrawLine(Pens.Black, 665, 400, 665, e.PageBounds.Height - 680);
            //Table3
            e.Graphics.DrawRectangle(Pens.Black, 40, 490, 740, 120);
            e.Graphics.DrawString("Frais de Transport    " + "واجب النقل ", new Font("Arabic Typesetting", 20), Brushes.Black, 270, 490);
            e.Graphics.DrawString(tb_échéance_Tr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 60, 565);
            e.Graphics.DrawString(N_UpDown_Tr.Value.ToString(), new Font("Arabic Typesetting", 20), Brushes.Black, 210, 565);
            e.Graphics.DrawString(label_Base_Tr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 320, 565);
            e.Graphics.DrawString(label_Total_Tr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 470, 565);
            e.Graphics.DrawString(label_Solde_Tr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 590, 565);
            e.Graphics.DrawString(label_eche_NP_Tr.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 710, 565);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 520, 780, 520);
            e.Graphics.DrawLine(Pens.Black, 40, 550, 780, 550);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 165, 520, 165, e.PageBounds.Height - 560);
            e.Graphics.DrawLine(Pens.Black, 285, 520, 285, e.PageBounds.Height - 560);
            e.Graphics.DrawLine(Pens.Black, 425, 520, 425, e.PageBounds.Height - 560);
            e.Graphics.DrawLine(Pens.Black, 545, 520, 545, e.PageBounds.Height - 560);
            e.Graphics.DrawLine(Pens.Black, 665, 520, 665, e.PageBounds.Height - 560);
            //Table4
            e.Graphics.DrawRectangle(Pens.Black, 40, 610, 740, 120);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى  1 ", new Font("Arabic Typesetting", 20), Brushes.Black, 270, 610);
            e.Graphics.DrawString(tb_échéance_ps1.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 60, 685);
            e.Graphics.DrawString(N_UpDown_Ps1.Value.ToString(), new Font("Arabic Typesetting", 20), Brushes.Black, 210, 685);
            e.Graphics.DrawString(label_Base_Ps1.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 320, 685);
            e.Graphics.DrawString(label_Total_Ps1.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 470, 685);
            e.Graphics.DrawString(label_Solde_Ps1.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 590, 685);
            e.Graphics.DrawString(label_eche_NP_Ps1.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 710, 685);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 640, 780, 640);
            e.Graphics.DrawLine(Pens.Black, 40, 670, 780, 670);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 165, 640, 165, e.PageBounds.Height - 440);
            e.Graphics.DrawLine(Pens.Black, 285, 640, 285, e.PageBounds.Height - 440);
            e.Graphics.DrawLine(Pens.Black, 425, 640, 425, e.PageBounds.Height - 440);
            e.Graphics.DrawLine(Pens.Black, 545, 640, 545, e.PageBounds.Height - 440);
            e.Graphics.DrawLine(Pens.Black, 665, 640, 665, e.PageBounds.Height - 440);
            //Table5
            e.Graphics.DrawRectangle(Pens.Black, 40, 730, 740, 120);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى  2 ", new Font("Arabic Typesetting", 20), Brushes.Black, 270, 730);
            e.Graphics.DrawString(tb_échéance_ps2.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 60, 805);
            e.Graphics.DrawString(N_UpDown_Ps2.Value.ToString(), new Font("Arabic Typesetting", 20), Brushes.Black, 210, 805);
            e.Graphics.DrawString(label_Base_Ps2.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 320, 805);
            e.Graphics.DrawString(label_Total_Ps2.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 470, 805);
            e.Graphics.DrawString(label_Solde_Ps2.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 590, 805);
            e.Graphics.DrawString(label_eche_NP_Ps2.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 710, 805);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 760, 780, 760);
            e.Graphics.DrawLine(Pens.Black, 40, 790, 780, 790);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 165, 760, 165, e.PageBounds.Height - 320);
            e.Graphics.DrawLine(Pens.Black, 285, 760, 285, e.PageBounds.Height - 320);
            e.Graphics.DrawLine(Pens.Black, 425, 760, 425, e.PageBounds.Height - 320);
            e.Graphics.DrawLine(Pens.Black, 545, 760, 545, e.PageBounds.Height - 320);
            e.Graphics.DrawLine(Pens.Black, 665, 760, 665, e.PageBounds.Height - 320);
            //Table6
            e.Graphics.DrawRectangle(Pens.Black, 40, 850, 740, 120);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى  3 ", new Font("Arabic Typesetting", 20), Brushes.Black, 270, 850);
            e.Graphics.DrawString(tb_échéance_ps3.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 60, 925);
            e.Graphics.DrawString(N_UpDown_Ps3.Value.ToString(), new Font("Arabic Typesetting", 20), Brushes.Black, 210, 925);
            e.Graphics.DrawString(label_Base_Ps3.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 320, 925);
            e.Graphics.DrawString(label_Total_Ps3.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 470, 925);
            e.Graphics.DrawString(label_Solde_Ps3.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 590, 925);
            e.Graphics.DrawString(label_eche_NP_Ps3.Text, new Font("Arabic Typesetting", 20), Brushes.Black, 710, 925);
            e.Graphics.DrawString("Utilisateur: " + label39.Text, new Font("Arabic Typesetting", 15), Brushes.Black, 600, 968);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 880, 780, 880);
            e.Graphics.DrawLine(Pens.Black, 40, 910, 780, 910);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 165, 880, 165, e.PageBounds.Height - 200);
            e.Graphics.DrawLine(Pens.Black, 285, 880, 285, e.PageBounds.Height - 200);
            e.Graphics.DrawLine(Pens.Black, 425, 880, 425, e.PageBounds.Height - 200);
            e.Graphics.DrawLine(Pens.Black, 545, 880, 545, e.PageBounds.Height - 200);
            e.Graphics.DrawLine(Pens.Black, 665, 880, 665, e.PageBounds.Height - 200);
        }
        
        private void Button_imprimer_Click(object sender, EventArgs e)
        {

        }

        public static int dtCaculeTr(string dtIns,double totpy,double ech)
        {
            String dtNow = DateTime.Now.ToString("dd/MM/yyyy");

            DateTime dt_current = Convert.ToDateTime("18/04/2020");
            DateTime dt_ins = Convert.ToDateTime(dtIns);
            if(dt_ins.Month>4 && dt_ins.Month < 9 )
            {
                dt_ins = Convert.ToDateTime("01/09/" + dt_ins.Year);
            }

            TimeSpan dt_result = dt_current.Subtract(dt_ins);
            double dt_dif = dt_result.Days;
            int months = (int)dt_dif / 30;
            if (months == 0)
                return 0;
            double monthspy =  totpy / ech;
           

            if (monthspy >= months)
                return 0;
            return (int)(months-(int)monthspy);
        }
      public void Fr_TextCh()
        {
            try
            {
                
                double F = double.Parse(tb_échéance_Fr.Text);
                int R = (int)N_UpDown_Fr.Value;
                double TotalFrais = (F * R);
                label_Base_Fr.Text = String.Format("{0:0.00}", TotalFrais);
                label_Solde_Fr.Text = String.Format("{0:0.00}", TotalFrais);


            }
            catch (Exception ex)
            {

            }
        }
        public void Sc_TextCh()
        {
            try
            {
                //if (N_UpDown_Sc.Value == 0)
                //    return;
                double S = double.Parse(tb_échéance_Sc.Text);
                int C = (int)N_UpDown_Sc.Value;
                double TotalScol = (S * C);
                label_Base_Sc.Text = String.Format("{0:0.00}", TotalScol);
                label_Solde_Sc.Text = String.Format("{0:0.00}", TotalScol);


            }
            catch (Exception ex)
            {

            }
        }
        public void Tr_TextCh()
        {
            try
            {
             
                double T = double.Parse(tb_échéance_Tr.Text);
                int u = (int)N_UpDown_Tr.Value;
                double TotalTrans = (T * u);
                label_Base_Tr.Text = String.Format("{0:0.00}", TotalTrans);
                label_Solde_Tr.Text = String.Format("{0:0.00}", TotalTrans);
            }
            catch (Exception ex)
            {

            }
        }
        public void Ps1_TextCh()
        {
            try
            {
               
                double P = double.Parse(tb_échéance_ps1.Text);
                int k = (int)N_UpDown_Ps1.Value;
                double TotalPS1 = (P * k);
                label_Base_Ps1.Text = String.Format("{0:0.00}", TotalPS1);
                label_Solde_Ps1.Text = String.Format("{0:0.00}", TotalPS1);
            }
            catch (Exception ex)
            {

            }
        }
         public void Ps2_TextCh()
        {
            try
            {
                
                double m = double.Parse(tb_échéance_ps2.Text);
                int n = (int)N_UpDown_Ps2.Value;
                double TotalPS2 = (m * n);

                label_Base_Ps2.Text = String.Format("{0:0.00}", TotalPS2);
                label_Solde_Ps2.Text = String.Format("{0:0.00}", TotalPS2);

            }
            catch (Exception ex)
            {

            }
        }
      public void Ps3_TextCh()
        {
            try
            {
                
                double l = double.Parse(tb_échéance_ps3.Text);
                int d = (int)N_UpDown_Ps3.Value;
                double TotalPS3 = (l * d);
                label_Base_Ps3.Text = String.Format("{0:0.00}", TotalPS3);
                label_Solde_Ps3.Text = String.Format("{0:0.00}", TotalPS3);
            }
            catch (Exception ex)
            {

            }
        }
      
        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (panelMenu.Width == 270 && panel_Buttones.Width==65)
            {
                panelMenu.Width = 45;
                panel_Buttones.Width = 220;
            }
            else
            {
                panelMenu.Width = 270;
                panel_Buttones.Width = 65;
            }
               
        }
        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            foreach (CheckBox r in panel11.Controls)
                if (r.Checked)
                {
                    panel10.Visible = true;
                    panel9.Visible = true;
                    panel8.Visible = true;
                }
                else
                {
                    panel10.Visible = false;
                    panel9.Visible = false;
                    panel8.Visible = false;
                }
        }

     

        private void Button_Vider_Click_2(object sender, EventArgs e)
        {
            if (tb_Matricule.Text == "")
            {
                MessageBox.Show("Cherchez l'etudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tb_échéance_Fr.ForeColor = Color.White;
                tb_échéance_Sc.ForeColor = Color.White;
                tb_échéance_Tr.ForeColor = Color.White;
                tb_échéance_ps1.ForeColor = Color.White;
                tb_échéance_ps2.ForeColor = Color.White;
                tb_échéance_ps3.ForeColor = Color.White;



                tb_Matricule.Text = "";
                tb_Nom.Text = "";
                tb_Prenom.Text = "";
                dateTimePicker_DN.Value = DateTime.Today;
                tb_Classe.Text = "";
                textBox_Mobile.Text = "";

                tb_échéance_Fr.Text = "0";
                N_UpDown_Fr.Value = 1;
                label_Base_Fr.Text = "0";
                label_Total_Fr.Text = "0";
                label_Solde_Fr.Text = "0";


                tb_échéance_Sc.Text = "0";
                N_UpDown_Sc.Value = 1;
                label_Base_Sc.Text = "0";
                label_Total_Sc.Text = "0";
                label_Solde_Sc.Text = "0";


                tb_échéance_Tr.Text = "0";
                N_UpDown_Tr.Value = 1;
                label_Base_Tr.Text = "0";
                label_Total_Tr.Text = "0";
                label_Solde_Tr.Text = "0";


                tb_échéance_ps1.Text = "0";
                N_UpDown_Ps1.Value = 1;
                label_Base_Ps1.Text = "0";
                label_Total_Ps1.Text = "0";
                label_Solde_Ps1.Text = "0";


                tb_échéance_ps2.Text = "0";
                N_UpDown_Ps2.Value = 1;
                label_Base_Ps2.Text = "0";
                label_Total_Ps2.Text = "0";
                label_Solde_Ps2.Text = "0";


                tb_échéance_ps3.Text = "0";
                N_UpDown_Ps3.Value = 1;
                label_Base_Ps3.Text = "0";
                label_Total_Ps3.Text = "0";
                label_Solde_Ps3.Text = "0";


                label_eche_NP_Fr.Text = "0";
                label_eche_NP_Sc.Text = "0";
                label_eche_NP_Tr.Text = "0";
                label_eche_NP_Ps1.Text = "0";
                label_eche_NP_Ps2.Text = "0";
                label_eche_NP_Ps3.Text = "0";
            }
        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void Button_Ajouter_Click_3(object sender, EventArgs e)
        {
            // try
            // {
            if (tb_Matricule.Text == "" || tb_Nom.Text == "" || tb_Prenom.Text == "" || tb_Classe.Text == "" || tb_échéance_Fr.Text == "" || tb_échéance_Sc.Text == "")
            {
                MessageBox.Show("Remplir Les information de etudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();

                string sql = "insert into etudiant(Matricule, Nom,Prenom, date_Nc,sexe,Mobile_Pr,classe,AnnésSc,date_InS,Nom_Utl)";
                sql = sql + "values(@pM,@pN,@pP,@pDn,@pSexe,@pMobile,@pC,@pAn,@pDis,@pNomUTL)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("pM", tb_Matricule.Text);
                cmd.Parameters.AddWithValue("pN", tb_Nom.Text);
                cmd.Parameters.AddWithValue("pP", tb_Prenom.Text);
                cmd.Parameters.AddWithValue("pDn", dateTimePicker_DN.Value);
                cmd.Parameters.AddWithValue("pSexe", comboBox_Sexe.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("pMobile", textBox_Mobile.Text);
                cmd.Parameters.AddWithValue("pC", tb_Classe.Text);
                cmd.Parameters.AddWithValue("pAn", comboBox_An.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("pDis", dateTimePicker_Djeur.Value);
                cmd.Parameters.AddWithValue("pNomUTL", label39.Text);
                cmd.ExecuteNonQuery();

                string Sqqql = "insert into Detaile (Matricule, éch_Fr,Nbr_Fr,Base_Fr,Total_Fr,Solde_Fr,éch_Fr_Np,    éch_Sc,Nbr_Sc,Base_Sc,Total_Sc,Solde_Sc,éch_Sc_Np    ,éch_Tr,Nbr_Tr,Base_Tr,Total_Tr,Solde_Tr,éch_Tr_Np     ,éch_Ps1,Nbr_Ps1,Base_Ps1,Total_Ps1,Solde_Ps1,éch_Ps1_Np     ,éch_Ps2,Nbr_Ps2,Base_Ps2,Total_Ps2,Solde_Ps2,éch_Ps2_Np   ,éch_Ps3,Nbr_Ps3,Base_Ps3,Total_Ps3,Solde_Ps3,éch_Ps3_Np  )";
                Sqqql = Sqqql + "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25,@p26,@p27,@p28,@p29,@p30,@p31,@p32,@p33,@p34,@p35,@p36,@p37)";
                SqlCommand cmmmd = new SqlCommand(Sqqql, conn);
                //parametre de Frais

                try
                {
                    cmmmd.Parameters.AddWithValue("p1", tb_Matricule.Text);

                    cmmmd.Parameters.AddWithValue("p2", Convert.ToDouble(tb_échéance_Fr.Text));
                    cmmmd.Parameters.AddWithValue("p3", N_UpDown_Fr.Value);
                    cmmmd.Parameters.AddWithValue("p4", Convert.ToDouble(label_Base_Fr.Text));
                    cmmmd.Parameters.AddWithValue("p5", Convert.ToDouble(label_Total_Fr.Text));
                    cmmmd.Parameters.AddWithValue("p6", Convert.ToDouble(label_Solde_Fr.Text));
                    cmmmd.Parameters.AddWithValue("p7", label_eche_NP_Fr.Text);
                    //parametre de Scolaire
                    cmmmd.Parameters.AddWithValue("p8", Convert.ToDouble(tb_échéance_Sc.Text));
                    cmmmd.Parameters.AddWithValue("p9", N_UpDown_Sc.Text);
                    cmmmd.Parameters.AddWithValue("p10", Convert.ToDouble(label_Base_Sc.Text));
                    cmmmd.Parameters.AddWithValue("p11", Convert.ToDouble(label_Total_Sc.Text));
                    cmmmd.Parameters.AddWithValue("p12", Convert.ToDouble(label_Solde_Sc.Text));
                    cmmmd.Parameters.AddWithValue("p13", label_eche_NP_Sc.Text);
                    //parametre de Transport
                    cmmmd.Parameters.AddWithValue("p14", Convert.ToDouble(tb_échéance_Tr.Text));
                    cmmmd.Parameters.AddWithValue("p15", N_UpDown_Tr.Text);
                    cmmmd.Parameters.AddWithValue("p16", Convert.ToDouble(label_Base_Tr.Text));
                    cmmmd.Parameters.AddWithValue("p17", Convert.ToDouble(label_Total_Tr.Text));
                    cmmmd.Parameters.AddWithValue("p18", Convert.ToDouble(label_Solde_Tr.Text));
                    cmmmd.Parameters.AddWithValue("p19", label_eche_NP_Tr.Text);
                    //parametre de prestation1
                    cmmmd.Parameters.AddWithValue("p20", Convert.ToDouble(tb_échéance_ps1.Text));
                    cmmmd.Parameters.AddWithValue("p21", N_UpDown_Ps1.Text);
                    cmmmd.Parameters.AddWithValue("p22", Convert.ToDouble(label_Base_Ps1.Text));
                    cmmmd.Parameters.AddWithValue("p23", Convert.ToDouble(label_Total_Ps1.Text));
                    cmmmd.Parameters.AddWithValue("p24", Convert.ToDouble(label_Solde_Ps1.Text));
                    cmmmd.Parameters.AddWithValue("p25", label_eche_NP_Ps1.Text);
                    //parametre de prestation2
                    cmmmd.Parameters.AddWithValue("p26", Convert.ToDouble(tb_échéance_ps2.Text));
                    cmmmd.Parameters.AddWithValue("p27", N_UpDown_Ps2.Text);
                    cmmmd.Parameters.AddWithValue("p28", Convert.ToDouble(label_Base_Ps2.Text));
                    cmmmd.Parameters.AddWithValue("p29", Convert.ToDouble(label_Total_Ps2.Text));
                    cmmmd.Parameters.AddWithValue("p30", Convert.ToDouble(label_Solde_Ps2.Text));
                    cmmmd.Parameters.AddWithValue("p31", label_eche_NP_Ps2.Text);
                    //parametre de prestation3
                    cmmmd.Parameters.AddWithValue("p32", Convert.ToDouble(tb_échéance_ps3.Text));
                    cmmmd.Parameters.AddWithValue("p33", N_UpDown_Ps3.Text);
                    cmmmd.Parameters.AddWithValue("p34", Convert.ToDouble(label_Base_Ps3.Text));
                    cmmmd.Parameters.AddWithValue("p35", Convert.ToDouble(label_Total_Ps3.Text));
                    cmmmd.Parameters.AddWithValue("p36", Convert.ToDouble(label_Solde_Ps3.Text));
                    cmmmd.Parameters.AddWithValue("p37", label_eche_NP_Ps3.Text);
                    cmmmd.ExecuteNonQuery();
                    MessageBox.Show("etudiant Ajouter");
                }catch(Exception ex)
                {
                    SqlCommand deleteCmd = new SqlCommand("delete etudiant where Matricule =" + tb_Matricule.Text, conn);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("error");

                }
                conn.Close();
                
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Button_Supprimer_Click_1(object sender, EventArgs e)
        {
            if (tb_Matricule.Text == "")
            {
                MessageBox.Show("Cherchez l'etudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult res = MessageBox.Show("Voulley vous vraiment Supprimmer cette etudiant", "Confirmation de Suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                        int id = int.Parse(tb_Matricule.Text);
                        SqlCommand cmd = new SqlCommand("delete from Detaile where Matricule = @id;delete from etudiant where Matricule = @id", conn);
                        cmd.Parameters.AddWithValue("id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery(); // Exécution de la requête SQL
                        MessageBox.Show("La suppression a été effectuée avec succè");
                        // Fermeture de la connexion à la base de données
                        conn.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
             if (tb_Matricule.Text == "")
            {
                MessageBox.Show("Remplir la case de Matricule","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int idRecherche = int.Parse(tb_Matricule.Text);
                int id_Rech = int.Parse(tb_Matricule.Text);

                SqlCommand cmd = new SqlCommand("select * from etudiant where Matricule='" + idRecherche + "' ", conn);
                SqlCommand cmmd = new SqlCommand("select * from Detaile where Matricule='" + id_Rech + "' ", conn);
                conn.Open();
                SqlDataReader ddr = cmd.ExecuteReader();

                DateTime dtIns = DateTime.Now;

                if (!ddr.HasRows)
                {
                    MessageBox.Show("mk");
                    conn.Close();
                    return;
                }

                while (ddr.Read())
                {

                    tb_Nom.Text = ddr[1].ToString();
                    tb_Prenom.Text = ddr[2].ToString();
                    dateTimePicker_DN.Text = ddr[3].ToString();
                    comboBox_Sexe.SelectedItem = ddr[4];
                    textBox_Mobile.Text = ddr[5].ToString();
                    tb_Classe.Text = ddr[6].ToString();
                    comboBox_An.SelectedItem = ddr[7];
                    dtIns = Convert.ToDateTime(ddr[8]);

                   

                }
                string dtInsStr = dtIns.Date.ToString("dd/MM/yyyy");
             
                ddr.Close();
                cmd.Dispose();
                SqlDataReader dr = cmmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_échéance_Fr.ForeColor = Color.Black;
                    tb_échéance_Sc.ForeColor = Color.Black;
                    tb_échéance_Tr.ForeColor = Color.Black;
                    tb_échéance_ps1.ForeColor = Color.Black;
                    tb_échéance_ps2.ForeColor = Color.Black;
                    tb_échéance_ps3.ForeColor = Color.Black;

                    double d1 = double.Parse(dr[1].ToString());
                    tb_échéance_Fr.Text = String.Format("{0:0.00}", d1);
                    N_UpDown_Fr.Value = int.Parse(dr[2].ToString());
                    label_Base_Fr.Text = String.Format("{0:0.00}", dr[3]);
                    label_Total_Fr.Text = String.Format("{0:0.00}", dr[4]);
                    label_Solde_Fr.Text = String.Format("{0:0.00}", dr[5]);
                    label_eche_NP_Fr.Text = dr[6].ToString();

                    double d7 = double.Parse(dr[7].ToString());
                    tb_échéance_Sc.Text = String.Format("{0:0.00}", d7);
                    N_UpDown_Sc.Value = int.Parse(dr[8].ToString());
                    label_Base_Sc.Text = String.Format("{0:0.00}", dr[9]);
                    label_Total_Sc.Text = String.Format("{0:0.00}", dr[10]);
                    label_Solde_Sc.Text = String.Format("{0:0.00}", dr[11]);
                    label_eche_NP_Sc.Text = dr[12].ToString();

                    double d13 = double.Parse(dr[13].ToString());
                    tb_échéance_Tr.Text = String.Format("{0:0.00}", d13);
                    N_UpDown_Tr.Value = int.Parse(dr[14].ToString());
                    label_Base_Tr.Text = String.Format("{0:0.00}", dr[15]);
                    label_Total_Tr.Text = String.Format("{0:0.00}", dr[16]);
                    label_Solde_Tr.Text = String.Format("{0:0.00}", dr[17]);
                    label_eche_NP_Tr.Text = dr[18].ToString();

                    double d19 = double.Parse(dr[19].ToString());
                    tb_échéance_ps1.Text = String.Format("{0:0.00}", d19);
                    N_UpDown_Ps1.Value = int.Parse(dr[20].ToString());
                    label_Base_Ps1.Text = String.Format("{0:0.00}", dr[21]);
                    label_Total_Ps1.Text = String.Format("{0:0.00}", dr[22]);
                    label_Solde_Ps1.Text = String.Format("{0:0.00}", dr[23]);
                    label_eche_NP_Ps1.Text = dr[24].ToString();

                    double d25 = double.Parse(dr[25].ToString());
                    tb_échéance_ps2.Text = String.Format("{0:0.00}", d25);
                    N_UpDown_Ps2.Value = int.Parse(dr[26].ToString());
                    label_Base_Ps2.Text = String.Format("{0:0.00}", dr[27]);
                    label_Total_Ps2.Text = String.Format("{0:0.00}", dr[28]);
                    label_Solde_Ps2.Text = String.Format("{0:0.00}", dr[29]);
                    label_eche_NP_Ps2.Text = dr[30].ToString();

                    double d31 = double.Parse(dr[31].ToString());
                    tb_échéance_ps3.Text = String.Format("{0:0.00}", d31);
                    N_UpDown_Ps3.Value = int.Parse(dr[32].ToString());
                    label_Base_Ps3.Text = String.Format("{0:0.00}", dr[33]);
                    label_Total_Ps3.Text = String.Format("{0:0.00}", dr[34]);
                    label_Solde_Ps3.Text = String.Format("{0:0.00}", dr[35]);
                    label_eche_NP_Ps3.Text = dr[36].ToString();





                    //Méthode CalculeMoi
                    //Fr
                    double PFR = PursontageFr(Convert.ToDouble(dr[1]), Convert.ToDouble(dr[4]));
                    label_eche_NP_Fr.Text = String.Format("{0:0.00}", PFR) + "%";
                    //Scolarité
                     int m1 = dtCacule(dtInsStr, Convert.ToDouble(dr[10]), Convert.ToDouble(dr[7]), (int)dr[8]);
                     label_eche_NP_Sc.Text = m1.ToString();
                    
                    //Transport
                    int m2 = dtCacule(dtInsStr, Convert.ToDouble(dr[16]), Convert.ToDouble(dr[13]), (int)dr[14]);
                    label_eche_NP_Tr.Text = m2.ToString();
                   
                    //Prestation1
                    int m3 = dtCacule(dtInsStr, Convert.ToDouble(dr[22]), Convert.ToDouble(dr[19]), (int)dr[20]);
                    label_eche_NP_Ps1.Text = m3.ToString();
                    
                    //Prestation2
                     int m4 = dtCacule(dtInsStr, Convert.ToDouble(dr[28]), Convert.ToDouble(dr[25]), (int)dr[26]);
                     label_eche_NP_Ps2.Text = m4.ToString();
                    
                    //Prestation3
                     int m5 = dtCacule(dtInsStr, Convert.ToDouble(dr[34]), Convert.ToDouble(dr[31]), (int)dr[32]);
                     label_eche_NP_Ps3.Text = m5.ToString();
                    



                }
            
                ddr.Close();
                conn.Close();
            }
        }

        public static int dtCacule(string dtIns, double totpy, double ech,int Mois)
        {
            if (ech == 0)
                return 0;
            String dtNow = DateTime.Now.ToString("dd/MM/yyyy");
      
            DateTime dt_current = Convert.ToDateTime("22/04/2020");
            DateTime dt_ins = Convert.ToDateTime(dtIns);
            if (dt_ins.Month > 4 && dt_ins.Month < 9)
            {
                dt_ins = Convert.ToDateTime("01/09/" + dt_ins.Year);
            }

            TimeSpan dt_result = dt_current.Subtract(dt_ins);
            double dt_dif = dt_result.Days;
            int months = (int)dt_dif / 30;


            if (months == 0)
                return 0;
            double monthspy = totpy / ech;
  
            if (months > Mois)
                months = Mois;




            if (monthspy >= months)
                return 0;

            return (int)(months - (int)monthspy);
        }

        private void Button_imprimer_Click_1(object sender, EventArgs e)
        {
            //if (tb_Matricule.Text == "")
            //{
            //    MessageBox.Show("Cherchez l'etudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    printPreviewDialog1.ShowDialog();
            //}
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;

            printPreviewDialog1.ShowDialog();
        }

        private void Button_Modifier_Click_1(object sender, EventArgs e)
        {
            if (tb_Matricule.Text == "")
            {
                MessageBox.Show("Cherchez l'etudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update etudiant set Nom = @Nom_etu,Prenom= @Prenom_etu,date_Nc=@date_Nc,sexe=@sexe, Mobile_Pr=@Mobile_Pr,classe=@classe, AnnésSc=@AnnésSc   where Matricule =@id", conn);
                cmd.Parameters.AddWithValue("id", tb_Matricule.Text);
                cmd.Parameters.AddWithValue("Nom_etu", tb_Nom.Text);
                cmd.Parameters.AddWithValue("Prenom_etu", tb_Prenom.Text);
                cmd.Parameters.AddWithValue("date_Nc", dateTimePicker_DN.Value);
                cmd.Parameters.AddWithValue("sexe", comboBox_Sexe.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("Mobile_Pr", textBox_Mobile.Text);
                cmd.Parameters.AddWithValue("classe", tb_Classe.Text);
                cmd.Parameters.AddWithValue("AnnésSc", comboBox_An.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                SqlCommand cmmd = new SqlCommand("update Detaile set   éch_Fr = @Fr_éch, Nbr_Fr = @Fr_Nbé,Base_Fr=@Base_Fr,Total_Fr=@Total_Fr,Solde_Fr=@Solde_Fr,éch_Fr_Np=@éch_Fr_Np , éch_Sc = @Sc_éch,  Nbr_Sc = @Sc_Nbé,  Base_Sc=@Base_Sc,Total_Sc=@Total_Sc,Solde_Sc=@Solde_Sc,éch_Sc_Np=@éch_Sc_Np,éch_Tr = @Tr_éch, Nbr_Tr = @Tr_Nbé, Base_Tr=@Base_Tr,Total_Tr=@Total_Tr,Solde_Tr=@Solde_Tr,éch_Tr_Np=@éch_Tr_Np  , éch_Ps1 = @Ps1_éch, Nbr_Ps1 = @Ps1_Nbé,  Base_Ps1=@Base_Ps1,Total_Ps1=@Total_Ps1,Solde_Ps1=@Solde_Ps1,éch_Ps1_Np=@éch_Ps1_Np, éch_Ps2 = @Ps2_éch, Nbr_Ps2 = @Ps2_Nbé, Base_Ps2=@Base_Ps2,Total_Ps2=@Total_Ps2,Solde_Ps2=@Solde_Ps2,éch_Ps2_Np=@éch_Ps2_Np,  éch_Ps3 = @Ps3_éch, Nbr_Ps3 = @Ps3_Nbé, Base_Ps3=@Base_Ps3,Total_Ps3=@Total_Ps3,Solde_Ps3=@Solde_Ps3,éch_Ps3_Np=@éch_Ps3_Np  where Matricule =@id", conn);
                cmmd.Parameters.AddWithValue("id", tb_Matricule.Text);
                //parametre de Frais
                cmmd.Parameters.AddWithValue("Fr_éch", Convert.ToDouble(tb_échéance_Fr.Text));
                cmmd.Parameters.AddWithValue("Fr_Nbé", N_UpDown_Fr.Value);
                cmmd.Parameters.AddWithValue("Base_Fr", Convert.ToDouble(label_Base_Fr.Text));
                cmmd.Parameters.AddWithValue("Total_Fr", Convert.ToDouble(label_Total_Fr.Text));
                cmmd.Parameters.AddWithValue("Solde_Fr", Convert.ToDouble(label_Solde_Fr.Text));
                cmmd.Parameters.AddWithValue("éch_Fr_Np", label_eche_NP_Fr.Text);

                //parametre de Scolaire
                cmmd.Parameters.AddWithValue("Sc_éch", Convert.ToDouble(tb_échéance_Sc.Text));
                cmmd.Parameters.AddWithValue("Sc_Nbé", N_UpDown_Sc.Text);
                cmmd.Parameters.AddWithValue("Base_Sc", Convert.ToDouble(label_Base_Sc.Text));
                cmmd.Parameters.AddWithValue("Total_Sc", Convert.ToDouble(label_Total_Sc.Text));
                cmmd.Parameters.AddWithValue("Solde_Sc", Convert.ToDouble(label_Solde_Sc.Text));
                cmmd.Parameters.AddWithValue("éch_Sc_Np", label_eche_NP_Sc.Text);
                //parametre de Transport
                cmmd.Parameters.AddWithValue("Tr_éch", Convert.ToDouble(tb_échéance_Tr.Text));
                cmmd.Parameters.AddWithValue("Tr_Nbé", N_UpDown_Tr.Text);
                cmmd.Parameters.AddWithValue("Base_Tr", Convert.ToDouble(label_Base_Tr.Text));
                cmmd.Parameters.AddWithValue("Total_Tr", Convert.ToDouble(label_Total_Tr.Text));
                cmmd.Parameters.AddWithValue("Solde_Tr", Convert.ToDouble(label_Solde_Tr.Text));
                cmmd.Parameters.AddWithValue("éch_Tr_Np", label_eche_NP_Tr.Text);
                //parametre de prestation1
                cmmd.Parameters.AddWithValue("Ps1_éch", Convert.ToDouble(tb_échéance_ps1.Text));
                cmmd.Parameters.AddWithValue("Ps1_Nbé", N_UpDown_Ps1.Text);
                cmmd.Parameters.AddWithValue("Base_Ps1", Convert.ToDouble(label_Base_Ps1.Text));
                cmmd.Parameters.AddWithValue("Total_Ps1", Convert.ToDouble(label_Total_Ps1.Text));
                cmmd.Parameters.AddWithValue("Solde_Ps1", Convert.ToDouble(label_Solde_Ps1.Text));
                cmmd.Parameters.AddWithValue("éch_Ps1_Np", label_eche_NP_Ps1.Text);
                //parametre de prestation2
                cmmd.Parameters.AddWithValue("Ps2_éch", Convert.ToDouble(tb_échéance_ps2.Text));
                cmmd.Parameters.AddWithValue("Ps2_Nbé", N_UpDown_Ps2.Text);
                cmmd.Parameters.AddWithValue("Base_Ps2", Convert.ToDouble(label_Base_Ps2.Text));
                cmmd.Parameters.AddWithValue("Total_Ps2", Convert.ToDouble(label_Total_Ps2.Text));
                cmmd.Parameters.AddWithValue("Solde_Ps2", Convert.ToDouble(label_Solde_Ps2.Text));
                cmmd.Parameters.AddWithValue("éch_Ps2_Np", label_eche_NP_Ps2.Text);
                //parametre de prestation3
                cmmd.Parameters.AddWithValue("Ps3_éch", Convert.ToDouble(tb_échéance_ps3.Text));
                cmmd.Parameters.AddWithValue("Ps3_Nbé", N_UpDown_Ps3.Text);
                cmmd.Parameters.AddWithValue("Base_Ps3", Convert.ToDouble(label_Base_Ps3.Text));
                cmmd.Parameters.AddWithValue("Total_Ps3", Convert.ToDouble(label_Total_Ps3.Text));
                cmmd.Parameters.AddWithValue("Solde_Ps3", Convert.ToDouble(label_Solde_Ps3.Text));
                cmmd.Parameters.AddWithValue("éch_Ps3_Np", label_eche_NP_Ps3.Text);

                cmmd.ExecuteNonQuery(); // Exécution de la requête SQL
                MessageBox.Show("La modification a été effectuée ");
                conn.Close();
            }
        }

        private void tb_échéance_Fr_Enter_1(object sender, EventArgs e)
        {
            if (tb_échéance_Fr.Text == "0")
            {
                tb_échéance_Fr.Text = "";
                tb_échéance_Fr.ForeColor = Color.Black;
            }
        }

        private void tb_échéance_Fr_Leave(object sender, EventArgs e)
        {
            if (tb_échéance_Fr.Text == "")
            {
                tb_échéance_Fr.Text = "0";
                tb_échéance_Fr.ForeColor = Color.White;
            }
        }

        private void tb_échéance_Sc_Enter(object sender, EventArgs e)
        {
            if (tb_échéance_Sc.Text == "0")
            {
                tb_échéance_Sc.Text = "";
                tb_échéance_Sc.ForeColor = Color.Black;
            }
        }

        private void tb_échéance_Sc_Leave(object sender, EventArgs e)
        {
            if (tb_échéance_Sc.Text == "")
            {
                tb_échéance_Sc.Text = "0";
                tb_échéance_Sc.ForeColor = Color.White;
            }
        }

        private void tb_échéance_Tr_Enter(object sender, EventArgs e)
        {
            if (tb_échéance_Tr.Text == "0")
            {
                tb_échéance_Tr.Text = "";
                tb_échéance_Tr.ForeColor = Color.Black;
            }
        }

        private void tb_échéance_Tr_Leave(object sender, EventArgs e)
        {
            if (tb_échéance_Tr.Text == "")
            {
                tb_échéance_Tr.Text = "0";
                tb_échéance_Tr.ForeColor = Color.White;
            }
        }

        private void tb_échéance_ps1_Enter(object sender, EventArgs e)
        {
            if (tb_échéance_ps1.Text == "0")
            {
                tb_échéance_ps1.Text = "";
                tb_échéance_ps1.ForeColor = Color.Black;
            }
        }

        private void tb_échéance_ps1_Leave(object sender, EventArgs e)
        {
            if (tb_échéance_ps1.Text == "")
            {
                tb_échéance_ps1.Text = "0";
                tb_échéance_ps1.ForeColor = Color.White;
            }
        }

        private void tb_échéance_ps2_Enter(object sender, EventArgs e)
        {
            if (tb_échéance_ps2.Text == "0")
            {
                tb_échéance_ps2.Text = "";
                tb_échéance_ps2.ForeColor = Color.Black;
            }
        }

        private void tb_échéance_ps2_Leave(object sender, EventArgs e)
        {
            if (tb_échéance_ps2.Text == "")
            {
                tb_échéance_ps2.Text = "0";
                tb_échéance_ps2.ForeColor = Color.White;
            }
        }

        private void tb_échéance_ps3_Enter(object sender, EventArgs e)
        {
            if (tb_échéance_ps3.Text == "0")
            {
                tb_échéance_ps3.Text = "";
                tb_échéance_ps3.ForeColor = Color.Black;
            }
        }

        private void tb_échéance_ps3_Leave(object sender, EventArgs e)
        {
            if (tb_échéance_ps3.Text == "")
            {
                tb_échéance_ps3.Text = "0";
                tb_échéance_ps3.ForeColor = Color.White;
            }
        }

        private void tb_échéance_Fr_TextChanged(object sender, EventArgs e)
        {
            Fr_TextCh();
        }

        private void N_UpDown_Fr_ValueChanged(object sender, EventArgs e)
        {
            Fr_TextCh();
        }

        private void tb_échéance_Sc_TextChanged(object sender, EventArgs e)
        {
            Sc_TextCh();
        }

        private void N_UpDown_Sc_ValueChanged(object sender, EventArgs e)
        {
            Sc_TextCh();
        }

        private void tb_échéance_Tr_TextChanged(object sender, EventArgs e)
        {
            Tr_TextCh();
        }

        private void N_UpDown_Tr_ValueChanged(object sender, EventArgs e)
        {
            Tr_TextCh();
        }

        private void tb_échéance_ps1_TextChanged(object sender, EventArgs e)
        {
            Ps1_TextCh();
        }

        private void N_UpDown_Ps1_ValueChanged(object sender, EventArgs e)
        {
            Ps1_TextCh();
        }

        private void tb_échéance_ps2_TextChanged(object sender, EventArgs e)
        {
            Ps2_TextCh();
        }

        private void N_UpDown_Ps2_ValueChanged(object sender, EventArgs e)
        {
            Ps2_TextCh();
        }

        private void tb_échéance_ps3_TextChanged(object sender, EventArgs e)
        {
            Ps3_TextCh();
        }

        private void N_UpDown_Ps3_ValueChanged(object sender, EventArgs e)
        {
            Ps3_TextCh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Buttones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string anneajout = "";
            string lstItem = comboBox_An.Items[comboBox_An.Items.Count-1].ToString();
            string[] dateSplit = lstItem.Split('/');
            int dateFirst = int.Parse(dateSplit[0]);
            int dateSecond = int.Parse(dateSplit[1]);
            ++dateFirst;
            ++dateSecond;
            SqlCommand cmd = new SqlCommand("insert into annesScolaire values ('" + dateFirst + "/" + dateSecond + "')",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fillCombo();
            MessageBox.Show("Date ajoute");
        }
    }
}
