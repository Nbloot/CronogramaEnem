namespace CronogramaEnem
{
    partial class FrmRegistration
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.MtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblNumber = new System.Windows.Forms.Label();
            this.MtbNumber = new System.Windows.Forms.MaskedTextBox();
            this.LblBirth = new System.Windows.Forms.Label();
            this.MtbBirth = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(662, 393);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblName.Location = new System.Drawing.Point(47, 31);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 23);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nome:";
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(47, 57);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(100, 20);
            this.TxbName.TabIndex = 2;
            this.TxbName.TextChanged += new System.EventHandler(this.TxbName_TextChanged);
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblCPF.Location = new System.Drawing.Point(47, 121);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(37, 23);
            this.LblCPF.TabIndex = 3;
            this.LblCPF.Text = "CPF:";
            // 
            // MtbCPF
            // 
            this.MtbCPF.Location = new System.Drawing.Point(47, 147);
            this.MtbCPF.Mask = "000,000,000-00";
            this.MtbCPF.Name = "MtbCPF";
            this.MtbCPF.Size = new System.Drawing.Size(100, 20);
            this.MtbCPF.TabIndex = 4;
            this.MtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbCPF_MaskInputRejected);
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblNumber.Location = new System.Drawing.Point(47, 222);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(60, 23);
            this.LblNumber.TabIndex = 5;
            this.LblNumber.Text = "Número:";
            // 
            // MtbNumber
            // 
            this.MtbNumber.Location = new System.Drawing.Point(47, 248);
            this.MtbNumber.Mask = "(00) 00000-0000";
            this.MtbNumber.Name = "MtbNumber";
            this.MtbNumber.Size = new System.Drawing.Size(100, 20);
            this.MtbNumber.TabIndex = 6;
            this.MtbNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbNumber_MaskInputRejected);
            // 
            // LblBirth
            // 
            this.LblBirth.AutoSize = true;
            this.LblBirth.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblBirth.Location = new System.Drawing.Point(47, 326);
            this.LblBirth.Name = "LblBirth";
            this.LblBirth.Size = new System.Drawing.Size(132, 23);
            this.LblBirth.TabIndex = 7;
            this.LblBirth.Text = "Data de Nascimento:";
            // 
            // MtbBirth
            // 
            this.MtbBirth.Location = new System.Drawing.Point(47, 352);
            this.MtbBirth.Mask = "00/00/0000";
            this.MtbBirth.Name = "MtbBirth";
            this.MtbBirth.Size = new System.Drawing.Size(100, 20);
            this.MtbBirth.TabIndex = 8;
            this.MtbBirth.ValidatingType = typeof(System.DateTime);
            this.MtbBirth.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbBirth_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CronogramaEnem.Properties.Resources.ChatGPT_Image_12_de_ago__de_2025__08_31_41;
            this.pictureBox1.Location = new System.Drawing.Point(2, -33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 486);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MtbBirth);
            this.Controls.Add(this.LblBirth);
            this.Controls.Add(this.MtbNumber);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.MtbCPF);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.MaskedTextBox MtbCPF;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.MaskedTextBox MtbNumber;
        private System.Windows.Forms.Label LblBirth;
        private System.Windows.Forms.MaskedTextBox MtbBirth;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}