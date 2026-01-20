using Gerador_de_documentos_net.services;
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
    public partial class FormBuscaOrc : Form
    {
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
    }
}
