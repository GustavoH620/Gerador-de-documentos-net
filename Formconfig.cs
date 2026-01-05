using Gerador_de_Documentos_net.Models;
using Gerador_de_Documentos_net.Services;
using Gerador_de_documentos_net.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Documentos_net
{
    public partial class Formconfig : Form
    {
        public Formconfig()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosInfo.DialogBoxInfo(openFileDialog1);
            lblCaminhoLogo.Text = DadosGlobais.CaminhoLogo;
            pbLogo.ImageLocation = DadosGlobais.CaminhoLogo;

        }

        private void config_Load(object sender, EventArgs e)
        {
            MetodosInfo.ChecarInfo();
            lblCaminhoLogo.Text = DadosGlobais.CaminhoLogo;
            pbLogo.ImageLocation = DadosGlobais.CaminhoLogo;
            txtNomeVendedor.Text = DadosGlobais.NomeVendedor;
            txtRua.Text = DadosGlobais.enderecoVendedor.Rua;
            txtBairro.Text = DadosGlobais.enderecoVendedor.Bairro;
            txtCidade.Text = DadosGlobais.enderecoVendedor.Cidade;
            cbEstado.Text = DadosGlobais.enderecoVendedor.Estado;
            txtEmail.Text = DadosGlobais.enderecoVendedor.Email;
            txtTelefone.Text = DadosGlobais.enderecoVendedor.Telefone;








        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MetodosInfo.ValidacaoGeral(txtBairro, txtCidade, txtEmail, txtNomeVendedor, txtRua, txtTelefone, cbEstado))
            {
                MetodosInfo.CadastroInfo(lblCaminhoLogo.Text, txtNomeVendedor.Text, txtRua.Text,
                txtBairro.Text, txtCidade.Text, cbEstado.Text, txtEmail.Text, txtTelefone.Text);

                Messages.Confirmacao();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
