using Microsoft.Data.Sqlite;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerador_de_Documentos_net.Models.Orcamentos;
using System.Security.Cryptography;

namespace Gerador_de_Documentos_net.Services
{
    public static class DatabaseFunctionsORC
    {
        static string dbPath = "Data Source=BancoOrcamentos.db";
        static string sqlTprodutos = "CREATE TABLE IF NOT EXISTS OrcProdutos (IdOrcamento INTEGER, NomeProduto TEXT, Preco Double, QT INTEGER)";
        static string sqlTOrcamentos = "CREATE TABLE IF NOT EXISTS Orcamentos (Id INTEGER PRIMARY KEY AUTOINCREMENT, NomeCliente TEXT, ValorT Double, Data TEXT)";
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

            await connection.ExecuteAsync(sqlTprodutos);



        }

        public static async Task DataBaseOrcCadastro(string nome, string vt, List<ItemProduto> ListaProdutos, int id)
        {
            await using var connection = new SqliteConnection(dbPath);
            await connection.OpenAsync();
            string sqlInsertion = "INSERT INTO Orcamentos (NomeCliente, ValorT, Data) VALUES (@nome, @valort, @data)";
            await using var cmd = new SqliteCommand(sqlInsertion, connection);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valort", vt);
            cmd.Parameters.AddWithValue("@data", DateTime.Now);
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


    }
}
