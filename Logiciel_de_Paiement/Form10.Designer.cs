namespace Logiciel_de_Paiement
{
    partial class Form10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_compte = new System.Windows.Forms.Button();
            this.textBox_mp_utl = new System.Windows.Forms.TextBox();
            this.textBox_Nom_utl = new System.Windows.Forms.TextBox();
            this.textBox_mp_adm = new System.Windows.Forms.TextBox();
            this.textBox_Nom_adm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_compte);
            this.groupBox1.Controls.Add(this.textBox_mp_utl);
            this.groupBox1.Controls.Add(this.textBox_Nom_utl);
            this.groupBox1.Controls.Add(this.textBox_mp_adm);
            this.groupBox1.Controls.Add(this.textBox_Nom_adm);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 307);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_compte
            // 
            this.btn_compte.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compte.Location = new System.Drawing.Point(20, 220);
            this.btn_compte.Name = "btn_compte";
            this.btn_compte.Size = new System.Drawing.Size(287, 63);
            this.btn_compte.TabIndex = 11;
            this.btn_compte.Text = "Ajouter";
            this.btn_compte.UseVisualStyleBackColor = true;
            // 
            // textBox_mp_utl
            // 
            this.textBox_mp_utl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mp_utl.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_mp_utl.Location = new System.Drawing.Point(20, 159);
            this.textBox_mp_utl.Name = "textBox_mp_utl";
            this.textBox_mp_utl.Size = new System.Drawing.Size(287, 31);
            this.textBox_mp_utl.TabIndex = 10;
            this.textBox_mp_utl.Text = " Mot de passe";
            this.textBox_mp_utl.Enter += new System.EventHandler(this.textBox_mp_utl_Enter);
            this.textBox_mp_utl.Leave += new System.EventHandler(this.textBox_mp_utl_Leave);
            // 
            // textBox_Nom_utl
            // 
            this.textBox_Nom_utl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nom_utl.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_Nom_utl.Location = new System.Drawing.Point(20, 120);
            this.textBox_Nom_utl.Name = "textBox_Nom_utl";
            this.textBox_Nom_utl.Size = new System.Drawing.Size(287, 31);
            this.textBox_Nom_utl.TabIndex = 9;
            this.textBox_Nom_utl.Text = " Nom Utilisateur";
            this.textBox_Nom_utl.Enter += new System.EventHandler(this.textBox_Nom_utl_Enter);
            this.textBox_Nom_utl.Leave += new System.EventHandler(this.textBox_Nom_utl_Leave);
            // 
            // textBox_mp_adm
            // 
            this.textBox_mp_adm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mp_adm.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_mp_adm.Location = new System.Drawing.Point(20, 67);
            this.textBox_mp_adm.Name = "textBox_mp_adm";
            this.textBox_mp_adm.Size = new System.Drawing.Size(287, 31);
            this.textBox_mp_adm.TabIndex = 8;
            this.textBox_mp_adm.Text = " Mot de passe";
            this.textBox_mp_adm.Enter += new System.EventHandler(this.textBox_mp_adm_Enter);
            this.textBox_mp_adm.Leave += new System.EventHandler(this.textBox_mp_adm_Leave);
            // 
            // textBox_Nom_adm
            // 
            this.textBox_Nom_adm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nom_adm.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_Nom_adm.Location = new System.Drawing.Point(20, 29);
            this.textBox_Nom_adm.Name = "textBox_Nom_adm";
            this.textBox_Nom_adm.Size = new System.Drawing.Size(287, 31);
            this.textBox_Nom_adm.TabIndex = 7;
            this.textBox_Nom_adm.Text = " Nom Administrateur";
            this.textBox_Nom_adm.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox_Nom_adm.Leave += new System.EventHandler(this.textBox_Nom_adm_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Créer un Compte";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(360, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_compte;
        private System.Windows.Forms.TextBox textBox_mp_utl;
        private System.Windows.Forms.TextBox textBox_Nom_utl;
        private System.Windows.Forms.TextBox textBox_mp_adm;
        private System.Windows.Forms.TextBox textBox_Nom_adm;
        private System.Windows.Forms.Label label1;
    }
}