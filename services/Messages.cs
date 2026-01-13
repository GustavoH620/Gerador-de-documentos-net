using Gerador_de_Documentos_net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_documentos_net.services
{
    public static class Messages
    {
        public static bool AdicionarLogo()
        {
            string mensagem = "Deseja adicionar uma logo?";
            string legenda = "Nehuma logo encontrada.";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensagem, legenda, botoes);
            if (resultado == DialogResult.Yes)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public static void Confirmacao()
        {
            MessageBox.Show("Concluído", "Informação", MessageBoxButtons.OK);
            
        }
    }
}
