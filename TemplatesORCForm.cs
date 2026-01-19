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

namespace Gerador_de_Documentos_net
{
    public partial class TemplatesORCForm : Form
    {
        public void OrcLogic(int check)
        {
            switch (check)
            {
                case 0:

                    ORCform orcT1 = new ORCform();
                    DadosGlobais.OrcTemplateSelected = 1;
                    orcT1.Show();
                    break;
                case 1:

                    ORCform orcT2 = new ORCform();
                    DadosGlobais.OrcTemplateSelected = 2;
                    orcT2.Show();
                    break;
                case 2:

                    ORCform orcT3 = new ORCform();
                    DadosGlobais.OrcTemplateSelected = 3;
                    orcT3.Show();
                    break;

            }
            this.Close();

        }

        public TemplatesORCForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrcLogic(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrcLogic(1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrcLogic(2);
        }

        private void TemplatesORCForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
