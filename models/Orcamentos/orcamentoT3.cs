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

namespace Gerador_de_Documentos_net.Models.Orcamentos
{
    public class OrcamentoT3 : IDocument
    {
        public modeloOrcamento Modelo { get; }

        public OrcamentoT3(modeloOrcamento modelo)
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
                page.Footer().Element(ComposeFooter);
            });

        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                 

                row.RelativeItem().Column(column =>
                {
                    if (DadosGlobais.CaminhoLogo == "") 
                    { 
                        column.Item().Height(150).Placeholder(); 
                    }
                    else
                    {
                        column.Item().AlignCenter().Width(150).Height(150).Image(DadosGlobais.CaminhoLogo);
                    }
                    column.Item()
                        .Text($"{DadosGlobais.NomeVendedor}").FontSize(15).Bold().AlignLeft();
                    column.Item()
                        .Text($"Orçamento")
                        .FontSize(15).SemiBold().FontColor(Colors.Blue.Medium).AlignLeft();

                    column.Item().Text(text =>
                    {
                        text.Span("Data de emissão: ").SemiBold();
                        text.Span($"{Modelo.DataEmissao:d}");
                        text.AlignLeft();
                    });

                    column.Item().Text(text =>
                    {
                        text.Span("Data de expiração:  ").SemiBold();
                        text.Span($"{Modelo.DataExp:d}");
                        text.AlignLeft();
                    });

                });

            });
        }
        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(5);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new AddressComponent("De", DadosGlobais.enderecoVendedor));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new AddressComponent("Para", Modelo.EnderecoCliente));
                });

                column.Item().Element(ComposeTable);
                column.Item().Component(new PagamentoFreteComponent(Modelo.PagamentoCliente, Modelo.Valor));

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
                    header.Cell().Element(CellStyle).Text("Produto");
                    header.Cell().Element(CellStyle).AlignRight().Text("Preço unitário");
                    header.Cell().Element(CellStyle).AlignRight().Text("Quantidade");
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
                    table.Cell().Element(CellStyle).AlignRight().Text($"R${item.Valor}");
                    table.Cell().Element(CellStyle).AlignRight().Text(item.QTD);
                    table.Cell().Element(CellStyle).AlignRight().Text($"R${item.ValorTotal}");

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
                column.Item().Text("Comentários").FontSize(14);
                column.Item().Text(Modelo.Comentarios);
            });
        }

        void ComposeFooter(IContainer container)
        {
            container.Row(row =>
                row.RelativeItem().Column(column =>
                {
                    column.Item()
                        .Text($"{DadosGlobais.NomeVendedor}").AlignCenter().FontSize(15).Bold();
                    column.Item()
                        .Text($"{DadosGlobais.enderecoVendedor.Rua} - {DadosGlobais.enderecoVendedor.Bairro} - {DadosGlobais.enderecoVendedor.Cidade} -{DadosGlobais.enderecoVendedor.Estado} / Fone: {DadosGlobais.enderecoVendedor.Telefone}")
                        .AlignRight();
                    column.Item()
                        .Text($"{DadosGlobais.enderecoVendedor.Email}").AlignCenter();
                    column.Item()
                        .Text(txt =>
                        {
                            txt.Span("Página ");
                            txt.CurrentPageNumber();
                            txt.Span(" de ");
                            txt.TotalPages();
                            txt.AlignRight();
                            txt.AlignEnd();
                        });
                }
                )
            );
        }
    }
}
