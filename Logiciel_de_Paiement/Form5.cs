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
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;

namespace Logiciel_de_Paiement
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RQ9PT5M;Initial Catalog=LogicielDePaiement;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataReader dr;

        private void show()
        {
            SqlCommand cmd = new SqlCommand("select * from etudiant", conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            if (dt.Rows.Count == 0)
                dt.Load(dr);

            dataGridView1.DataSource = dt;
            //dataGridView1.Columns.ReadOnly = true;
            dr.Close();
            conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logicielDePaiementDataSet2.etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter1.Fill(this.logicielDePaiementDataSet2.etudiant);
            //// TODO: This line of code loads data into the 'logicielDePaiementDataSet1.etudiant' table. You can move, or remove it, as needed.
            //this.etudiantTableAdapter.Fill(this.logicielDePaiementDataSet1.etudiant);
            show();
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Mypaper", this.Height - 123, this.Width );
            //printDocument1.DefaultPageSettings.Landscape = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void detaileEtudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(dt);
            f8.Show();
            this.Hide();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap btm = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
            //dataGridView1.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            //for(int line =0; line<dataGridView1.Rows.Count;line++)
            //e.Graphics.DrawString("Liste de etudiant",new Font("Century Gothic", 22,FontStyle.Bold),Brushes.Red,new Point(600,2));
            //e.Graphics.DrawImage(btm, 0,40);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {

            dt.DefaultView.RowFilter = dataGridView1.FilterString;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            dt.DefaultView.Sort = dataGridView1.SortString;
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
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
                        ExcelADD.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelADD.Columns.AutoFit();
                ExcelADD.Visible = true;
            }
            //else
            //{
            //    MessageBox.Show("Liste de etudiant est vide");
            //}
        }
    }
}
