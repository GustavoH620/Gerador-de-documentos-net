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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gerador_de_documentos_net
{
    public partial class FormBuscaOrc : Form
    {
        int ID = 0;
        List<DadosBuscaGlobal.modeloBuscaOrcamento> listaOrcamentos = new List<DadosBuscaGlobal.modeloBuscaOrcamento>();
        public async void CarregarOrcs()
        {
            foreach (var item in await DatabaseFunctionsORC.QueryOrc())
            {
                listBox1.Items.Add(item.ToString());
            }
            listaOrcamentos = await DatabaseFunctionsORC.QueryOrc();
            dataGridView1.DataSource = listaOrcamentos;


        }
        public async Task<ListBox> CarregarProdutos(DataGridViewCellEventArgs e, ListBox lb)
        {

            var listProdutos = await DatabaseFunctionsORC.QueryProdutos(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
            foreach (var item in listProdutos)
            {
                lb.Items.Add(item.ToString());
            }
            return lb;
        }
        public async void DisplayConteudo(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null || dataGridView1.Rows[e.RowIndex].Index != -1)
            {
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nomeCliente"].Value.ToString();
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                await DatabaseFunctionsORC.QueryClienteNome(txtNome.Text);
                txtCPF.Text = DadosBuscaGlobal.CPFSel;
                ID = int.Parse(txtID.Text);
                lbProdutos.Items.Clear();
                CarregarProdutos(e, lbProdutos);
                lbProdutos.Update();
            }


        }
        public async void Concluir()
        {
            if (txtCPF.Text != null)
            {

                var cliente = await DatabaseFunctionsORC.QueryCliente(txtCPF.Text);
                if (cliente != null)
                {
                    DadosBuscaGlobal.DadosClienteSel.NomeCliente = cliente.NomeCliente;
                    DadosBuscaGlobal.DadosClienteSel.Rua = cliente.Rua;
                    DadosBuscaGlobal.DadosClienteSel.Bairro = cliente.Bairro;
                    DadosBuscaGlobal.DadosClienteSel.Cidade = cliente.Cidade;
                    DadosBuscaGlobal.DadosClienteSel.Estado = cliente.Estado;
                    DadosBuscaGlobal.DadosClienteSel.Telefone = cliente.Telefone;
                    DadosBuscaGlobal.DadosClienteSel.Email = cliente.Email;
                    DadosBuscaGlobal.DadosClienteSel.CEP = cliente.CEP;
                    DadosBuscaGlobal.DadosClienteSel.CNPJ = cliente.CNPJ;
                    DadosBuscaGlobal.CPFSel = txtCPF.Text;
                    ORCform oRCform = new ORCform();
                    oRCform.Show();
                    var OrcForm = Application.OpenForms.OfType<ORCform>().FirstOrDefault();
                    OrcForm.ImportarCliente(DadosBuscaGlobal.DadosClienteSel);
                    OrcForm.ImportarOrcamento(ID);
                    this.Close();
                }
                else
                {
                    Messages.Aviso("Cliente não encontrado");
                }
            }
            

            
        }
        public FormBuscaOrc()
        {
            InitializeComponent();
        }

        private async void FormBuscaOrc_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CarregarOrcs();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex.ToString();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtBusca.Text.ToLower();
            var listaFiltrada = listaOrcamentos
                .Where(p => p.ID.ToString().Contains(textoDigitado) ||
                            p.nomeCliente.ToLower().Contains(textoDigitado))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 3)
                return;
            DisplayConteudo(e);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Concluir();
        }
    }
}
