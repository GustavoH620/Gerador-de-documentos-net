using Microsoft.Data.Sqlite;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Documentos_net.Services
{
    public static class DatabaseFunctions
    {
        static string dbPath = "Data Source=BancoOrcamentos.db";

        public static async Task<int> DatabaseOrcID() 
        {
            await using var connection = new SqliteConnection(dbPath);
            await connection.OpenAsync(); 

            
            string sqlCriar = "CREATE TABLE IF NOT EXISTS Orcamentos (Id INTEGER PRIMARY KEY AUTOINCREMENT, NomeCliente TEXT, ListaProdutos TEXT, ValorT Double, Data TEXT)";
            await using (var cmdCriar = new SqliteCommand(sqlCriar, connection))
            {
                await cmdCriar.ExecuteNonQueryAsync();
            }

            
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
        public static async Task DataBaseOrcCadastro(string nome, string produtos, string vt)
        {
            await using var connection = new SqliteConnection(dbPath);
            string sql = "CREATE TABLE IF NOT EXISTS Orcamentos (Id INTEGER PRIMARY KEY AUTOINCREMENT, NomeCliente TEXT, ListaProdutos TEXT, ValorT Double, Data TEXT)";
            await connection.ExecuteAsync(sql);


        }


    }
}
