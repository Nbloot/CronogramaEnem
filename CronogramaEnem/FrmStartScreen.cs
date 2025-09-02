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
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=clientes;User Id=aluno;Password=aluno;";
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
                    string query = "SELECT * FROM clientes";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader["Nome"].ToString();
                            MessageBox.Show("Cliente: " + nome);
                        }
                    }

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