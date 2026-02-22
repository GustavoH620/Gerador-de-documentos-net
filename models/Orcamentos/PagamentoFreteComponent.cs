using Gerador_de_Documentos_net.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Gerador_de_documentos_net.models.Orcamentos
{
    public class PagamentoFreteComponent : IComponent
    {
        public decimal totalGeral { get; }
        private Pagamento_Frete PagamentoFrete { get; }
        public PagamentoFreteComponent(Pagamento_Frete pagamentoFrete, decimal tg)
        {
            PagamentoFrete = pagamentoFrete;
            totalGeral = tg;

        }

        public void Compose(IContainer container)
        {
            container.Table(table =>
            {

                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(220);
                    columns.ConstantColumn(225);


                });

                int tamanho = 11;
                table.Cell().Element(CellStyle).Text("Forma de Pagamento:").FontSize(tamanho);
                table.Cell().Element(CellStyle).Text(PagamentoFrete.FormaPagamento).FontSize(tamanho).AlignRight();
                table.Cell().Element(CellStyle).Text("Parcelas:").FontSize(tamanho);
                table.Cell().Element(CellStyle).Text($"{PagamentoFrete.Parcelas}X").FontSize(tamanho).AlignRight();
                table.Cell().Element(CellStyle).Text("Frete:").FontSize(tamanho);
                table.Cell().Element(CellStyle).Text($"R${PagamentoFrete.Frete}").FontSize(tamanho).AlignRight();
                table.Cell().Element(CellStyle).Text("Imposto Incluso:").FontSize(tamanho);
                if (PagamentoFrete.ImpostoIncluso)
                {
                    table.Cell().Element(CellStyle).Text("Sim").FontSize(tamanho).AlignRight();

                }
                else
                {
                    table.Cell().Element(CellStyle).Text("Não").FontSize(tamanho).AlignRight();
                    table.Cell().Element(CellStyle).Text("Valor do imposto:").FontSize(tamanho);
                    table.Cell().Element(CellStyle).Text($"R${PagamentoFrete.ValorImposto}").FontSize(tamanho).AlignRight();

                }
                table.Cell().Element(CellStyle).Text("Total Geral: ").FontSize(tamanho);
                table.Cell().Element(CellStyle).Text($"R${Math.Round(totalGeral + PagamentoFrete.ValorImposto, 2)}").FontSize(tamanho).AlignRight();
                table.Cell().Element(CellStyle).Text($"Em {PagamentoFrete.Parcelas} vezes de: ").FontSize(tamanho);
                table.Cell().Element(CellStyle).Text($"R${Math.Round(totalGeral / PagamentoFrete.Parcelas, 2)}").FontSize(tamanho).AlignRight();




                static IContainer CellStyle(IContainer container)
                {
                    return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                }

            });
        }
    }
}
