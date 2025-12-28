using Gerador_de_documentos_net.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Gerador_de_Documentos_forms.Services
{
    public static class Metodos
    {
        static string arquivo = "Info.csv"; 
        public static bool ChecarLogo()
        {
            if (File.Exists(arquivo))
            {
                
                string[] linhas = File.ReadAllLines(arquivo);
                if (linhas.Length > 0)
                {
                    StreamReader reader = null;
                    reader = new StreamReader(File.OpenRead(arquivo));
                    string logo = "";
                    string nome = "";
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var values = linha.Split(',');
                        logo = values[0];
                        nome = values[1];
                    }
                    DadosGlobais.CaminhoLogo = logo;
                    DadosGlobais.NomeVendedor = nome;
                    reader.Close();
                    return true;
                    

                }
                else
                {
                    Console.WriteLine("Arquivo vazio, questão apresentada");
                    if (Messages.AdicionarLogo())
                    {
                        return false;


                    }
                    else
                    {
                        return true;
                    }

                }


            }
            else
            {
                Console.WriteLine("Arquivo não existe");
                if (Messages.AdicionarLogo())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }
        public static void CadastroInfo(string caminho, string nome)
        {
            if (!File.Exists(arquivo))
            {
                File.Create(arquivo);
            }
            StreamWriter reader = null;
            reader = new StreamWriter(File.OpenWrite(arquivo));
            reader.Write($"{caminho},{nome}");
            reader.Close();

            DadosGlobais.CaminhoLogo = caminho;
            DadosGlobais.NomeVendedor = nome;

        }
    }
}
