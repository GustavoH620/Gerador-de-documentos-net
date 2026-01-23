using Gerador_de_documentos_net.services;
using Gerador_de_documentos_net.Services;
using Gerador_de_Documentos_net.Models;
using Gerador_de_Documentos_net.Services;
using Gerador_de_Documentos_net;
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
    public partial class FormBuscaCliente : Form
    {
        List<Endereco> listaClientes = new List<Endereco>();
        public async void CarregarClientes()
        {

            listaClientes = await DatabaseFunctionsORC.QueryListClientes();
            dataGridView1.DataSource = listaClientes;


        }
        public void BuscaDataGrid()
        {
            string textoDigitado = txtBusca.Text.ToLower();
            var listaFiltrada = listaClientes
                .Where(p => p.CPF.ToString().Contains(textoDigitado) ||
                            p.CNPJ.ToLower().Contains(textoDigitado) ||
                            p.NomeCliente.ToLower().Contains(textoDigitado))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
        }
        public async Task Buscar(int check)
        {
            if (check == 0)
            {
                var cliente = await DatabaseFunctionsORC.QueryCliente(txtBusca.Text);
                if (cliente != null)
                {
                    groupBox1.Enabled = true;

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
        public async void DisplayConteudo(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null || dataGridView1.Rows[e.RowIndex].Index != -1)
            {
                txtNomeCliente.Text = dataGridView1.Rows[e.RowIndex].Cells["nomeCliente"].Value.ToString();
                txtRua.Text = dataGridView1.Rows[e.RowIndex].Cells["Rua"].Value.ToString();
                txtBairro.Text = dataGridView1.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
                txtCidade.Text = dataGridView1.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
                cbEstado.Text = dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                txtTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtCEP.Text = dataGridView1.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
                txtCNPJ.Text = dataGridView1.Rows[e.RowIndex].Cells["CNPJ"].Value.ToString();
                txtCPF.Text = dataGridView1.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                groupBox1.Enabled = false;

            }


        }
        public async Task Concluir()
        {
            DadosBuscaGlobal.DadosClienteSel.NomeCliente = txtNomeCliente.Text;
            DadosBuscaGlobal.DadosClienteSel.Rua = txtRua.Text;
            DadosBuscaGlobal.DadosClienteSel.Bairro = txtBairro.Text;
            DadosBuscaGlobal.DadosClienteSel.Cidade = txtCidade.Text;
            DadosBuscaGlobal.DadosClienteSel.Estado = cbEstado.Text;
            DadosBuscaGlobal.DadosClienteSel.Telefone = txtTelefone.Text;
            DadosBuscaGlobal.DadosClienteSel.Email = txtEmail.Text;
            DadosBuscaGlobal.DadosClienteSel.CEP = txtCEP.Text;
            DadosBuscaGlobal.DadosClienteSel.CNPJ = txtCNPJ.Text;
            DadosBuscaGlobal.DadosClienteSel.CPF = txtCPF.Text;
            var OrcForm = Application.OpenForms.OfType<ORCform>().FirstOrDefault();
            OrcForm.ImportarCliente(DadosBuscaGlobal.DadosClienteSel);
            this.Close();
        }
        public FormBuscaCliente()
        {
            InitializeComponent();
        }

        private void FormBusca_Load(object sender, EventArgs e)
        {
            CarregarClientes();
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
            BuscaDataGrid();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayConteudo(e);
        }
    }
}
