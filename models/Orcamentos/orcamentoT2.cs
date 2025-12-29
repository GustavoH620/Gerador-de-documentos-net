using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_documentos_net.models.Orcamentos;

namespace Gerador_de_Documentos_forms.Models.Orcamentos
{
    public class OrcamentoT2 : IDocument
    {
        public modeloOrcamento Modelo { get; }

        public OrcamentoT2(modeloOrcamento modelo)
        {
            Modelo = modelo;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {

            container.Page(page =>
            {
                page.Margin(50);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().AlignRight().Text(txt =>
                {
                    txt.Span("Página ");
                    txt.CurrentPageNumber();
                    txt.Span(" de ");
                    txt.TotalPages();
                });
            });

        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item()
                        .Text($"Orçamento Nº{Modelo.OrcID}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Issue date: ").SemiBold();
                        text.Span($"{Modelo.DataEmissao:d}");
                    });

                    column.Item().Text(text =>
                    {
                        text.Span("Due date: ").SemiBold();
                        text.Span($"{Modelo.DataExp:d}");
                    });

                });
                if (DadosGlobais.CaminhoLogo == "") { row.ConstantItem(100).Height(100).Placeholder(); } else { row.ConstantItem(100).Height(100).Image(DadosGlobais.CaminhoLogo); }
            });
        }
        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(5);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new AddressComponent("From", DadosGlobais.enderecoVendedor));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new AddressComponent("For", Modelo.EnderecoCliente));
                });

                column.Item().Element(ComposeTable);

                if (!string.IsNullOrWhiteSpace(Modelo.Comentarios))
                    column.Item().PaddingTop(25).Element(ComposeComments);
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("#");
                    header.Cell().Element(CellStyle).Text("Product");
                    header.Cell().Element(CellStyle).AlignRight().Text("Unit price");
                    header.Cell().Element(CellStyle).AlignRight().Text("Quantity");
                    header.Cell().Element(CellStyle).AlignRight().Text("Total");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                foreach (var item in DadosGlobais.ListaItens)
                {
                    table.Cell().Element(CellStyle).Text(DadosGlobais.ListaItens.IndexOf(item) + 1);
                    table.Cell().Element(CellStyle).Text(item.NomeProduto);
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Valor}$");
                    table.Cell().Element(CellStyle).AlignRight().Text(item.QTD);
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.ValorTotal}$");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });
        }

        void ComposeComments(IContainer container)
        {
            container.Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
            {
                column.Spacing(5);
                column.Item().Text("Comments").FontSize(14);
                column.Item().Text(Modelo.Comentarios);
            });
        }
    }
}
