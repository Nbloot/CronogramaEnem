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
    public partial class FrmSubject : Form
    {
        public FrmSubject()
        {
            InitializeComponent();
        }

        private void LblIntroduction_Click(object sender, EventArgs e)
        {

        }

        private void clbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbAreas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string areaSelecionada = clbAreas.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                clbSubAreas.Items.Clear();
                clbSubAreas.Visible = true;

                if (areaSelecionada == "Matemática")
                {
                    clbSubAreas.Items.Add("Matemática");
                }
                else if (areaSelecionada == "Linguagens")
                {
                    clbSubAreas.Items.Add("Língua Portuguesa");
                    clbSubAreas.Items.Add("Literatura");
                    clbSubAreas.Items.Add("Inglês ou Espanhol");
                    clbSubAreas.Items.Add("Artes");
                    clbSubAreas.Items.Add("Educação Física");
                    clbSubAreas.Items.Add("Tecnologias da Informação e Comunicação");
                }
                else if (areaSelecionada == "Redação")
                {
                    clbSubAreas.Items.Add("Texto Dissertativo-Argumentativo");
                }
                else if (areaSelecionada == "Ciências Humanas")
                {
                    clbSubAreas.Items.Add("História");
                    clbSubAreas.Items.Add("Geografia");
                    clbSubAreas.Items.Add("Filosofia");
                    clbSubAreas.Items.Add("Sociologia");
                }
                else if (areaSelecionada == "Ciências da Natureza")
                {
                    clbSubAreas.Items.Add("Física");
                    clbSubAreas.Items.Add("Química");
                    clbSubAreas.Items.Add("Biologia");
                }
            }
            else
            {
                clbSubAreas.Visible = false;
                clbSubAreas.Items.Clear();
            }
        }

        private void clbAreas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOpcaoEstudo_SelectedIndexChanged(object sender, EventArgs e)
        
        { 

            string opcaoSelecionada = cmbOpcaoEstudo.SelectedItem.ToString();

            if (opcaoSelecionada == "Escolher matérias específicas")
            {
                clbAreas.Visible = true;
                clbSubAreas.Visible = false;
            }
            else
            {
                clbAreas.Visible = false;
                clbSubAreas.Visible = false;

                // Limpa seleções, caso o usuário volte atrás
                for (int i = 0; i < clbAreas.Items.Count; i++)
                {
                    clbAreas.SetItemChecked(i, false);
                }
                clbSubAreas.Items.Clear();
            }
        }

    }
}

