﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;


namespace Logiciel_de_Paiement
{

    public partial class Form9 : Form
    {
        DataTable dt = new DataTable();
        private bool checkCh = true;
        public Form9()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial Catalog=LogicielDePaiement;Integrated Security=True");

        SqlDataReader dr;

        private void dtError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        public void showDB()
        {
            SqlCommand cmd = new SqlCommand("select * from Paiement", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            if (dt.Rows.Count == 0)
            {
                dt.Load(dr);

            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dr.Close();
            SqlCommand sqlCmd = new SqlCommand("select * from CompteBnq", conn);
            SqlDataReader rd = sqlCmd.ExecuteReader();

            dataGridView1.Columns.RemoveAt(26);
            dataGridView1.Columns.RemoveAt(22);
            dataGridView1.Columns.RemoveAt(21);
            dataGridView1.Columns.RemoveAt(15);
            dataGridView1.Columns.RemoveAt(14);


            DataGridViewComboBoxColumn cmb1 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn cmb2 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn cmb3 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn cmb4 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn cmb5 = new DataGridViewComboBoxColumn();
            //DataGridViewButtonColumn ButtonInsert = new DataGridViewButtonColumn();
            cmb1.HeaderText = "Bnq_Remise_chèq";
            cmb2.HeaderText = "sort_Chèque";
            cmb3.HeaderText = "Bnq_Remise_Trt";
            cmb4.HeaderText = "sort_Traite";
            cmb5.HeaderText = "Bnq_Remise_Vrm";
            while (rd.Read())
            {
                cmb1.Items.Add(rd[0]);
                cmb3.Items.Add(rd[0]);
                cmb5.Items.Add(rd[0]);

            }
            rd.Close();



            cmb2.Items.Add("Impayé");
            cmb2.Items.Add("Validé");
            cmb4.Items.Add("Impayé");
            cmb4.Items.Add("Validé");



            dataGridView1.Columns.Insert(14, cmb1);
            dataGridView1.Columns.Insert(15, cmb2);
            dataGridView1.Columns.Insert(21, cmb3);
            dataGridView1.Columns.Insert(22, cmb4);
            dataGridView1.Columns.Insert(26, cmb5);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != 7 && j != 13 && j != 14 && j != 15 && j != 16 && j != 20 && j != 21 && j != 22 && j != 23 && j != 26)
                        dataGridView1.Columns[j].ReadOnly = true;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewComboBoxCell cb14 = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[14];
                cb14.Value = dt.Rows[i][14].ToString();
                DataGridViewComboBoxCell cb21 = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[21];
                cb21.Value = dt.Rows[i][21].ToString();
                DataGridViewComboBoxCell cb26 = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[26];
                cb26.Value = dt.Rows[i][26].ToString();
                DataGridViewComboBoxCell cb15 = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[15];
                cb15.Value = dt.Rows[i][15].ToString();
                DataGridViewComboBoxCell cb22 = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[22];
                cb22.Value = dt.Rows[i][22].ToString();

            }
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dtError);
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);



            conn.Close();
        }

        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }



        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cb.Value != null)
                {
                    // do stuff
                    if (!checkCh)
                        return;
                    if (e.ColumnIndex == 14)
                    {
                        DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            SqlCommand sqlCmd = new SqlCommand("update Paiement set Bnq_Remise_Chèq = @vl where N_Reçu = @num", conn);
                            sqlCmd.Parameters.AddWithValue("vl", cb.Value);
                            sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                            conn.Open();
                            sqlCmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    else
                    if (e.ColumnIndex == 15)
                    {
                        DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            SqlCommand sqlCmd = new SqlCommand("update Paiement set sort_Chèque = @vl where N_Reçu = @num", conn);
                            sqlCmd.Parameters.AddWithValue("vl", cb.Value);
                            sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                            conn.Open();
                            sqlCmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    else
                    if (e.ColumnIndex == 21)
                    {
                        DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            SqlCommand sqlCmd = new SqlCommand("update Paiement set Bnq_Remise_Trt = @vl where N_Reçu = @num", conn);
                            sqlCmd.Parameters.AddWithValue("vl", cb.Value);
                            sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                            conn.Open();
                            sqlCmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    else
                        if (e.ColumnIndex == 22)
                    {
                        DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            SqlCommand sqlCmd = new SqlCommand("update Paiement set sort_Traite = @vl where N_Reçu = @num", conn);
                            sqlCmd.Parameters.AddWithValue("vl", cb.Value);
                            sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                            conn.Open();
                            sqlCmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    else
                        if (e.ColumnIndex == 26)
                    {
                        DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            SqlCommand sqlCmd = new SqlCommand("update Paiement set Bnq_Remise_Vrm = @vl where N_Reçu = @num", conn);
                            sqlCmd.Parameters.AddWithValue("vl", cb.Value);
                            sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                            conn.Open();
                            sqlCmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                if (e.ColumnIndex == 13)
                {
                    DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand sqlCmd = new SqlCommand("update Paiement set date_Remise_chèq = @vl where N_Reçu = @num", conn);
                        sqlCmd.Parameters.AddWithValue("vl", dataGridView1.Rows[e.RowIndex].Cells[13].Value);
                        sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                if (e.ColumnIndex == 7)
                {
                    DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand sqlCmd = new SqlCommand("update Paiement set Detaile = @vl where N_Reçu = @num", conn);
                        sqlCmd.Parameters.AddWithValue("vl", dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                        sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
                else
                     if (e.ColumnIndex == 16)
                {
                    DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand sqlCmd = new SqlCommand("update Paiement set date_Credit_chèq = @vl where N_Reçu = @num", conn);
                        sqlCmd.Parameters.AddWithValue("vl", dataGridView1.Rows[e.RowIndex].Cells[16].Value);
                        sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else if (e.ColumnIndex == 20)
                {
                    DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand sqlCmd = new SqlCommand("update Paiement set date_Remise_Trt = @vl where N_Reçu = @num", conn);
                        sqlCmd.Parameters.AddWithValue("vl", dataGridView1.Rows[e.RowIndex].Cells[20].Value);
                        sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
                else if (e.ColumnIndex == 23)
                {
                    DialogResult dialog = MessageBox.Show("Voullez vous vraiment Modifier cette case ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        SqlCommand sqlCmd = new SqlCommand("update Paiement set date_Credit_Trt = @vl where N_Reçu = @num", conn);
                        sqlCmd.Parameters.AddWithValue("vl", dataGridView1.Rows[e.RowIndex].Cells[23].Value);
                        sqlCmd.Parameters.AddWithValue("num", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        conn.Open();
                        sqlCmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logicielDePaiementDataSet5.Paiement' table. You can move, or remove it, as needed.
            this.paiementTableAdapter.Fill(this.logicielDePaiementDataSet5.Paiement);
            // TODO: This line of code loads data into the 'logicielDePaiementDataSet4.Paiement' table. You can move, or remove it, as needed.
            this.paiementTableAdapter1.Fill(this.logicielDePaiementDataSet4.Paiement);
            showDB();
            clculeEspeces();
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Mypaper", this.Height - 155, this.Width);
            //printDocument1.DefaultPageSettings.Landscape = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void clculeEspeces()
        {
            double m = 0;
            double l = 0;
            double k = 0;
            double p = 0;
            double t = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                m += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                l += Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);
                k += Convert.ToDouble(dataGridView1.Rows[i].Cells[17].Value);
                p += Convert.ToDouble(dataGridView1.Rows[i].Cells[24].Value);
                t = m + l + k + p;
            }
            label_Es.Text = m.ToString();
            label_ch.Text = l.ToString();
            label_Tr.Text = k.ToString();
            label_Vm.Text = p.ToString();
            label_TG.Text = t.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 27 && e.RowIndex != -1)
            {
                conn.Open();
                string sqlcmd = "insert into Paiement(Bnq_Remise_chéq,sort_Chéque, Bnq_Remise_Trt,sort_Traite, Bnq_Remise_Vrm )";
                sqlcmd = sqlcmd + "values(@Bnq_ch,@Sort_Ch,@Bnq_Tr,@Sort_Tr,@Bnq_Vm)";
                SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("Bnq_ch", dr[14].ToString());
                cmd.Parameters.AddWithValue("Sort_Ch", dr[15].ToString());
                cmd.Parameters.AddWithValue("Bnq_Tr", dr[21].ToString());
                cmd.Parameters.AddWithValue("Sort_Tr", dr[22].ToString());
                cmd.Parameters.AddWithValue("Bnq_Vm", dr[26].ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            f6.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Font f = new Font("Century Gothic", 22, FontStyle.Bold);
            //float height = dataGridView1.Height+f.Height;

            //Bitmap btm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            //dataGridView1.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            ////for (int line = 0; line < dataGridView1.Rows.Count; line++)
            //    e.Graphics.DrawString("Liste de Paiement", f, Brushes.Red, new Point(600, 2));
            //e.Graphics.DrawImage(btm, -40, 40);
        }

        private void dataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            dt.DefaultView.RowFilter = dataGridView1.FilterString;
            dataGridView1.DataSource = dt;
            clculeEspeces();
        }

        private void dataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            dt.DefaultView.Sort = dataGridView1.SortString;
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                checkCh = false;
                Excel.Application ExcelADD = new Excel.Application();
                ExcelADD.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelADD.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "";
                        }
                        if (j == 5 || j ==9 || j ==12 || j ==19 ||j==25)
                        {
                            ExcelADD.Cells[i + 2, j + 1] = Convert.ToDateTime((dataGridView1.Rows[i].Cells[5].Value)).ToString("dd/MM/yyyy");
                            ExcelADD.Cells[i + 2, j + 1] = Convert.ToDateTime((dataGridView1.Rows[i].Cells[9].Value)).ToString("dd/MM/yyyy");
                            ExcelADD.Cells[i + 2, j + 1] = Convert.ToDateTime((dataGridView1.Rows[i].Cells[12].Value)).ToString("dd/MM/yyyy");
                            ExcelADD.Cells[i + 2, j + 1] = Convert.ToDateTime((dataGridView1.Rows[i].Cells[19].Value)).ToString("dd/MM/yyyy");
                            ExcelADD.Cells[i + 2, j + 1] = Convert.ToDateTime((dataGridView1.Rows[i].Cells[25].Value)).ToString("dd/MM/yyyy");
                        }
                        else if (j == 8)
                        {
                            ExcelADD.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        }
                        else
                        {
                            ExcelADD.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                ExcelADD.Columns.AutoFit();
                ExcelADD.Visible = true;
                checkCh = true;
            }
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 8 || e.ColumnIndex == 10 || e.ColumnIndex == 17 || e.ColumnIndex == 24)
            //{
            //    if (e.Value != null)
            //    {
            //        try
            //        {
            //            string temp = e.Value.ToString().Replace(",", ".");
            //            temp = temp.Remove(temp.Length - 2, 2);
            //            e.Value = temp;
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //    }
            //}
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataTable Dp = new DataTable();
            SqlCommand cmdP = new SqlCommand("Select * from DetailePaiement where N_Reçu=@N_ReçuPaiement", conn);
            cmdP.Parameters.AddWithValue("N_ReçuPaiement", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            conn.Open();
            SqlDataReader dr = cmdP.ExecuteReader();
            Dp.Load(dr);
            conn.Close();

            //MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value + "");
            e.Graphics.DrawString(label_Nom_ecole.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, 10, 15);
            e.Graphics.DrawString("\n" + "école primaire à Tanger" + "\n", new Font("Century Gothic", 10), Brushes.Black, 20, 25);
            e.Graphics.DrawImage(pictureBox3.Image, 340, 0, 150, 70);
            e.Graphics.DrawString(label_Ns_Arabe.Text, new Font("Arabic Typesetting", 22, FontStyle.Bold), Brushes.Black, 660, 10);
            e.Graphics.DrawString("\n" + "مدرسة إبتدائية بطنجة", new Font("Arabic Typesetting", 20), Brushes.Black, 670, 5);

            //
            e.Graphics.DrawString("\n\n\n" + "Tanger le :", new Font("Century Gothic", 10), Brushes.Black, 188, 20);
            e.Graphics.DrawString("\n\n" + dateTimePicker_Djeur.Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 25);
            e.Graphics.DrawString("\n\n\n" + ": طنجة في", new Font("Arabic Typesetting", 18), Brushes.Black, 570, -15);
            //
            e.Graphics.DrawString("\n\n\n" + "Reçu de paiement N° :", new Font("Century Gothic", 10), Brushes.Black, 96, 45);
            e.Graphics.DrawString("\n" + "00" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() + "/" + DateTime.Today.Year, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 70);
            e.Graphics.DrawString("\n\n\n" + ": توصيل أداء رقم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 7);
            //
            e.Graphics.DrawString("\n\n\n\n" + "Années Scolaire:", new Font("Century Gothic", 10), Brushes.Black, 140, 55);
            e.Graphics.DrawString("\n\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 74);
            e.Graphics.DrawString("\n\n\n\n" + ":السنة الدراسية", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 5);

            //  
            e.Graphics.DrawString("\n\n\n\n\n\n" + "Matricule de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 110, 45);
            e.Graphics.DrawString("\n\n\n\n" + "00" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 370, 55);
            e.Graphics.DrawString("\n\n\n\n\n\n" + ":(رقم تسجيل التلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570, -30);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n" + "Nom et Prénom de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 65, 55);
            e.Graphics.DrawString("\n\n\n\n\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 57);
            e.Graphics.DrawString("\n\n\n\n\n\n\n" + ":(الإسم العائلي و الشخصي للتلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570, -30);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + "Classe :", new Font("Century Gothic", 10), Brushes.Black, 195, 60);
            e.Graphics.DrawString("\n\n\n\n\n\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 60);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + ": القسم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, -37);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + "Reçu de parent/tuteur de l'élève le paiement détaillé comme suite :", new Font("Century Gothic", 9), Brushes.Black, 6, 95);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n" + "توصلت الإدارة من ولي أمر التلميذ (ة" + ") بالأداءالمفصل كالتالي", new Font("Arabic Typesetting", 16), Brushes.Black, 500, 13);
            //Table 1
            e.Graphics.DrawRectangle(Pens.Black, 40, 240, 500, 183);
            //Line
            e.Graphics.DrawLine(Pens.Black, 40, 275, 740, 275);
            e.Graphics.DrawLine(Pens.Black, 40, 295, 740, 295);
            e.Graphics.DrawLine(Pens.Black, 40, 315, 740, 315);
            e.Graphics.DrawLine(Pens.Black, 40, 335, 740, 335);
            e.Graphics.DrawLine(Pens.Black, 40, 355, 740, 355);
            e.Graphics.DrawLine(Pens.Black, 40, 375, 740, 375);
            e.Graphics.DrawLine(Pens.Black, 40, 395, 740, 395);
            //Colonne
            e.Graphics.DrawLine(Pens.Black, 370, 240, 370, e.PageBounds.Height - 745);
            e.Graphics.DrawLine(Pens.Black, 200, 240, 200, e.PageBounds.Height - 745);
            e.Graphics.DrawLine(Pens.Black, 740, 275, 740, e.PageBounds.Height - 775);
            /////
            e.Graphics.DrawString("Frais d'inscription  " + "رسوم التسجيل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 275);
            e.Graphics.DrawString("Scolarité Mensuelle   " + "الواجب الشهري ", new Font("Arabic Typesetting", 13), Brushes.Black, 553, 295);
            e.Graphics.DrawString("Frais de Transport    " + "واجب النقل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 315);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 1 ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 335);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 2", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 355);
            e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 3", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 375);
            e.Graphics.DrawString("Détail du mode de ce paiement  " + "تفصيل طريقة هذا الأداء", new Font("Arabic Typesetting", 13), Brushes.Black, 410, 425);
            e.Graphics.DrawString("Désignation : ", new Font("verdana", 10), Brushes.Black, 50, 532);
            e.Graphics.DrawString(": تعيين  ", new Font("verdana", 10), Brushes.Black, 650, 532);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString(), new Font("verdana", 10), Brushes.Black, 165, 532);
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------- ", new Font("verdana", 10), Brushes.Black, 0, 573);

            //////
            e.Graphics.DrawString("الرصيد السنوي السابق", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 240);
            e.Graphics.DrawString("\n" + "Ancien solde annuel ", new Font("Century Gothic", 9), Brushes.Black, 390, 242);
            e.Graphics.DrawString("\n" + Dp.Rows[0][1], new Font("Century Gothic", 10), Brushes.Black, 420, 260);
            //e.Graphics.DrawString("\n" + label_Savp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 280);
            //e.Graphics.DrawString("\n" + label_Savp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 300);
            //e.Graphics.DrawString("\n" + label_Savp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 320);
            //e.Graphics.DrawString("\n" + label_Savp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 340);
            //e.Graphics.DrawString("\n" + label_Savp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 360);
            e.Graphics.DrawString("\n" + ": مجموع الأداء بالدرهم", new Font("Arabic Typesetting", 15), Brushes.Black, 405, 375);
            //
            e.Graphics.DrawString("مبلغ الأداء الحالي", new Font("Arabic Typesetting", 14), Brushes.Black, 250, 240);
            //e.Graphics.DrawString("\n" + "Montant payé actuel", new Font("Century Gothic", 9), Brushes.Black, 220, 242);
            //e.Graphics.DrawString("\n" + label_Totpy_Fr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 260);
            //e.Graphics.DrawString("\n" + label_Totpy_Sc.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 280);
            //e.Graphics.DrawString("\n" + label_Totpy_Tr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 300);
            //e.Graphics.DrawString("\n" + label_Totpy_Ps1.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 320);
            //e.Graphics.DrawString("\n" + label_Totpy_Ps2.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 340);
            //e.Graphics.DrawString("\n" + label_Totpy_Ps3.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 360);
            //e.Graphics.DrawString("\n" + label_TotalPaye.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, 240, 363);
            e.Graphics.DrawString("\n" + "i", new Font("Wingdings 3", 20, FontStyle.Bold), Brushes.Black, 330, 389);
            ////
            e.Graphics.DrawString("الرصيد السنوي الجديد", new Font("Arabic Typesetting", 14), Brushes.Black, 70, 240);
            //e.Graphics.DrawString("\n" + "Nouveau solde annuel", new Font("Century Gothic", 9), Brushes.Black, 50, 242);
            //e.Graphics.DrawString("\n" + label_Sapp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 260);
            //e.Graphics.DrawString("\n" + label_Sapp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 280);
            //e.Graphics.DrawString("\n" + label_Sapp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 300);
            //e.Graphics.DrawString("\n" + label_Sapp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 320);
            //e.Graphics.DrawString("\n" + label_Sapp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 340);
            //e.Graphics.DrawString("\n" + label_Sapp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 360);
            e.Graphics.DrawString("\n" + "Total payé en Dirhame :", new Font("Arabic Typesetting", 15), Brushes.Black, 45, 375);
            //Table 2
            e.Graphics.DrawRectangle(Pens.Black, 300, 445, 400, 80);
            //Line
            e.Graphics.DrawLine(Pens.Black, 300, 465, 700, 465);
            e.Graphics.DrawLine(Pens.Black, 300, 485, 700, 485);
            e.Graphics.DrawLine(Pens.Black, 300, 505, 700, 505);
            //colonne
            e.Graphics.DrawLine(Pens.Black, 390, 445, 390, e.PageBounds.Height - 645);
            //
            e.Graphics.DrawString("Espèces du                " + "                             نقدا في", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 445);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString(), new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 505, 447);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 430);

            e.Graphics.DrawString("Chèque Numéro        " + "                             شيك رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 467);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[11].Value.ToString(), new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 463);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 450);

            e.Graphics.DrawString("Traite Numéro             " + "                           كمبيالة رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 487);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[18].Value.ToString(), new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 484);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[17].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 470);

            e.Graphics.DrawString("Virement du             " + "                          تحويل بنكي في", new Font("Arabic Typesetting", 14), Brushes.Black, 393, 505);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[25].Value.ToString() ,new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 495, 507);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[24].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 490);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label_Nom_ecole.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, 10, 60);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n" + "école primaire à Tanger" + "\n", new Font("Century Gothic", 10), Brushes.Black, 20, 70);
            e.Graphics.DrawImage(pictureBox4.Image, 340, 590, 150, 70);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label_Ns_Arabe.Text, new Font("Arabic Typesetting", 22, FontStyle.Bold), Brushes.Black, 660, 45);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n" + "مدرسة إبتدائية بطنجة", new Font("Arabic Typesetting", 20), Brushes.Black, 670, 52);

            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + "Tanger le :", new Font("Century Gothic", 10), Brushes.Black, 188, 47);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n" + dateTimePicker_Djeur.Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 165);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + ": طنجة في", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 78);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + "Reçu de paiement N° :", new Font("Century Gothic", 10), Brushes.Black, 96, 175);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n" + "00" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() + "/" + DateTime.Today.Year, new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 145);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n" + ": توصيل أداء رقم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 45);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n\n\n" + "Années Scolaire:", new Font("Century Gothic", 10), Brushes.Black, 140, 150);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "\n\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 105);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ":السنة الدراسية", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 45);



            //  
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Matricule de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 110, 227);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "00" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 370, 87);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ":(رقم تسجيل التلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 72);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Nom et Prénom de l'élève:", new Font("Century Gothic", 10), Brushes.Black, 65, 255);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 310, 115);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ":(الإسم العائلي و الشخصي للتلميذ (ة", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 100);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Classe :", new Font("Century Gothic", 10), Brushes.Black, 195, 279);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString(), new Font("times new roman", 14, FontStyle.Bold), Brushes.Black, 350, 137);
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + ": القسم", new Font("Arabic Typesetting", 18), Brushes.Black, 570, 125);
            //
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + "Reçu de parent/tuteur de l'élève le paiement détaillé comme suite :", new Font("Century Gothic", 9), Brushes.Black, 6, 350);
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
            e.Graphics.DrawLine(Pens.Black, 740, 865, 740, e.PageBounds.Height - 185);
            e.Graphics.DrawLine(Pens.Black, 370, 830, 370, e.PageBounds.Height - 155);
            e.Graphics.DrawLine(Pens.Black, 200, 830, 200, e.PageBounds.Height - 155);
            ///////
            e.Graphics.DrawString("Frais d'inscription  " + "رسوم التسجيل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 865);
            //e.Graphics.DrawString("Scolarité Mensuelle   " + "الواجب الشهري ", new Font("Arabic Typesetting", 13), Brushes.Black, 553, 885);
            //e.Graphics.DrawString("Frais de Transport    " + "واجب النقل ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 905);
            //e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 1 ", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 925);
            //e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 2", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 945);
            //e.Graphics.DrawString("Autre Prestation   " + "خدمة أخرى 3", new Font("Arabic Typesetting", 13), Brushes.Black, 560, 965);
            //e.Graphics.DrawString("Détail du mode de ce paiement  " + "تفصيل طريقة هذا الأداء", new Font("Arabic Typesetting", 13), Brushes.Black, 410, 1015);
            e.Graphics.DrawString("Désignation : ", new Font("verdana", 10), Brushes.Black, 50, 1127);
            e.Graphics.DrawString(": تعيين  ", new Font("verdana", 10), Brushes.Black, 650, 1127);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString(), new Font("verdana", 10), Brushes.Black, 165, 1127);
            ////////
            e.Graphics.DrawString("الرصيد السنوي السابق", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 830);
            //e.Graphics.DrawString("\n" + "Ancien solde annuel ", new Font("Century Gothic", 9), Brushes.Black, 390, 830);
            //e.Graphics.DrawString("\n" + label_Savp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 850);
            //e.Graphics.DrawString("\n" + label_Savp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 870);
            //e.Graphics.DrawString("\n" + label_Savp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 890);
            //e.Graphics.DrawString("\n" + label_Savp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 910);
            //e.Graphics.DrawString("\n" + label_Savp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 930);
            //e.Graphics.DrawString("\n" + label_Savp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 420, 950);
            e.Graphics.DrawString("\n" + ": مجموع الأداء بالدرهم", new Font("Arabic Typesetting", 15), Brushes.Black, 405, 963);
            ////
            e.Graphics.DrawString("مبلغ الأداء الحالي", new Font("Arabic Typesetting", 14), Brushes.Black, 250, 830);
            //e.Graphics.DrawString("\n" + "Montant payé actuel", new Font("Century Gothic", 9), Brushes.Black, 220, 830);
            //e.Graphics.DrawString("\n" + label_Totpy_Fr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 850);
            //e.Graphics.DrawString("\n" + label_Totpy_Sc.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 870);
            //e.Graphics.DrawString("\n" + label_Totpy_Tr.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 890);
            //e.Graphics.DrawString("\n" + label_Totpy_Ps1.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 910);
            //e.Graphics.DrawString("\n" + label_Totpy_Ps2.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 930);
            //e.Graphics.DrawString("\n" + label_Totpy_Ps3.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, 255, 950);
            //e.Graphics.DrawString("\n" + label_TotalPaye.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, 240, 953);
            e.Graphics.DrawString("\n" + "i", new Font("Wingdings 3", 20, FontStyle.Bold), Brushes.Black, 330, 979);
            ////
            e.Graphics.DrawString("الرصيد السنوي الجديد", new Font("Arabic Typesetting", 14), Brushes.Black, 70, 830);
            //e.Graphics.DrawString("\n" + "Nouveau solde annuel", new Font("Century Gothic", 9), Brushes.Black, 50, 830);
            //e.Graphics.DrawString("\n" + label_Sapp_Fr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 850);
            //e.Graphics.DrawString("\n" + label_Sapp_Sc.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 870);
            //e.Graphics.DrawString("\n" + label_Sapp_Tr.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 890);
            //e.Graphics.DrawString("\n" + label_Sapp_Ps1.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 910);
            //e.Graphics.DrawString("\n" + label_Sapp_Ps2.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 930);
            //e.Graphics.DrawString("\n" + label_Sapp_Ps3.Text, new Font("Century Gothic", 10), Brushes.Black, 90, 950);
            e.Graphics.DrawString("\n" + "Total payé en Dirhame :", new Font("Arabic Typesetting", 15), Brushes.Black, 45, 965);
            //Table 2
            e.Graphics.DrawRectangle(Pens.Black, 300, 1035, 400, 80);
            //Line
            e.Graphics.DrawLine(Pens.Black, 300, 1055, 700, 1055);
            e.Graphics.DrawLine(Pens.Black, 300, 1075, 700, 1075);
            e.Graphics.DrawLine(Pens.Black, 300, 1095, 700, 1095);
            //colonne
            e.Graphics.DrawLine(Pens.Black, 390, 1035, 390, e.PageBounds.Height - 55);
            //
            e.Graphics.DrawString("Espèces du                " + "                             نقدا في", new Font("Arabic Typesetting", 14), Brushes.Black, 400, 1035);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString(), new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 505, 1037);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 1020);

            e.Graphics.DrawString("Chèque Numéro        " + "                             شيك رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 1057);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[11].Value.ToString(), new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 1053);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 1040);

            e.Graphics.DrawString("Traite Numéro             " + "                           كمبيالة رقم", new Font("Arabic Typesetting", 14), Brushes.Black, 395, 1077);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[18].Value.ToString(), new Font("Century Gothic", 11, FontStyle.Bold), Brushes.Black, 520, 1074);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[17].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 1060);

            e.Graphics.DrawString("Virement du             " + "                          تحويل بنكي في", new Font("Arabic Typesetting", 14), Brushes.Black, 393, 1095);
            e.Graphics.DrawString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[25].Value.ToString(), new Font("Verdana", 9, FontStyle.Bold), Brushes.Black, 495, 1097);
            e.Graphics.DrawString("\n" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[24].Value.ToString(), new Font("Century Gothic", 10), Brushes.Black, 320, 1080);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Table 3
            e.Graphics.DrawRectangle(Pens.Black, 150, 1122, 500, 30);
            //Line
            //Table 3
            e.Graphics.DrawRectangle(Pens.Black, 150, 530, 500, 30);
            //Line

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.ShowDialog();
        }
    }
}
