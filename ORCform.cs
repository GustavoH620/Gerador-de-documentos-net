using Gerador_de_Documentos_forms.Models;
using Gerador_de_Documentos_forms.Models.Orcamentos;
using Gerador_de_Documentos_forms.Services;
using Microsoft.Data.Sqlite;
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



namespace Gerador_de_Documentos_forms
{

    public partial class ORCform : Form
    {

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

        void AtualizarTela()
        {
            listBoxProdutos.Items.Clear();
            foreach (var item in DadosGlobais.ListaItens)
            {
                listBoxProdutos.Items.Add(item.ToString());
            }
            decimal totalGeral = DadosGlobais.ListaItens.Sum(x => x.ValorTotal);
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

        private async void ORCform_Load(object sender, EventArgs e)
        {
            DataExp();
            lblData.Text = $"Data: {DateTime.Now.ToString("dd/MM/yyyy")}";
            lblIDorc.Text = $"ID: {await DatabaseFunctions.DatabaseOrcID()}";
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
            QuestPDF.Settings.License = LicenseType.Community;
            var model = questPDFOrcDataSource.PegarDadosOrc(
                nomeCliente: txtNomeCliente.Text,
                CPF: txtCPF.Text,
                ValorT: DadosGlobais.ListaItens.Sum(x => x.ValorTotal),
                ID: int.Parse(lblIDorc.Text.Replace("ID: ", "")),
                ListaProdutos: DadosGlobais.ListaItens,
                Comentarios: rtbComentarios.Text,
                Rua: txtRua.Text,
                Bairro: txtBairro.Text,
                Cidade: txtCidade.Text,
                Estado: cbEstado.Text,
                Email: txtEmail.Text,
                Telefone: txtTelefone.Text,
                dataExp: dataExp
            );

            switch (DadosGlobais.OrcTemplateSelected)
            {
                case 1:
                    var documento = new OrcamentoT1(model);
                    documento.GeneratePdfAndShow();
                    break;



            }



        }

        private void ckbDataExp_CheckedChanged(object sender, EventArgs e)
        {
            DataExp();
        }

        private void dtpDataExp_ValueChanged(object sender, EventArgs e)
        {
            dataExp = dtpDataExp.Value.Date;
        }
    }
}
