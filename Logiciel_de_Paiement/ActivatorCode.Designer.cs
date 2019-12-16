namespace Logiciel_de_Paiement
{
    partial class ActivatorCode
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
            this.tb_ProductID = new System.Windows.Forms.TextBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.TBExprirationDate = new System.Windows.Forms.TextBox();
            this.tbProductKey = new System.Windows.Forms.TextBox();
            this.ComboLicenceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ProductID
            // 
            this.tb_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProductID.Location = new System.Drawing.Point(131, 81);
            this.tb_ProductID.Multiline = true;
            this.tb_ProductID.Name = "tb_ProductID";
            this.tb_ProductID.Size = new System.Drawing.Size(459, 30);
            this.tb_ProductID.TabIndex = 0;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(170, 227);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(287, 46);
            this.Btn_Generate.TabIndex = 1;
            this.Btn_Generate.Text = "button1";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBExprirationDate
            // 
            this.TBExprirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBExprirationDate.Location = new System.Drawing.Point(131, 152);
            this.TBExprirationDate.Multiline = true;
            this.TBExprirationDate.Name = "TBExprirationDate";
            this.TBExprirationDate.Size = new System.Drawing.Size(459, 30);
            this.TBExprirationDate.TabIndex = 2;
            // 
            // tbProductKey
            // 
            this.tbProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductKey.Location = new System.Drawing.Point(131, 188);
            this.tbProductKey.Multiline = true;
            this.tbProductKey.Name = "tbProductKey";
            this.tbProductKey.Size = new System.Drawing.Size(459, 30);
            this.tbProductKey.TabIndex = 3;
            // 
            // ComboLicenceType
            // 
            this.ComboLicenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLicenceType.FormattingEnabled = true;
            this.ComboLicenceType.Items.AddRange(new object[] {
            "Full",
            "Trail"});
            this.ComboLicenceType.Location = new System.Drawing.Point(131, 117);
            this.ComboLicenceType.Name = "ComboLicenceType";
            this.ComboLicenceType.Size = new System.Drawing.Size(459, 28);
            this.ComboLicenceType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // ActivatorCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboLicenceType);
            this.Controls.Add(this.tbProductKey);
            this.Controls.Add(this.TBExprirationDate);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.tb_ProductID);
            this.Name = "ActivatorCode";
            this.Text = "ActivatorCode";
            this.Load += new System.EventHandler(this.ActivatorCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ProductID;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.TextBox TBExprirationDate;
        private System.Windows.Forms.TextBox tbProductKey;
        private System.Windows.Forms.ComboBox ComboLicenceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}