using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Documentos_forms.Models.Orcamentos
{
    public class ItemProduto
    {
        public int QTD { get; set; }
        public decimal Valor { get; set; }
        public required string NomeProduto { get; set; }
        public decimal ValorTotal => QTD * Valor;
        public override string ToString()
        {
            return $"{QTD} x {NomeProduto} @ {Valor:C} = {ValorTotal:C}";
        }
    }
}
