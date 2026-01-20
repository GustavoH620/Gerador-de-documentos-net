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

        public class modeloBuscaOrcamento()
        {
            public int ID { get; set; } = 0;
            public string nomeCliente { get; set; } = string.Empty;

            public  double valorT { get; set; } = 0;
            public DateTime data { get; set; }
            public override string ToString()
            {
                return $"ID: {ID} Nome do Cliente: {nomeCliente} Data: {data}";
            }
        }
        public static void BuscaCliente()
        {
            TopicoBusca = "Digite o CPF";
            checkBusca = 0;
            FormBuscaCliente busca = new FormBuscaCliente();
            busca.ShowDialog();


        }
        public static void BuscaOrcamento()
        {
            TopicoBusca = "Digite o Nome do Cliente";
            checkBusca = 1;
            FormBuscaOrc busca = new FormBuscaOrc();
            busca.ShowDialog();
        }
    }

}
