namespace CronogramaEnem
{
    partial class FrmStartScreen
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.Pbx1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnStart.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnStart.Location = new System.Drawing.Point(418, 478);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 41);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Cadastro";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Pbx1
            // 
            this.Pbx1.Image = global::CronogramaEnem.Properties.Resources.ChatGPT_Image_12_de_ago__de_2025__07_44_29;
            this.Pbx1.Location = new System.Drawing.Point(-10, -41);
            this.Pbx1.Name = "Pbx1";
            this.Pbx1.Size = new System.Drawing.Size(1080, 727);
            this.Pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx1.TabIndex = 1;
            this.Pbx1.TabStop = false;
            this.Pbx1.Click += new System.EventHandler(this.Pbx1_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnLogin.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLogin.Location = new System.Drawing.Point(558, 478);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 41);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 631);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Pbx1);
            this.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStartScreen";
            this.Text = "FrmStartScreen";
            this.Load += new System.EventHandler(this.FrmStartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox Pbx1;
        private System.Windows.Forms.Button BtnLogin;
    }
}