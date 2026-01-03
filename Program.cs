using Gerador_de_Documentos_net;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace Gerador_de_documentos_net
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
            

        }
    }
}