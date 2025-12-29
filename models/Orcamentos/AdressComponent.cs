using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_Documentos_forms.Models;
using QuestPDF.Drawing;
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

                column.Item().BorderBottom(1).PaddingBottom(5).Text(Title).SemiBold();

                column.Item().Text(Address.Nome);
                column.Item().Text(Address.Rua);
                column.Item().Text($"{Address.Cidade}, {Address.Estado}");
                column.Item().Text(Address.Email);
                column.Item().Text(Address.Telefone);
            });
        }
    }
}
