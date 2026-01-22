using Dapper;
using Gerador_de_documentos_net.services;
using Gerador_de_documentos_net.Services;
using Gerador_de_Documentos_net.Models;
using Gerador_de_Documentos_net.Models.Orcamentos;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Documentos_net.Services
{
    public static class DatabaseFunctionsORC
    {
        static string dbPath = "Data Source=BancoDados.db";

        static string sqlTOrcprodutos = "CREATE TABLE IF NOT EXISTS OrcProdutos (IdOrcamento INTEGER, NomeProduto TEXT, Preco Double, QT INTEGER)";
        static string sqlTOrcamentos = "CREATE TABLE IF NOT EXISTS Orcamentos (Id INTEGER PRIMARY KEY AUTOINCREMENT, NomeCliente TEXT, ValorT Double, Data TEXT, FormaPagamento TEXT, Template INTEGER, DescricaoT TEXT, Comentarios TEXT)";
        static string sqlTClientes = "CREATE TABLE IF NOT EXISTS Clientes (CPF TEXT PRIMARY KEY, NomeCliente TEXT, Rua TEXT, Bairro TEXT, Cidade TEXT, Estado TEXT, Telefone TEXT, Email TEXT, CNPJ TEXT, CEP TEXT)";

        //ID
        public static async Task<int> DatabaseOrcID() 
        {
            await using var connection = new SqliteConnection(dbPath);
            await connection.OpenAsync(); 

            string sqlBusca = "SELECT MAX(Id) FROM Orcamentos";
            await using (var cmdBusca = new SqliteCommand(sqlBusca, connection))
            {
                
                object resultado = await cmdBusca.ExecuteScalarAsync();

                if (resultado != DBNull.Value && resultado != null)
                {
                    return Convert.ToInt32(resultado) + 1;
                }
                else
                {
                    return 1; 
                }
            }

        }

        //Cadastro de orçamentos
        public static async Task InicializarBancos()
        {
            await using var connection = new SqliteConnection(dbPath);

            await connection.ExecuteAsync(sqlTOrcamentos);

            await connection.ExecuteAsync(sqlTOrcprodutos);

            await connection.ExecuteAsync(sqlTClientes);



        }

        public static async Task DataBaseOrcCadastro(string nome, string vt, List<ItemProduto> ListaProdutos, int id, string fpagamento, int template, string descricaot, string comentarios)
        {
            await using var connection = new SqliteConnection(dbPath);
            await connection.OpenAsync();
            string sqlInsertion = "INSERT INTO Orcamentos (NomeCliente, ValorT, Data, FormaPagamento, Template, DescricaoT, Comentarios) VALUES (@nome, @valort, @data, @fpagamento, @template, @descricaot, @comentarios)";
            await using var cmd = new SqliteCommand(sqlInsertion, connection);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valort", vt);
            cmd.Parameters.AddWithValue("@data", DateTime.Now);
            cmd.Parameters.AddWithValue("@fpagamento", fpagamento);
            cmd.Parameters.AddWithValue("@template", template);
            cmd.Parameters.AddWithValue("@descricaot", descricaot);
            cmd.Parameters.AddWithValue("@comentarios", comentarios);
            await cmd.ExecuteNonQueryAsync();


            string sqlInsertionProdutos = "INSERT INTO OrcProdutos (IdOrcamento, NomeProduto, Preco, QT) VALUES (@idOrcamento, @nomeProduto, @preco, @qt)";

            foreach (var item in ListaProdutos)
            {
                await using var cmdProdutos = new SqliteCommand(sqlInsertionProdutos, connection);
                cmdProdutos.Parameters.AddWithValue("@idOrcamento", id);
                cmdProdutos.Parameters.AddWithValue("@nomeProduto", item.NomeProduto.ToString());
                cmdProdutos.Parameters.AddWithValue("@preco", item.Valor);
                cmdProdutos.Parameters.AddWithValue("@qt", item.QTD);
                await cmdProdutos.ExecuteNonQueryAsync();




            }


            

            connection.Close();


        }

        public static async Task CadastroCliente(string cpf, string nome, string rua, string bairro, string cidade, string estado, string telefone, string email, string cnpj, string cep)
        {
            if (cpf == "")
            {
                Messages.Aviso("Campo de CPF vazio");
            }
            else
            {
                await using var connection = new SqliteConnection(dbPath);
                await connection.OpenAsync();
                string sqlInsertion = "INSERT INTO Clientes (CPF, NomeCliente, Rua, Bairro, Cidade, Estado, Telefone, Email, CNPJ, CEP) VALUES (@cpf, @nome, @rua, @bairro, @cidade, @estado, @telefone, @email, @cnpj, @cep)";
                await using var cmd = new SqliteCommand(sqlInsertion, connection);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@cep", cep);

                var validacaoCPF = await QueryCliente(cpf);
                if (validacaoCPF == null)
                {
                    await cmd.ExecuteNonQueryAsync();
                    connection.Close();
                    Messages.Confirmacao();
                }
                else
                {
                    Messages.Aviso("CPF já cadastrado");
                }

            }

        }
        public static async Task<Endereco> QueryCliente(string CPF)
        {
            if (CPF == null)
            {
                Messages.Aviso("Campo de CPF vazio");
                return null;
            }
            else
            {
                await using var connection = new SqliteConnection(dbPath);
                connection.OpenAsync();
                string sqlClienteQuery = "SELECT * FROM Clientes WHERE CPF = @cpf ";
                await using var cmd = new SqliteCommand(sqlClienteQuery, connection);
                var cliente = await connection.QueryFirstOrDefaultAsync<Endereco>(sqlClienteQuery, new { cpf = CPF });
                connection.Close();
                DadosBuscaGlobal.CPFSel = CPF;
                return cliente;

            }


        }
        public static async Task QueryClienteNome(string nome)
        {
            if (nome == null)
            {
                Messages.Aviso("Campo de nome vazio");
            }
            else
            {
                await using var connection = new SqliteConnection(dbPath);
                connection.OpenAsync();
                string sqlClienteQuery = "SELECT * FROM Clientes WHERE NomeCliente = @nome ";
                await using var cmd = new SqliteCommand(sqlClienteQuery, connection);
                cmd.Parameters.AddWithValue("nome", nome);
                await using var reader = await cmd.ExecuteReaderAsync();
                
                if(await reader.ReadAsync())
                {
                    DadosBuscaGlobal.CPFSel = Convert.ToString(reader["CPF"]);
                }
                connection.Close();

                return;

            }


        }

        public static async Task<List<DadosBuscaGlobal.modeloBuscaOrcamento>> QueryOrc()
        {
            await using var connection = new SqliteConnection(dbPath);
            connection.OpenAsync();
            string sqlQueryorc = "SELECT * FROM Orcamentos";

            await using var cmd = new SqliteCommand(sqlQueryorc, connection);
            await using var reader = await cmd.ExecuteReaderAsync();
            List<DadosBuscaGlobal.modeloBuscaOrcamento> listaOrcamento = new List<DadosBuscaGlobal.modeloBuscaOrcamento>();
            while(await reader.ReadAsync())
            {
                DadosBuscaGlobal.modeloBuscaOrcamento Orcamento = new DadosBuscaGlobal.modeloBuscaOrcamento()
                {
                    ID = Convert.ToInt32(reader["Id"]),
                    nomeCliente = Convert.ToString(reader["NomeCliente"]),
                    valorT = Convert.ToDouble(reader["ValorT"]),
                    data = Convert.ToDateTime(reader["Data"]),
                    fPagamento = Convert.ToString(reader["FormaPagamento"]),
                    Template = Convert.ToInt32(reader["Template"]),
                    DescricaoT = Convert.ToString(reader["DescricaoT"]),
                    Comentarios = Convert.ToString(reader["Comentarios"])

                };
                listaOrcamento.Add(Orcamento);
                
            }
            connection.Close();
            return listaOrcamento;

        }

        public static async Task<List<ItemProduto>> QueryProdutos(int id)
        {
            await using var connection = new SqliteConnection(dbPath);
            connection.OpenAsync();
            string sqlQueryProdutos = "SELECT * FROM OrcProdutos WHERE IdOrcamento = @id";

            await using var cmd = new SqliteCommand(sqlQueryProdutos, connection);
            cmd.Parameters.AddWithValue("id", id);
            await using var reader = await cmd.ExecuteReaderAsync();
            List<ItemProduto> listaProdutos = new List<ItemProduto>();
            while(await reader.ReadAsync())
            {
                ItemProduto item = new ItemProduto()
                { 
                    NomeProduto = Convert.ToString(reader["NomeProduto"]),
                    Valor = Convert.ToDecimal(reader["Preco"]),
                    QTD = Convert.ToInt32(reader["QT"])
                    
                };
                listaProdutos.Add(item);
            }
            connection.Close();
            return listaProdutos;

        }


    }
}
