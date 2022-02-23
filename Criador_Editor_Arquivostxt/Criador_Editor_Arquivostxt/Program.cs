using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criador_Editor_Arquivostxt
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("1 - Para criar um arquivo");
            Console.WriteLine("2 - Para editar um arquivo");
            Console.WriteLine("0 - Para sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: System.Environment.Exit(0); break;
            }

        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo (ESC para sair)");
            Console.WriteLine("_________________________________________");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
