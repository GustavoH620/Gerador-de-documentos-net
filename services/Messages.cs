namespace Gerador_de_documentos_net.services
{
    public static class Messages
    {
        public static bool AdicionarLogo()
        {
            string mensagem = "Deseja adicionar uma logo?";
            string legenda = "Nenhuma logo encontrada.";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult resultado;

            resultado = MessageBox.Show(mensagem, legenda, botoes, icon);
            if (resultado == DialogResult.Yes)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public static bool Questao(string mensagem)
        {
            DialogResult resultado;
            resultado = MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Confirmacao(string mensagem)
        {
            MessageBox.Show(mensagem, "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void Aviso(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
