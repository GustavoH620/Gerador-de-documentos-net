using Gerador_de_documentos_net.services;
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
        public FormBusca()
        {
            InitializeComponent();
        }

        private void FormBusca_Load(object sender, EventArgs e)
        {
            lblTopico.Text = DadosBuscaGlobal.TopicoBusca;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
