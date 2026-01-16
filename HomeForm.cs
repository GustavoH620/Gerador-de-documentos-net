using Gerador_de_documentos_net;
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

namespace Gerador_de_Documentos_net
{
    public partial class HomeForm : Form
    {
        public void OrcLogic()
        {
            if (!MetodosInfo.ChecarInfo(false))
            {
                Formconfig config = new Formconfig();
                config.Show();

            }
            else
            {
                FormOrcOpcoes form = new FormOrcOpcoes();
                form.Show();


            }

        }
        public HomeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrc_Click(object sender, EventArgs e)
        {
            OrcLogic();

                
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Formconfig formconfig = new Formconfig();
            formconfig.Show();
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            await DatabaseFunctionsORC.InicializarBancos();
        }
    }
}
