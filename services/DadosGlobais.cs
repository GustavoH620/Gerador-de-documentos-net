using Gerador_de_Documentos_forms.Models;
using Gerador_de_Documentos_forms.Models.Orcamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Documentos_forms
{
    public static class DadosGlobais
    {
        // Varíavel de armazenamento dde template selecionado orçamento
        public static int OrcTemplateSelected { get; set; } = 0;

        // Variável de armazenamento de template selecionado invoice
        public static int InvTemplateSelected { get; set; } = 0;

        // Variável de caminho de arquivo da logo
        public static string CaminhoLogo { get; set; } = "";
        public static string NomeVendedor { get; set; } = "";

        public static Endereco enderecoVendedor { get; set; }

        public static List<ItemProduto> ListaItens = new List<ItemProduto>();






    }

}
