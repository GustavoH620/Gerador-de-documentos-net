using Gerador_de_documentos_net.models.Orcamentos;
using Gerador_de_documentos_net.services;
using Gerador_de_documentos_net.Services;
using Gerador_de_Documentos_net.Models;
using Gerador_de_Documentos_net.Models.Orcamentos;
using Gerador_de_Documentos_net.Services;
using Microsoft.Data.Sqlite;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using SQLitePCL;
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

    public partial class ORCform : Form
    {
        public async void SalvarOrc()
        {
            if (MetodosValidacao.ValidacaoVazio(txtNomeCliente))
            {
                await DatabaseFunctionsORC.DataBaseOrcCadastro(txtNomeCliente.Text, $"{totalGeral}", DadosGlobais.ListaItens, id, cbFormaPagamento.Text, DadosGlobais.OrcTemplateSelected, rtbDescTecnica.Text, rtbComentarios.Text);
                lblUorcamento.Text = $"Último orçamento salvo: {await DatabaseFunctionsORC.DatabaseOrcID()}";
                id = await DatabaseFunctionsORC.DatabaseOrcID();
                Messages.Confirmacao($"Orçamento salvo com ID: {id}");
            }



        }
        public void ImportarCliente(Endereco cliente)
        {
            txtNomeCliente.Text = cliente.NomeCliente;
            txtNomeCliente.Text = cliente.NomeCliente;
            txtRua.Text = cliente.Rua;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            cbEstado.Text = cliente.Estado;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtCEP.Text = cliente.CEP;
            txtCNPJ.Text = cliente.CNPJ;
            txtCPF.Text = cliente.CPF;

        }
        public async Task ImportarOrcamento(int ID, string formaPagamento, string descricaoT, string comentarios, int template)
        {
            DadosGlobais.ListaItens = await DatabaseFunctionsORC.QueryProdutos(ID);
            cbFormaPagamento.Text = formaPagamento;
            rtbDescTecnica.Text = descricaoT;
            rtbComentarios.Text = comentarios;
            DadosGlobais.OrcTemplateSelected = template;
            AtualizarTela();
        }

        public void GerarPDFOrcamento()
        {
            decimal ValorFrete = 0;
            decimal.TryParse(txtValorFrete.Text, out ValorFrete);
            decimal ValorImposto = 0;
            decimal.TryParse(txtValorImposto.Text, out ValorImposto);
            QuestPDF.Settings.License = LicenseType.Community;
            var model = questPDFOrcDataSource.PegarDadosOrc(
                nomeCliente: txtNomeCliente.Text,
                CPF: txtCPF.Text,
                CEP: txtCEP.Text,
                CNPJ: txtCNPJ.Text,
                ValorT: DadosGlobais.ListaItens.Sum(x => x.ValorTotal),
                ID: 0,
                ListaProdutos: DadosGlobais.ListaItens,
                Comentarios: rtbComentarios.Text,
                DescricaoTecnica: rtbDescTecnica.Text,
                Rua: txtRua.Text,
                Bairro: txtBairro.Text,
                Cidade: txtCidade.Text,
                Estado: cbEstado.Text,
                Email: txtEmail.Text,
                Telefone: txtTelefone.Text,
                dataExp: dataExp,
                FormaPagamento: cbFormaPagamento.Text,
                PrazoEntrega: dtpPrazo.Value,
                Frete: ValorFrete,
                ImpostoIncluso: cbImpostoIncluso.Checked,
                ValorImposto: ValorImposto,
                Parcelas: Parcelas
            );
            IDocument documento;
            switch (DadosGlobais.OrcTemplateSelected)
            {
                case 1:
                    documento = new OrcamentoT1(model);
                    documento.GeneratePdfAndShow();
                    break;
                case 2:
                    documento = new OrcamentoT2(model);
                    documento.GeneratePdfAndShow();
                    break;
                case 3:
                    documento = new OrcamentoT3(model);
                    documento.GeneratePdfAndShow();
                    break;




            }
        }

        DateTime dataExp = DateTime.Now.AddDays(30);
        public void DataExp()
        {
            if (ckbDataExp.Checked)
            {
                dtpDataExp.Enabled = true;
                dataExp = dtpDataExp.Value.Date;

            }
            else
            {
                dtpDataExp.Enabled = false;
                dataExp = DateTime.Now.AddDays(30);
            }
        }
        decimal ValorImposto = 0;
        public void ImpostoIncluso()
        {
            if (cbImpostoIncluso.Checked)
            {
                txtValorImposto.Enabled = false;
                txtValorImposto.Text = "0";

            }
            else
            {

                txtValorImposto.Enabled = true;


            }
        }
        int Parcelas = 1;
        public void MecanismoParcelas(bool controle)
        {
            if (!controle)
            {
                if (Parcelas > 1)
                {
                    Parcelas--;
                    lblParcelas.Text = $"{Parcelas}X";
                }
            }
            else
            {
                if (Parcelas < 21)
                {
                    Parcelas++;
                    lblParcelas.Text = $"{Parcelas}X";
                }
            }
        }
        public void AdicionarList()
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text) ||
                string.IsNullOrWhiteSpace(txtQTD.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos do produto.");
                return;
            }
            if (!int.TryParse(txtQTD.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida"); return;
            }
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor < 0)
            {
                MessageBox.Show("Valor de produto inválido"); return;
            }
            ItemProduto novoItem = new ItemProduto()
            {
                NomeProduto = txtProduto.Text,
                Valor = valor,
                QTD = quantidade,
            };

            DadosGlobais.ListaItens.Add(novoItem);

            AtualizarTela();



        }

        decimal totalGeral = 0;
        void AtualizarTela()
        {
            listBoxProdutos.Items.Clear();
            foreach (var item in DadosGlobais.ListaItens)
            {
                listBoxProdutos.Items.Add(item.ToString());
            }
            totalGeral = DadosGlobais.ListaItens.Sum(x => x.ValorTotal);
            lblValorT.Text = $"Valor total: R${totalGeral.ToString("C2")}";

            txtProduto.Clear();
            txtValor.Clear();
            txtQTD.Clear();
            txtProduto.Focus();


        }
        public ORCform()
        {
            InitializeComponent();
        }
        int id = 0;
        private async void ORCform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataExp();
            ImpostoIncluso();
            lblData.Text = $"Data: {DateTime.Now.ToString("dd/MM/yyyy")}";
            id = await DatabaseFunctionsORC.DatabaseOrcID();
            lblIDorc.Text = $"ID: (novo)";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarList();

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            DadosGlobais.ListaItens.Clear();
            listBoxProdutos.Items.Clear();
            listBoxProdutos.Update();
            lblValorT.Text = "Valor Total:";
        }

        private void btnGerarOrc_Click(object sender, EventArgs e)
        {
            GerarPDFOrcamento();

        }

        private void ckbDataExp_CheckedChanged(object sender, EventArgs e)
        {
            DataExp();
        }

        private void dtpDataExp_ValueChanged(object sender, EventArgs e)
        {
            dataExp = dtpDataExp.Value.Date;
        }

        private void cbImpostoIncluso_CheckedChanged(object sender, EventArgs e)
        {
            ImpostoIncluso();
        }

        private void btnADDParcela_Click(object sender, EventArgs e)
        {
            MecanismoParcelas(true);
        }

        private void btnSUBParcelas_Click(object sender, EventArgs e)
        {
            MecanismoParcelas(false);
        }

        private async void btnSalvarOrc_Click(object sender, EventArgs e)
        {
            SalvarOrc();

        }

        private async void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            await DatabaseFunctionsORC.CadastroCliente(txtCPF.Text, txtNomeCliente.Text, txtRua.Text, txtBairro.Text, txtCidade.Text, cbEstado.Text, txtTelefone.Text, txtEmail.Text, txtCNPJ.Text, txtCEP.Text);
        }

        private void btnImportarCliente_Click(object sender, EventArgs e)
        {
            DadosBuscaGlobal.BuscaCliente();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            //MetodosValidacao.ValidacaoNumeros(txtCPF);
        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
            //MetodosValidacao.ValidacaoNumeros(txtCNPJ);
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            //MetodosValidacao.ValidacaoNumeros(txtCEP);
        }
    }
}
