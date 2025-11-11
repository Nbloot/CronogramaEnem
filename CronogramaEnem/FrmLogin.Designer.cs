namespace CronogramaEnem
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.BtnLogin2 = new System.Windows.Forms.Button();
            this.MtbCPF2 = new System.Windows.Forms.MaskedTextBox();
            this.BtnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CronogramaEnem.Properties.Resources.ChatGPT_Image_12_de_ago__de_2025__08_31_41;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 508);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.UseWaitCursor = true;
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.Lbl5.Location = new System.Drawing.Point(55, 71);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(105, 23);
            this.Lbl5.TabIndex = 2;
            this.Lbl5.Text = "Digite o seu CPF:";
            this.Lbl5.UseWaitCursor = true;
            this.Lbl5.Click += new System.EventHandler(this.Lbl5_Click);
            // 
            // BtnLogin2
            // 
            this.BtnLogin2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnLogin2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin2.Location = new System.Drawing.Point(682, 402);
            this.BtnLogin2.Name = "BtnLogin2";
            this.BtnLogin2.Size = new System.Drawing.Size(71, 23);
            this.BtnLogin2.TabIndex = 6;
            this.BtnLogin2.Text = "Login";
            this.BtnLogin2.UseVisualStyleBackColor = false;
            this.BtnLogin2.UseWaitCursor = true;
            this.BtnLogin2.Click += new System.EventHandler(this.BtnLogin2_Click);
            // 
            // MtbCPF2
            // 
            this.MtbCPF2.Location = new System.Drawing.Point(55, 110);
            this.MtbCPF2.Mask = "000,000,000-00";
            this.MtbCPF2.Name = "MtbCPF2";
            this.MtbCPF2.Size = new System.Drawing.Size(105, 20);
            this.MtbCPF2.TabIndex = 7;
            this.MtbCPF2.UseWaitCursor = true;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdmin.Location = new System.Drawing.Point(45, 402);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(91, 23);
            this.BtnAdmin.TabIndex = 8;
            this.BtnAdmin.Text = "Administração";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.UseWaitCursor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.MtbCPF2);
            this.Controls.Add(this.BtnLogin2);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Button BtnLogin2;
        private System.Windows.Forms.MaskedTextBox MtbCPF2;
        private System.Windows.Forms.Button BtnAdmin;
    }
}