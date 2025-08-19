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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace CronogramaEnem
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=SQLEXPRESS;Initial Catalog=CJ3028186PR2;User Id=aluno;Password=aluno;";


        private void BtnTest_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("✅ Conexão com o banco CJ3028186PR2 realizada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Erro na conexão: " + ex.Message);
                }
            }
        }
    }
}