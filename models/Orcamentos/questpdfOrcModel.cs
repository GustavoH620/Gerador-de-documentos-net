using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Documentos_forms.Models
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


    }
    public class Endereco
    {
        public required string Nome { get; set; }
        public required string Rua { get; set; }
        public required string Bairro { get; set; }
        public required string Cidade { get; set; }
        public required string Estado { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }

    }
}
