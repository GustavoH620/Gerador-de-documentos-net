using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Documentos_forms.Models
{
    public class modeloOrcamento
    {
        public string Cliente { get; set; }
        public string CPF { get; set; }
        public decimal Valor { get; set; }
        public int OrcID { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataExp { get; set; }
        public Endereco EnderecoCliente { get; set; }
        public Endereco Comentarios { get; set; }


    }
    public class Endereco
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
