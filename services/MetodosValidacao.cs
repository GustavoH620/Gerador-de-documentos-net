namespace Gerador_de_documentos_net.services
{
    internal class MetodosValidacao
    {
        public static bool ValidacaoVazio(bool Nada, params Control[] controles)
        {
            foreach (Control control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    control.BackColor = Color.Pink;
                    if (Nada)
                    {
                        MessageBox.Show("Preencha os campos vazios.");
                    }

                    return false;


                }
                else
                {
                    control.BackColor = Color.White;
                }

            }
            return true;

        }

        public static void Limpeza(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.BackColor = Color.White;
            }
        }
        public static bool ValidacaoNumeros(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                if (!int.TryParse(control.Text, out int numeros))
                {
                    control.BackColor = Color.Pink;
                    Messages.Aviso("Apenas números.");
                    return false;
                }
                else
                {

                    control.BackColor = Color.White;

                }
            }
            return true;
        }
        public static bool ValiddacaoBusca(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                if (!int.TryParse(control.Text, out int numeros))
                {
                    control.BackColor = Color.Pink;
                    Messages.Aviso("Selecione um registro.");
                    return false;
                }
                else
                {

                    control.BackColor = Color.White;

                }
            }
            return true;
        }

    }
}
