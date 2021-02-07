using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewED_Atendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Guiche guiche = new Guiche(0);
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.Gerar();
            rtx1.Text = "Senha gerada com sucesso.";
            
        }

        private void btnListarS_Click(object sender, EventArgs e)
        {
            rtx1.Clear();

            foreach(Senha senha in senhas.Filasenhas)
            {
                rtx1.Text += senha.DadosParciais();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.Adc(new Guiche(guiches.Listaguiches.Count + 1));
            lblGuiches.Text = Convert.ToString(guiches.Listaguiches.Count);
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int aux = 0;

            int guiche_p = int.Parse(txbGuiche.Text);

            foreach (Guiche gui in guiches.Listaguiches)
            {
                int id1 = gui.Id;

                if(guiche_p == id1)
                {
                    if (guiche.Chamar(senhas.Filasenhas) == false)
                    {
                        rtx2.Text = "Fila sem senhas.";
                    }
                    else
                    {
                        rtx2.Text = "Vez do guiche:" + Convert.ToString(gui.Id);
                    }
                }

                aux = gui.Id;
            }

            if (guiche_p > aux)
            {
                rtx2.Text = "Guiche não encontrado.";
            }

        }

        private void btnListarA_Click(object sender, EventArgs e)
        {
            rtx2.Clear();

            foreach(Senha gui in guiche.Listaatend)
            {
                if(guiche.Listaatend.Count == 0)
                {
                    rtx2.Text = "Nenhum guiche...";
                }
                else
                {
                    rtx2.Text += gui.DadosCompletos();
                }
            }
        }
    }
}
