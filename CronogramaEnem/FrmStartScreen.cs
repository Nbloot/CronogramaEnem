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
using Microsoft.Win32.SafeHandles;

namespace CronogramaEnem
{
    public partial class FrmStartScreen : Form
    {
        string connectionString = @"Server=sqlexpress;Database=CJ3028186PR2;User Id=aluno;Password=aluno;";
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
                    MessageBox.Show("❌ Erro na conexão: " + ex.Message);
                    Application.Exit();
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