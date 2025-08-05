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
            this.BtnCompleted = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.MtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblNumber = new System.Windows.Forms.Label();
            this.MtbNumber = new System.Windows.Forms.MaskedTextBox();
            this.LblBirth = new System.Windows.Forms.Label();
            this.MtbBirth = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnCompleted
            // 
            this.BtnCompleted.Location = new System.Drawing.Point(662, 393);
            this.BtnCompleted.Name = "BtnCompleted";
            this.BtnCompleted.Size = new System.Drawing.Size(75, 23);
            this.BtnCompleted.TabIndex = 0;
            this.BtnCompleted.Text = "Concluído";
            this.BtnCompleted.UseVisualStyleBackColor = true;
            this.BtnCompleted.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(44, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nome:";
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(47, 57);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(100, 20);
            this.TxbName.TabIndex = 2;
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(44, 104);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(30, 13);
            this.LblCPF.TabIndex = 3;
            this.LblCPF.Text = "CPF:";
            // 
            // MtbCPF
            // 
            this.MtbCPF.Location = new System.Drawing.Point(47, 120);
            this.MtbCPF.Mask = "000,000,000-00";
            this.MtbCPF.Name = "MtbCPF";
            this.MtbCPF.Size = new System.Drawing.Size(100, 20);
            this.MtbCPF.TabIndex = 4;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(44, 175);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(47, 13);
            this.LblNumber.TabIndex = 5;
            this.LblNumber.Text = "Número:";
            // 
            // MtbNumber
            // 
            this.MtbNumber.Location = new System.Drawing.Point(47, 191);
            this.MtbNumber.Mask = "(00) 00000-0000";
            this.MtbNumber.Name = "MtbNumber";
            this.MtbNumber.Size = new System.Drawing.Size(100, 20);
            this.MtbNumber.TabIndex = 6;
            // 
            // LblBirth
            // 
            this.LblBirth.AutoSize = true;
            this.LblBirth.Location = new System.Drawing.Point(44, 246);
            this.LblBirth.Name = "LblBirth";
            this.LblBirth.Size = new System.Drawing.Size(107, 13);
            this.LblBirth.TabIndex = 7;
            this.LblBirth.Text = "Data de Nascimento:";
            // 
            // MtbBirth
            // 
            this.MtbBirth.Location = new System.Drawing.Point(47, 262);
            this.MtbBirth.Mask = "00/00/0000";
            this.MtbBirth.Name = "MtbBirth";
            this.MtbBirth.Size = new System.Drawing.Size(100, 20);
            this.MtbBirth.TabIndex = 8;
            this.MtbBirth.ValidatingType = typeof(System.DateTime);
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
            this.Controls.Add(this.BtnCompleted);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompleted;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.MaskedTextBox MtbCPF;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.MaskedTextBox MtbNumber;
        private System.Windows.Forms.Label LblBirth;
        private System.Windows.Forms.MaskedTextBox MtbBirth;
    }
}