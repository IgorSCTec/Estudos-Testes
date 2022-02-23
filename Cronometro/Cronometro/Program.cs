using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.WriteLine("Cronômetro");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("");
            Console.WriteLine("Digite o tempo seguido de \"s\" para segundos e seguido de \"m\" para minutos");
            Console.WriteLine("");
            Console.WriteLine("Exemplo: 30s 0u 30m.");
            TratamentoDados();
        }

        static void TratamentoDados()
        {
            Console.WriteLine("");
            Console.Write("Por gentileza digite agora: ");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            
            if (type == 'm')
                {
                multiplier = 60;
                }

            Start(time * multiplier);

        }
        static void Start(int time)
        {

            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Go!!!");
            Thread.Sleep(1500);
            Console.Clear();
            int currentTime = 0;
                        

            while (currentTime != time)
                {
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }

         }
    }
}

