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
    public partial class FormGerenciamento : Form
    {
        public void ButtonLogic(bool check)
        {
            if (check)
            {
                Gclientesform form = new Gclientesform();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                GorcamentosForm form = new GorcamentosForm();
                form.ShowDialog();
                this.Close();
                
            }

        }
        public FormGerenciamento()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ButtonLogic(true);
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            ButtonLogic(false);
        }
    }
}
