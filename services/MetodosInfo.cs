using Gerador_de_Documentos_net.Models;
using Gerador_de_documentos_net.services;
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

namespace Gerador_de_Documentos_net.Services
{
    public static class MetodosInfo
    {
        static string arquivo = "Info.csv";

        public static void DialogBoxInfo(OpenFileDialog openFile)
        {
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Imagens (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFile.FilterIndex = 2; // muda o filtro tipo para diferentes tipos de arquivo
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DadosGlobais.CaminhoLogo = openFile.FileName;

            }
        }
        public static bool ChecarInfo()
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

                        }


                    }
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

                    return false;

                }








            }
            else
            {
                Console.WriteLine("Arquivo vazio ou não existente");
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



