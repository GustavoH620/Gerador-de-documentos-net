using Gerador_de_documentos_net.services;
using Gerador_de_documentos_net.Services;
using Gerador_de_Documentos_net;
using Gerador_de_Documentos_net.Services;
using System.Data;

namespace Gerador_de_documentos_net
{
    public partial class GorcamentosForm : Form
    {
        int ID = 0;
        int templateSelecionadoBusca = 0;
        string descricaoTecnica = "";
        string comentarios = "";
        string formaPagamento = "";
        List<DadosBuscaGlobal.modeloBuscaOrcamento> listaOrcamentos = new List<DadosBuscaGlobal.modeloBuscaOrcamento>();
        public async void CarregarOrcs()
        {
            foreach (var item in await DatabaseFunctionsORC.QueryOrc())
            {
                //listBox1.Items.Add(item.ToString());
            }
            listaOrcamentos = await DatabaseFunctionsORC.QueryOrc();
            dataGridView1.DataSource = listaOrcamentos;


        }
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
        public async void DeletarOrcamento()
        {
            if (MetodosValidacao.ValidacaoVazio(false, txtNome))
            {
                await DatabaseFunctionsORC.DeletarOrc(int.Parse(lblID.Text));
                CarregarOrcs();
                Limpar();
            }
            else
            {
                Messages.Aviso("Selecione um registro!");
            }

        }
        public async Task<ListBox> CarregarProdutos(DataGridViewCellEventArgs e, ListBox lb)
        {

            var listProdutos = await DatabaseFunctionsORC.QueryProdutos(int.Parse(lblID.Text) - 1);
            foreach (var item in listProdutos)
            {
                lb.Items.Add(item.ToString());
            }
            return lb;
        }
        public async void DisplayConteudo(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null || dataGridView1.Rows[e.RowIndex].Index != -1)
                {
                    groupBox1.Enabled = true;
                    txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nomeCliente"].Value.ToString();
                    lblID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    await DatabaseFunctionsORC.QueryClienteNome(txtNome.Text);
                    txtCPF.Text = DadosBuscaGlobal.CPFSel;
                    ID = int.Parse(lblID.Text);
                    formaPagamento = dataGridView1.Rows[e.RowIndex].Cells["fPagamento"].Value.ToString();
                    descricaoTecnica = dataGridView1.Rows[e.RowIndex].Cells["DescricaoT"].Value.ToString();
                    comentarios = dataGridView1.Rows[e.RowIndex].Cells["Comentarios"].Value.ToString();
                    string template = dataGridView1.Rows[e.RowIndex].Cells["Template"].Value.ToString();
                    templateSelecionadoBusca = int.Parse(template);
                    lbProdutos.Items.Clear();
                    CarregarProdutos(e, lbProdutos);
                    lbProdutos.Update();
                    groupBox1.Enabled = false;
                }
            }
            catch
            {
                Console.WriteLine("");
            }

        }
        public async void Concluir()
        {
            if (txtCPF.Text != null)
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    Messages.Aviso("Escolha um registro!");
                }
                else
                {
                    var cliente = await DatabaseFunctionsORC.QueryCliente(txtCPF.Text, txtCNPJ.Text);
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
                        OrcForm.ImportarOrcamento(ID, formaPagamento, descricaoTecnica, comentarios, templateSelecionadoBusca);
                        this.Close();
                    }
                    else
                    {
                        Messages.Aviso("Cliente não encontrado");
                    }

                }


            }



        }
        public void BuscaDataGrid()
        {
            string textoDigitado = txtBusca.Text.ToLower();
            var listaFiltrada = listaOrcamentos
                .Where(p => p.ID.ToString().Contains(textoDigitado) ||
                            p.nomeCliente.ToLower().Contains(textoDigitado))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
        }
        public GorcamentosForm()
        {
            InitializeComponent();
        }

        private void GorcamentosForm_Load(object sender, EventArgs e)
        {
            CarregarOrcs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayConteudo(e);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Concluir();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGrid();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            DeletarOrcamento();
        }
    }
}
