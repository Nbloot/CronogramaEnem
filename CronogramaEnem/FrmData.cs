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
using System.Xml.Linq;

namespace CronogramaEnem
{


    public partial class FrmData : Form
    {

        public string clienteCPF { get; set; }

        public FrmData()
        {
            InitializeComponent();
        }

        private void Pbx3_Click(object sender, EventArgs e)
        {

        }

        private void CmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MtbYear_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        


        private void BtnSalvar2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=sqlexpress;Database=CJ3028186PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE DadosClientes SET Dias = @Dias , Ano = @Ano WHERE CPF = @CPF";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Adiciona os valores dos TextBox
                    cmd.Parameters.AddWithValue("@Ano", MtbYear.Text);
                    cmd.Parameters.AddWithValue("@Dias", CmbDay.Text);
                    cmd.Parameters.AddWithValue("@CPF", clienteCPF);


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
        }
    }
}
