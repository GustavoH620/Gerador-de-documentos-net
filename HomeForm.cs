using Gerador_de_documentos_net;
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

namespace Gerador_de_Documentos_net
{
    public partial class HomeForm : Form
    {
        public void OrcLogic()
        {
            if (!MetodosInfo.ChecarInfo(false))
            {
                var config = Application.OpenForms.OfType<Formconfig>().FirstOrDefault();

                if (config != null)
                {
                    Messages.Aviso("Já há uma janela de configuração aberta!");
                    config.Focus();
                }
                else
                {
                    Formconfig Formconfig = new Formconfig();
                    Formconfig.Show();
                }




            }
            else
            {
                var OrcForm = Application.OpenForms.OfType<ORCform>().FirstOrDefault();
                var FormOpcoes = Application.OpenForms.OfType<FormOrcOpcoes>().FirstOrDefault();
                var TemplatesOrcForm = Application.OpenForms.OfType<TemplatesORCForm>().FirstOrDefault();

                if (OrcForm != null || FormOpcoes != null || TemplatesOrcForm != null)
                {

                    Messages.Aviso("Já há uma janela de criação aberta!");
                    if (OrcForm != null) OrcForm.Focus();
                    if (FormOpcoes != null) FormOpcoes.Focus();
                    if (TemplatesOrcForm != null) TemplatesOrcForm.Focus();
                }
                else
                {
                    FormOrcOpcoes form = new FormOrcOpcoes();
                    form.Show();
                }



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
            var config = Application.OpenForms.OfType<Formconfig>().FirstOrDefault();

            if (config != null)
            {
                Messages.Aviso("Já há uma janela de configuração aberta!");
                config.Focus();
            }
            else
            {
                Formconfig Formconfig = new Formconfig();
                Formconfig.Show();
            }

        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            await DatabaseFunctionsORC.InicializarBancos();
        }
    }
}
