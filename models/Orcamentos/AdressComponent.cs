using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Gerador_de_documentos_net.models.Orcamentos
{
    public class AddressComponent : IComponent
    {
        private string Title { get; }
        private Endereco Address { get; }

        public AddressComponent(string title, Endereco address)
        {
            Title = title;
            Address = address;
        }

        public void Compose(IContainer container)
        {
            container.Column(column =>
            {
                column.Spacing(2);

                column.Item().BorderBottom(1).PaddingBottom(5).Text(Title).SemiBold().FontColor(Colors.Blue.Lighten3);

                column.Item().Border(1).Padding(2).Text(Address.NomeCliente);
                column.Item().Border(1).Padding(2).Text(Address.Rua);
                column.Item().Border(1).Padding(2).Text($"{Address.Cidade}, {Address.Estado}");
                column.Item().Border(1).Padding(2).Text($"CEP: {Address.CEP}, CNPJ: {Address.CNPJ}");
                column.Item().Border(1).Padding(2).Text(Address.Email);
                column.Item().Border(1).Padding(2).Text(Address.Telefone);


            });
        }
    }
}
