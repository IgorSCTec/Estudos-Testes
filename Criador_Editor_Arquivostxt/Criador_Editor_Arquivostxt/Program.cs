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
                case 1: Criar(); break;
                case 2: Editar(); break;
                default: System.Environment.Exit(0); break;
            }

        }

        static void Criar()
        {

        }

        static void Editar()
        {

        }
    }
}
