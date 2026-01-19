using Gerador_de_documentos_net.services;
using Gerador_de_Documentos_net;
using Gerador_de_Documentos_net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_documentos_net
{
    public partial class FormBusca : Form
    {
        public async Task Buscar(int check)
        {
            if (check == 0)
            {
                var cliente = await DatabaseFunctionsORC.QueryCliente(txtBusca.Text);
                if (cliente != null)
                {
                    groupBox1.Enabled = true;
                    DadosBuscaGlobal.DadosClienteSel.NomeCliente = cliente.NomeCliente;
                    DadosBuscaGlobal.DadosClienteSel.Rua = cliente.Rua;
                    DadosBuscaGlobal.DadosClienteSel.Bairro = cliente.Bairro;
                    DadosBuscaGlobal.DadosClienteSel.Cidade = cliente.Cidade;
                    DadosBuscaGlobal.DadosClienteSel.Estado = cliente.Estado;
                    DadosBuscaGlobal.DadosClienteSel.Telefone = cliente.Telefone;
                    DadosBuscaGlobal.DadosClienteSel.Email = cliente.Email;
                    DadosBuscaGlobal.DadosClienteSel.CEP = cliente.CEP;
                    DadosBuscaGlobal.DadosClienteSel.CNPJ = cliente.CNPJ;
                    txtNomeCliente.Text = cliente.NomeCliente;
                    txtRua.Text = cliente.Rua;
                    txtBairro.Text = cliente.Bairro;
                    txtCidade.Text = cliente.Cidade;
                    cbEstado.Text = cliente.Estado;
                    txtTelefone.Text = cliente.Telefone;
                    txtEmail.Text = cliente.Email;
                    txtCEP.Text = cliente.CEP;
                    txtCNPJ.Text = cliente.CNPJ;
                    txtCPF.Text = DadosBuscaGlobal.CPFSel;
                    groupBox1.Enabled = false;



                }
                else
                {
                    Messages.Aviso("Cliente não encontrado");
                }

            }
        }
        public async Task Concluir()
        {
            var OrcForm = Application.OpenForms.OfType<ORCform>().FirstOrDefault();
            OrcForm.ImportarCliente(DadosBuscaGlobal.DadosClienteSel);
            this.Close();
        }
        public FormBusca()
        {
            InitializeComponent();
        }

        private void FormBusca_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnBuscar.Focus();
            lblTopico.Text = DadosBuscaGlobal.TopicoBusca;
            if (DadosBuscaGlobal.checkBusca == 0)
            {
                groupBox1.Visible = true;
                groupBox1.Enabled = false;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(DadosBuscaGlobal.checkBusca);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            Concluir();
        }
    }
}
