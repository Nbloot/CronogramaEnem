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
            this.MtbYear = new System.Windows.Forms.MaskedTextBox();
            this.LblIntroduction = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.CmbDay = new System.Windows.Forms.ComboBox();
            this.BtnSalvar2 = new System.Windows.Forms.Button();
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
            // MtbYear
            // 
            this.MtbYear.Location = new System.Drawing.Point(45, 150);
            this.MtbYear.Mask = "0000";
            this.MtbYear.Name = "MtbYear";
            this.MtbYear.Size = new System.Drawing.Size(100, 20);
            this.MtbYear.TabIndex = 14;
            this.MtbYear.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbYear_MaskInputRejected);
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
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblDay.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblDay.Location = new System.Drawing.Point(45, 227);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(337, 23);
            this.LblDay.TabIndex = 16;
            this.LblDay.Text = "Quantos dias na semana você quer estudar para o enem?";
            // 
            // CmbDay
            // 
            this.CmbDay.FormattingEnabled = true;
            this.CmbDay.Items.AddRange(new object[] {
            "1 dia",
            "2 dias",
            "3 dias",
            "4 dias",
            "5 dias",
            "6 dias",
            "7 dias"});
            this.CmbDay.Location = new System.Drawing.Point(45, 275);
            this.CmbDay.Name = "CmbDay";
            this.CmbDay.Size = new System.Drawing.Size(121, 21);
            this.CmbDay.TabIndex = 18;
            this.CmbDay.SelectedIndexChanged += new System.EventHandler(this.CmbDay_SelectedIndexChanged);
            // 
            // BtnSalvar2
            // 
            this.BtnSalvar2.Location = new System.Drawing.Point(667, 396);
            this.BtnSalvar2.Name = "BtnSalvar2";
            this.BtnSalvar2.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar2.TabIndex = 19;
            this.BtnSalvar2.Text = "Salvar";
            this.BtnSalvar2.UseVisualStyleBackColor = true;
            this.BtnSalvar2.Click += new System.EventHandler(this.BtnSalvar2_Click);
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar2);
            this.Controls.Add(this.CmbDay);
            this.Controls.Add(this.LblDay);
            this.Controls.Add(this.LblIntroduction);
            this.Controls.Add(this.MtbYear);
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
        private System.Windows.Forms.MaskedTextBox MtbYear;
        private System.Windows.Forms.Label LblIntroduction;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.ComboBox CmbDay;
        private System.Windows.Forms.Button BtnSalvar2;
    }
}