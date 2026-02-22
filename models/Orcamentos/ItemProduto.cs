namespace Gerador_de_Documentos_net.Models.Orcamentos
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
