namespace Logiciel_de_Paiement
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.detaileEtudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annésScDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logicielDePaiementDataSet1 = new Logiciel_de_Paiement.LogicielDePaiementDataSet1();
            this.etudiantTableAdapter = new Logiciel_de_Paiement.LogicielDePaiementDataSet1TableAdapters.etudiantTableAdapter();
            this.etudiantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logicielDePaiementDataSet2 = new Logiciel_de_Paiement.LogicielDePaiementDataSet2();
            this.etudiantTableAdapter1 = new Logiciel_de_Paiement.LogicielDePaiementDataSet2TableAdapters.etudiantTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicielDePaiementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicielDePaiementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(961, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 53);
            this.button2.TabIndex = 107;
            this.button2.Text = "Exporter Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1162, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 53);
            this.button1.TabIndex = 106;
            this.button1.Text = "Imprimer Liste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Location = new System.Drawing.Point(7, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(48, 54);
            this.groupBox6.TabIndex = 104;
            this.groupBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaileEtudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // detaileEtudianteToolStripMenuItem
            // 
            this.detaileEtudianteToolStripMenuItem.Name = "detaileEtudianteToolStripMenuItem";
            this.detaileEtudianteToolStripMenuItem.Size = new System.Drawing.Size(198, 29);
            this.detaileEtudianteToolStripMenuItem.Text = "Détaile etudiante";
            this.detaileEtudianteToolStripMenuItem.Click += new System.EventHandler(this.detaileEtudianteToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNcDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.mobilePrDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.annésScDataGridViewTextBoxColumn,
            this.dateInSDataGridViewTextBoxColumn,
            this.nomUtlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etudiantBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.FilterAndSortEnabled = true;
            this.dataGridView1.Location = new System.Drawing.Point(0, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 574);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dataGridView1_SortStringChanged);
            this.dataGridView1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dataGridView1_FilterStringChanged);
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            this.matriculeDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dateNcDataGridViewTextBoxColumn
            // 
            this.dateNcDataGridViewTextBoxColumn.DataPropertyName = "date_Nc";
            this.dateNcDataGridViewTextBoxColumn.HeaderText = "date_Nc";
            this.dateNcDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dateNcDataGridViewTextBoxColumn.Name = "dateNcDataGridViewTextBoxColumn";
            this.dateNcDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateNcDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "sexe";
            this.sexeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mobilePrDataGridViewTextBoxColumn
            // 
            this.mobilePrDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Pr";
            this.mobilePrDataGridViewTextBoxColumn.HeaderText = "Mobile_Pr";
            this.mobilePrDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.mobilePrDataGridViewTextBoxColumn.Name = "mobilePrDataGridViewTextBoxColumn";
            this.mobilePrDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobilePrDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "classe";
            this.classeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            this.classeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // annésScDataGridViewTextBoxColumn
            // 
            this.annésScDataGridViewTextBoxColumn.DataPropertyName = "AnnésSc";
            this.annésScDataGridViewTextBoxColumn.HeaderText = "AnnésSc";
            this.annésScDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.annésScDataGridViewTextBoxColumn.Name = "annésScDataGridViewTextBoxColumn";
            this.annésScDataGridViewTextBoxColumn.ReadOnly = true;
            this.annésScDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dateInSDataGridViewTextBoxColumn
            // 
            this.dateInSDataGridViewTextBoxColumn.DataPropertyName = "date_InS";
            this.dateInSDataGridViewTextBoxColumn.HeaderText = "date_InS";
            this.dateInSDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dateInSDataGridViewTextBoxColumn.Name = "dateInSDataGridViewTextBoxColumn";
            this.dateInSDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nomUtlDataGridViewTextBoxColumn
            // 
            this.nomUtlDataGridViewTextBoxColumn.DataPropertyName = "Nom_Utl";
            this.nomUtlDataGridViewTextBoxColumn.HeaderText = "Nom_Utl";
            this.nomUtlDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomUtlDataGridViewTextBoxColumn.Name = "nomUtlDataGridViewTextBoxColumn";
            this.nomUtlDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomUtlDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "etudiant";
            this.etudiantBindingSource.DataSource = this.logicielDePaiementDataSet1;
            // 
            // logicielDePaiementDataSet1
            // 
            this.logicielDePaiementDataSet1.DataSetName = "LogicielDePaiementDataSet1";
            this.logicielDePaiementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // etudiantBindingSource1
            // 
            this.etudiantBindingSource1.DataMember = "etudiant";
            this.etudiantBindingSource1.DataSource = this.logicielDePaiementDataSet2;
            // 
            // logicielDePaiementDataSet2
            // 
            this.logicielDePaiementDataSet2.DataSetName = "LogicielDePaiementDataSet2";
            this.logicielDePaiementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantTableAdapter1
            // 
            this.etudiantTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicielDePaiementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logicielDePaiementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detaileEtudianteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Zuby.ADGV.AdvancedDataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private LogicielDePaiementDataSet1 logicielDePaiementDataSet1;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private LogicielDePaiementDataSet1TableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annésScDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUtlDataGridViewTextBoxColumn;
        private LogicielDePaiementDataSet2 logicielDePaiementDataSet2;
        private System.Windows.Forms.BindingSource etudiantBindingSource1;
        private LogicielDePaiementDataSet2TableAdapters.etudiantTableAdapter etudiantTableAdapter1;
    }
}