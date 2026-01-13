using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador_de_Documentos_net.Services;
using QuestPDF.Helpers;

namespace Gerador_de_Documentos_net.Models.Orcamentos
{
    public static class questPDFOrcDataSource
    {
        public static modeloOrcamento PegarDadosOrc(string nomeCliente, string CPF, string CNPJ, string CEP, string DescricaoTecnica, string FormaPagamento, DateTime PrazoEntrega, 
            decimal Frete, bool ImpostoIncluso, decimal ValorImposto, int Parcelas,
            decimal ValorT, int ID, List<ItemProduto> ListaProdutos, string Comentarios,
            string Rua, string Bairro, string Cidade, string Estado, string Email, string Telefone, DateTime dataExp )
        {
            var itens = ListaProdutos.ToList();
            return new modeloOrcamento
            {
                Cliente = nomeCliente,
                CPF = CPF,
                Valor = ValorT,
                OrcID = ID,
                DataEmissao = DateTime.Now,
                DataExp = dataExp,
                Comentarios = Comentarios,
                DescricaoTecnica = DescricaoTecnica,

                


                PagamentoCliente = new Pagamento_Frete
                {
                    FormaPagamento = FormaPagamento,
                    Frete = Frete,
                    ImpostoIncluso = ImpostoIncluso,
                    ValorImposto = ValorImposto,
                    Parcelas = Parcelas,
                    PrazoEntrega = PrazoEntrega,

                },


                EnderecoCliente = new Endereco
                {
                    Rua = Rua,
                    Bairro = Bairro,
                    Cidade = Cidade,
                    Estado = Estado,
                    Email = Email,
                    Telefone = Telefone,
                    Nome = nomeCliente,
                    CNPJ = CNPJ,
                    CEP = CEP

                }

            };
        }
    }
}
