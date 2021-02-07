using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewED_TP2.Models;

namespace NewED_TP2
{
    public partial class Form1 : Form
    {
        Contatos contatos = new Contatos(3);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtAno.Text = "";

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            Data data = new Data();
            data.setData(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text));
            contato.Nasc = data;

            contatos.adicionar(contato);

            txtEmail.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtAno.Text = "";
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Email = txtEmail.Text;

            contato = contatos.pesquisar(contato);

            if (contato.Email != "")
            {
                txtEmail.Text = contato.Email;
                txtNome.Text = contato.Nome;
                txtTelefone.Text = contato.Telefone;
                txtDia.Text = contato.Nasc.Dia.ToString();
                txtMes.Text = contato.Nasc.Mes.ToString();
                txtAno.Text = contato.Nasc.Ano.ToString();

            }
            else
            {
                MessageBox.Show("Não encontrado!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;

            bool excluiu = contatos.remover(contato);

            if (excluiu)
            {
                MessageBox.Show("Contato Excluido!");
            }
            else
            {
                MessageBox.Show("Falha na Exclusao!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbContato.Items.Clear();
            foreach (Contato c in contatos.Agenda)
            {
                if (c.Nome != "")
                {
                    lbContato.Items.Add(c.ToString());
                }
            }
        }
    }
}
