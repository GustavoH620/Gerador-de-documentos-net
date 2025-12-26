using Gerador_de_Documentos_forms.Models.Orcamentos;
using Gerador_de_Documentos_forms.Services;
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
using Microsoft.Data.Sqlite;


namespace Gerador_de_Documentos_forms
{
    public partial class ORCform : Form
    {
        List<ItemProduto> ListaItens = new List<ItemProduto>();

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
            if (!int.TryParse(txtValor.Text, out int valor) || valor < 0)
            {
                MessageBox.Show("Valor de produto inválido"); return;
            }
            ItemProduto novoItem = new ItemProduto()
            {
                NomeProduto = txtProduto.Text,
                Valor = valor,
                QTD = quantidade,
            };

            ListaItens.Add(novoItem);

            AtualizarTela();


          
        }

        void AtualizarTela()
        {
            listBoxProdutos.Items.Clear();
            foreach (var item in ListaItens)
            {
                listBoxProdutos.Items.Add(item.ToString());
            }
            decimal totalGeral = ListaItens.Sum(x => x.ValorTotal);
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
            
            lblData.Text = $"Data: {DateTime.Now.ToString("dd/MM/yyyy")}";
            lblIDorc.Text = $"ID: {await DatabaseFunctions.DatabaseOrcID()}";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarList();

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            ListaItens.Clear();
            listBoxProdutos.Items.Clear();
            listBoxProdutos.Update();
            lblValorT.Text = "Valor Total:";
        }
    }
}
