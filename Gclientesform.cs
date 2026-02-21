using Gerador_de_documentos_net.services;
using Gerador_de_documentos_net.Services;
using Gerador_de_Documentos_net.Models;
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
    public partial class Gclientesform : Form
    {
        public void Limpar()
        {
            foreach (Control controle in groupBox1.Controls)
            {
                if (controle is TextBox || controle is ComboBox)
                {
                    controle.Text = "";
                    controle.Enabled = true;
                }
                lblID.Text = "";

            }
        }
        public async void CadastrarCliente()
        {
            if (MetodosValidacao.ValidacaoVazio(false, txtNomeCliente))
            {
                await DatabaseFunctionsORC.CadastroCliente(txtCPF.Text, txtNomeCliente.Text, txtRua.Text, txtBairro.Text, txtCidade.Text, cbEstado.Text, txtTelefone.Text, txtEmail.Text, txtCNPJ.Text, txtCEP.Text);
                CarregarClientes();
            }
            else
            {
                Messages.Aviso("Nome do cliente está vazio!");
            }

        }
        public async void UpdateCliente()
        {
            if (MetodosValidacao.ValidacaoVazio(false, txtNomeCliente))
            {
                await DatabaseFunctionsORC.UpdateCliente(txtCPF.Text, txtNomeCliente.Text, txtRua.Text, txtBairro.Text, txtCidade.Text, cbEstado.Text, txtTelefone.Text, txtEmail.Text, txtCNPJ.Text, txtCEP.Text, int.Parse(lblID.Text));
                CarregarClientes();
            }
            else
            {
                Messages.Aviso("Selecione um registro!");
            }

        }
        public async void DeletarCLiente()
        {
            if (MetodosValidacao.ValidacaoVazio(false, txtNomeCliente))
            {
                await DatabaseFunctionsORC.DeletarCliente(int.Parse(lblID.Text));
                CarregarClientes();
                Limpar();
            }
            else
            {
                Messages.Aviso("Selecione um registro!");
            }

        }

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
        public async void DisplayConteudo(DataGridViewCellEventArgs e)
        {
            try
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
                    lblID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    txtCPF.Enabled = false;
                    txtCNPJ.Enabled = false;


                }
            }
            catch
            {
                Messages.Aviso("");

            }


        }
        public Gclientesform()
        {
            InitializeComponent();
        }

        private void Gclientesform_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            this.WindowState = FormWindowState.Maximized;



        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayConteudo(e);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            CadastrarCliente();
        }

        private void btnUPD_Click(object sender, EventArgs e)
        {
            UpdateCliente();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            DeletarCLiente();
            
        }
    }
}
