using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Documentos_net.Models
{
    public class modeloOrcamento
    {
        public required string Cliente { get; set; }
        public required string CPF { get; set; }
        public decimal Valor { get; set; }
        public int OrcID { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataExp { get; set; }
        public required Endereco EnderecoCliente { get; set; }
        public required string Comentarios { get; set; }
        public required string DescricaoTecnica { get; set; }



    }
    public class Endereco
    {
        public string Nome { get; set; } = string.Empty;
        public string Rua { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;

    }
}
