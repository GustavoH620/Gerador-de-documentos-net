using Gerador_de_Documentos_net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_documentos_net.services
{
    public static class DadosBuscaGlobal
    {
        public static string CPFSel { get; set; } = string.Empty;
        public static string IDSel { get; set; } = string.Empty;
        public static string TopicoBusca { get; set; } = string.Empty;
        public static int checkBusca { get; set; } = 0;
        public static Endereco DadosClienteSel { get; set; } = new Endereco();
        public static void BuscaCliente()
        {
            TopicoBusca = "Digite o CPF";
            checkBusca = 0;
            FormBusca busca = new FormBusca();
            busca.ShowDialog();


        }
    }

}
