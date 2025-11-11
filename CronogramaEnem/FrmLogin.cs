using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronogramaEnem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl5_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin2_Click(object sender, EventArgs e)
        {
            
            string cpf = MtbCPF2.Text;  // Usa o formato com pontos e traço
            string connectionString = @"Server=sqlexpress;Database=CJ3028186PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM DadosClientes WHERE CPF = @cpf";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    int total = (int)cmd.ExecuteScalar();

                    if (total > 0)
                    {
                        MessageBox.Show("Bem-vindo de volta!");
                        // Aqui você pode carregar o calendário ou abrir outra tela
                    }
                    else
                    {
                        MessageBox.Show("CPF não cadastrado!");
                        // Aqui você pode redirecionar para criação de novo cadastro
                    }
                }
            }
        }
    }
    
}
