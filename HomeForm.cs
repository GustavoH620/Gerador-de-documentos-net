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
        public HomeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrc_Click(object sender, EventArgs e)
        {
            if (MetodosInfo.ChecarInfo()) 
            {
                Formconfig config = new Formconfig();
                config.Show();
            }
            else
            {
                TemplatesORCForm form = new TemplatesORCForm();
                form.Show();
                this.Hide();

            }

                
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Formconfig formconfig = new Formconfig();
            formconfig.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
