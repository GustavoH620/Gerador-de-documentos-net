using Gerador_de_Documentos_forms.Models;
using Gerador_de_documentos_net.services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
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
        public static bool ChecarInfo()
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
                    string rua = "";
                    string bairro = "";
                    string cidade = "";
                    string estado = "";
                    string email = "";
                    string telefone = "";
                    List<string> values = new List<string>();
                    int c = 0;
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        values.Add($"{linha.Split(',')}");
                        

                        
                    }
                    logo = values[0];
                    nome = values[1];
                    rua = values[2];
                    bairro = values[3];
                    cidade = values[4];
                    estado = values[5];
                    email = values[6];
                    telefone = values[7];
                    DadosGlobais.CaminhoLogo = logo;
                    DadosGlobais.NomeVendedor = nome;
                    DadosGlobais.enderecoVendedor = new Endereco
                    {
                        Nome = nome,
                        Rua = rua,
                        Bairro = bairro,
                        Cidade = cidade,
                        Estado = estado,
                        Email = email,
                        Telefone = telefone,



                    };
                    reader.Close();
                    return false;
                    

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
        public static void CadastroInfo(string caminho, string nome, string rua, string bairro, string cidade
            , string estado, string email, string telefone)
        {
            if (!File.Exists(arquivo))
            {
                File.Create(arquivo);
                File.WriteAllText(arquivo, $"{caminho},{nome},{rua},{bairro},{cidade},{estado},{email},{telefone}");
            }
            else
            {
                StreamWriter reader = null;
                reader = new StreamWriter(File.OpenWrite(arquivo));
                reader.Write($"{caminho},{nome},{rua},{bairro},{cidade},{estado},{email},{telefone}");
                reader.Close();

            }
                

            DadosGlobais.CaminhoLogo = caminho;
            DadosGlobais.NomeVendedor = nome;
            DadosGlobais.enderecoVendedor = new Endereco
            {
                Nome = nome,
                Rua = rua,
                Bairro = bairro,
                Cidade = cidade,
                Estado = estado,
                Email = email,
                Telefone = telefone,



            };

        }
        public static bool ValidacaoGeral(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                if (string.IsNullOrWhiteSpace(control.Text)) 
                {
                    control.BackColor = Color.Pink;
                    MessageBox.Show("Preencha os campos vazios.");
                    return false;


                }
                else
                {
                    control.BackColor = Color.White;
                }
                    
            }
            return true;

        }
    }
}
