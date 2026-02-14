using Gerador_de_documentos_net.services;
using Gerador_de_documentos_net.Services;
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

    public partial class FormOrcOpcoes : Form
    {
        public void OrcLogic(bool check)
        {
            if (check)
            {
                TemplatesORCForm formTemplates = new TemplatesORCForm();
                formTemplates.ShowDialog();
                this.Close();
            }
            else
            {
                DadosBuscaGlobal.BuscaOrcamento();
                this.Close();
            }
        }
        public FormOrcOpcoes()
        {
            InitializeComponent();
        }

        private void btnNovoOrc_Click(object sender, EventArgs e)
        {
            OrcLogic(true);
        }

        private void FormOrcOpcoes_Load(object sender, EventArgs e)
        {
            DadosGlobais.LimparListaProdutos();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OrcLogic(false);
        }
    }
}
