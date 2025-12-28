using Gerador_de_Documentos_forms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Documentos_forms
{
    public partial class Formconfig : Form
    {
        public Formconfig()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Imagens (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog1.FilterIndex = 2; // muda o filtro tipo para diferentes tipos de arquivo
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DadosGlobais.CaminhoLogo = openFileDialog1.FileName;

            }
            lblCaminhoLogo.Text = DadosGlobais.CaminhoLogo;
            pbLogo.ImageLocation = DadosGlobais.CaminhoLogo;

        }

        private void config_Load(object sender, EventArgs e)
        {
            Metodos.ChecarLogo();
            lblCaminhoLogo.Text = DadosGlobais.CaminhoLogo;
            pbLogo.ImageLocation = DadosGlobais.CaminhoLogo;
            txtNomeVendedor.Text = DadosGlobais.NomeVendedor;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Metodos.CadastroInfo(lblCaminhoLogo.Text, txtNomeVendedor.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
