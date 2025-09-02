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
using CronogramaEnem;

namespace CronogramaEnem
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=sqlexpress;Database=CJ3028186PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Clientes (Nome, CPF, NumeroCelular, DataNascimento) VALUES (@Nome, @CPF, @Telefone, @DatadeNascimento)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Adiciona os valores dos TextBox
                    cmd.Parameters.AddWithValue("@Nome", TxbName.Text);
                    cmd.Parameters.AddWithValue("@CPF", MtbCPF.Text);
                    cmd.Parameters.AddWithValue("@Telefone", MtbNumber.Text);
                    cmd.Parameters.AddWithValue("@DatadeNascimento", MtbBirth.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente salvo com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi inserido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar cliente: " + ex.Message);
                }
            }



            FrmData frmData = new FrmData();
            frmData.ShowDialog();
        }

        


        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtbNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtbBirth_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}