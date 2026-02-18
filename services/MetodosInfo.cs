using Gerador_de_documentos_net.services;
using Gerador_de_Documentos_net.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Net.Mime.MediaTypeNames;

namespace Gerador_de_Documentos_net.Services
{
    public static class MetodosInfo
    {
        public static string CriarInfo()
        {
            string pastaAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gerador setup 1");
            if (!Directory.Exists(pastaAppData))
            {
                Directory.CreateDirectory(pastaAppData);
            }
            string arquivo = Path.Combine(pastaAppData, "Info.csv");
            return arquivo;
        }
        static string arquivo = CriarInfo();
        


        public static void DialogBoxInfo(OpenFileDialog openFile)
        {
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFile.Filter = "Imagens (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFile.FilterIndex = 1; // muda o filtro tipo para diferentes tipos de arquivo
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DadosGlobais.CaminhoLogo = openFile.FileName;

            }
        }
        public static bool ChecarInfo(bool checkoverridde)
        {
            if (File.Exists(arquivo))
            {
                string logo = "";
                string nome = "";
                string rua = "";
                string bairro = "";
                string cidade = "";
                string estado = "";
                string email = "";
                string telefone = "";
                string cep = "";
                string cnpj = "";

                using (TextFieldParser parser = new TextFieldParser(arquivo))
                {
                    string[] campos;
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        campos = parser.ReadFields();
                        if (campos.Length >= 8)
                        {
                            logo = campos[0];
                            nome = campos[1];
                            rua = campos[2];
                            bairro = campos[3];
                            cidade = campos[4];
                            estado = campos[5];
                            email = campos[6];
                            telefone = campos[7];
                            cep = campos[8];
                            cnpj = campos[9];
                            

                        }


                    }
                    DadosGlobais.CaminhoLogo = logo;
                    DadosGlobais.NomeVendedor = nome;
                    DadosGlobais.enderecoVendedor = new Endereco
                    {
                        NomeCliente = nome,
                        Rua = rua,
                        Bairro = bairro,
                        Cidade = cidade,
                        Estado = estado,
                        Email = email,
                        Telefone = telefone,
                        CEP = cep,
                        CNPJ = cnpj,



                    };
                    parser.Close();

                    return true;

                }








            }
            else if (checkoverridde != true)
            {
                Console.WriteLine("Arquivo vazio ou não existente");
                if (Messages.AdicionarLogo())
                {
                    return true;


                }
                else
                {
                    return false;
                }

            }
            else
            {
                return true;
            }


        }
        public static void CadastroInfo(string caminho, string nome, string rua, string bairro, string cidade
            , string estado, string CEP, string CNPJ, string email, string telefone)
        {
            if (!File.Exists(arquivo))
            {
                StreamWriter reader = null;
                reader = new StreamWriter(File.OpenWrite(arquivo));
                reader.Write($"{caminho},{nome},{rua},{bairro},{cidade},{estado},{email},{telefone}, {CEP}, {CNPJ}");
                reader.Close();

            }
            else
            {
                StreamWriter reader = null;
                reader = new StreamWriter(File.OpenWrite(arquivo));
                reader.Write($"{caminho},{nome},{rua},{bairro},{cidade},{estado},{email},{telefone},{CEP},{CNPJ}");
                reader.Close();

            }


            DadosGlobais.CaminhoLogo = caminho;
            DadosGlobais.NomeVendedor = nome;
            DadosGlobais.enderecoVendedor = new Endereco
            {
                NomeCliente = nome,
                Rua = rua,
                Bairro = bairro,
                Cidade = cidade,
                Estado = estado,
                Email = email,
                Telefone = telefone,
                CEP = CEP,
                CNPJ = CNPJ,



            };

        }

    }
}



