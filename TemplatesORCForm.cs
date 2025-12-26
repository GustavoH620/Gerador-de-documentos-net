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
    public partial class TemplatesORCForm : Form
    {

        
        public TemplatesORCForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ORCform orcT1 = new ORCform();
            DadosGlobais.OrcTemplateSelected = 1;
            orcT1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ORCform orcT1 = new ORCform();
            DadosGlobais.OrcTemplateSelected = 2;
            orcT1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ORCform orcT1 = new ORCform();
            DadosGlobais.OrcTemplateSelected = 3;
            orcT1.Show();
            this.Hide();
        }
    }
}
