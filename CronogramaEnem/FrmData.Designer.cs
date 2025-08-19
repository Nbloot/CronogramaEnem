namespace CronogramaEnem
{
    partial class FrmData
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
            this.Pbx3 = new System.Windows.Forms.PictureBox();
            this.LblYear = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.LblIntroduction = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx3)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbx3
            // 
            this.Pbx3.BackColor = System.Drawing.Color.Transparent;
            this.Pbx3.Image = global::CronogramaEnem.Properties.Resources.ChatGPT_Image_12_de_ago__de_2025__08_31_41;
            this.Pbx3.Location = new System.Drawing.Point(3, -18);
            this.Pbx3.Name = "Pbx3";
            this.Pbx3.Size = new System.Drawing.Size(795, 486);
            this.Pbx3.TabIndex = 12;
            this.Pbx3.TabStop = false;
            this.Pbx3.Click += new System.EventHandler(this.Pbx3_Click);
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblYear.Location = new System.Drawing.Point(41, 110);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(255, 23);
            this.LblYear.TabIndex = 13;
            this.LblYear.Text = "Para qual ano do Enem você quer estudar?";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(45, 150);
            this.maskedTextBox1.Mask = "0 0 0 0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // LblIntroduction
            // 
            this.LblIntroduction.AutoSize = true;
            this.LblIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.LblIntroduction.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblIntroduction.Location = new System.Drawing.Point(106, 27);
            this.LblIntroduction.Name = "LblIntroduction";
            this.LblIntroduction.Size = new System.Drawing.Size(556, 23);
            this.LblIntroduction.TabIndex = 15;
            this.LblIntroduction.Text = "Para criarmos sua rotina, precisamos de algumas informações sobre sua disponibili" +
    "dade e datas.";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblDate.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblDate.Location = new System.Drawing.Point(45, 227);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(337, 23);
            this.LblDate.TabIndex = 16;
            this.LblDate.Text = "Quantos dias na semana você quer estudar para o enem?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 dia",
            "2 dias",
            "3 dias",
            "4 dias",
            "5 dias",
            "6 dias",
            "7 dias"});
            this.comboBox1.Location = new System.Drawing.Point(45, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblIntroduction);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.Pbx3);
            this.Name = "FrmData";
            this.Text = "FrmData";
            ((System.ComponentModel.ISupportInitialize)(this.Pbx3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx3;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label LblIntroduction;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}