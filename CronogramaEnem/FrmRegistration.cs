using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            MessageBox.Show("Obrigado por utilizar o nosso Cronograma!",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }
    }
}
