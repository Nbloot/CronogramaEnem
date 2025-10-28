namespace CronogramaEnem
{
    partial class FrmSubject
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.clbAreas = new System.Windows.Forms.CheckedListBox();
            this.clbSubAreas = new System.Windows.Forms.CheckedListBox();
            this.LblQuestion1 = new System.Windows.Forms.Label();
            this.cmbOpcaoEstudo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::CronogramaEnem.Properties.Resources.ChatGPT_Image_12_de_ago__de_2025__08_31_41;
            this.pictureBox2.Location = new System.Drawing.Point(3, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(795, 486);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LblQuestion.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblQuestion.Location = new System.Drawing.Point(101, 54);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(590, 23);
            this.LblQuestion.TabIndex = 16;
            this.LblQuestion.Text = "Agora, vamos para algumas perguntas mais pessoais para melhor funcionalidade de s" +
    "eu cronograma.";
            // 
            // clbAreas
            // 
            this.clbAreas.FormattingEnabled = true;
            this.clbAreas.Items.AddRange(new object[] {
            "Matemática",
            "Linguagens",
            "Redação",
            "Ciências Humanas",
            "Ciências da Natureza"});
            this.clbAreas.Location = new System.Drawing.Point(105, 228);
            this.clbAreas.Name = "clbAreas";
            this.clbAreas.Size = new System.Drawing.Size(151, 79);
            this.clbAreas.TabIndex = 17;
            this.clbAreas.Visible = false;
            this.clbAreas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbAreas_ItemCheck);
            this.clbAreas.SelectedIndexChanged += new System.EventHandler(this.clbAreas_SelectedIndexChanged_1);
            // 
            // clbSubAreas
            // 
            this.clbSubAreas.FormattingEnabled = true;
            this.clbSubAreas.Location = new System.Drawing.Point(289, 228);
            this.clbSubAreas.Name = "clbSubAreas";
            this.clbSubAreas.Size = new System.Drawing.Size(120, 79);
            this.clbSubAreas.TabIndex = 18;
            this.clbSubAreas.Visible = false;
            // 
            // LblQuestion1
            // 
            this.LblQuestion1.AutoSize = true;
            this.LblQuestion1.Font = new System.Drawing.Font("Reem Kufi", 9.75F);
            this.LblQuestion1.Location = new System.Drawing.Point(101, 114);
            this.LblQuestion1.Name = "LblQuestion1";
            this.LblQuestion1.Size = new System.Drawing.Size(516, 23);
            this.LblQuestion1.TabIndex = 19;
            this.LblQuestion1.Text = "Você prefere estudar todas as matérias juntas ou somente algumas matérias específ" +
    "icas?";
            // 
            // cmbOpcaoEstudo
            // 
            this.cmbOpcaoEstudo.FormattingEnabled = true;
            this.cmbOpcaoEstudo.Items.AddRange(new object[] {
            "Estudar todas as matérias",
            "Escolher matérias específicas"});
            this.cmbOpcaoEstudo.Location = new System.Drawing.Point(100, 164);
            this.cmbOpcaoEstudo.Name = "cmbOpcaoEstudo";
            this.cmbOpcaoEstudo.Size = new System.Drawing.Size(247, 21);
            this.cmbOpcaoEstudo.TabIndex = 20;
            this.cmbOpcaoEstudo.SelectedIndexChanged += new System.EventHandler(this.cmbOpcaoEstudo_SelectedIndexChanged);
            // 
            // FrmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOpcaoEstudo);
            this.Controls.Add(this.LblQuestion1);
            this.Controls.Add(this.clbSubAreas);
            this.Controls.Add(this.clbAreas);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSubject";
            this.Text = "FrmSubject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.CheckedListBox clbAreas;
        private System.Windows.Forms.CheckedListBox clbSubAreas;
        private System.Windows.Forms.Label LblQuestion1;
        private System.Windows.Forms.ComboBox cmbOpcaoEstudo;
    }
}