using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronogramaEnem
{
    public partial class FrmStartScreen : Form
    {
        private string connectionString = @"Data Source=SQLEXPRESS;Initial Catalog=CJ3028186PR2;User Id=aluno;Password=aluno;";
        public FrmStartScreen()
        {
            InitializeComponent();
        }

        private void FrmStartScreen_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    
                }
                catch (Exception ex)
                {
                    string deEmail = "bloot.nicolas@aluno.ifsp.edu.br";
                    string senha = "mgdm xpzd eidg lyxu";
                    string paraEmail = "bloot.nicolas@aluno.ifsp.edu.br";

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(deEmail);
                    mail.To.Add(paraEmail);
                    mail.Subject = "Erro de Conexão - CronogramaEnem";
                    mail.Body = "O programa não conseguiu se conectar ao banco de dados.\n\nErro:\n" + ex.Message;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); 
                    smtp.Credentials = new NetworkCredential(deEmail, senha);
                    smtp.EnableSsl = true;
                    BtnStart.Enabled = false;
                    
                }
            }
            
        }
        

        private void BtnStart_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
        }

        private void Pbx1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

