using System;
using System.Threading;

namespace TesteCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("");
            Console.Write("Escolha a opção desejada: ");

            int opcao;

            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("");
                Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");
                Thread.Sleep(1000);
                Menu();
            }

                switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default:
                    Console.WriteLine("");
                    Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");
                    Thread.Sleep(1000);
                    Menu(); break;                   
;            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Operação de Soma");
            Console.WriteLine("");
            Console.Write("Digite o primeiro número: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o segundo número: ");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = valor1 + valor2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("");
            OutraOperacao();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Operação de Subtração");
            Console.WriteLine("");
            Console.Write("Digite o primeiro número: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o segundo número: ");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = valor1 - valor2;
            Console.WriteLine("O resultado é :" + resultado);
            Console.WriteLine("");
            OutraOperacao();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Operação de Multiplicação");
            Console.WriteLine("");
            Console.Write("Digite o primeiro número: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o segundo número: ");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = valor1 * valor2;
            Console.WriteLine("O resultado é :" + resultado);
            Console.WriteLine("");
            OutraOperacao();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Operação de Divisão");
            Console.WriteLine("");
            Console.Write("Digite o primeiro número: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o segundo número: ");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = valor1 / valor2;
            if (double.IsInfinity(resultado) == true || double.IsNaN(resultado) == true)
            {
                Console.WriteLine("Divisão por 0 é impossível.");
                Console.WriteLine("");
                Console.WriteLine("Digite números diferentes.");
                Thread.Sleep(2000);
                Divisao();
            }
            else
            {
                Console.WriteLine("O resultado é :" + resultado);
                Console.WriteLine("");
                OutraOperacao();
            }
        }
        static void OutraOperacao()
        {
            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("");
            Console.Write("Digite Sim ou Não: ");
            string escolha = Console.ReadLine();
            
            if (escolha == "Sim")
            {
                Menu();
            }
            
            if (escolha == "Não")
            {
                Console.WriteLine("");
                Console.WriteLine("Obrigado por utilizar a nossa Calculadora, até a próxima.");
                Console.WriteLine("");
                Console.WriteLine("Aperte qualque tecla para finalizar.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            
            if (escolha != "Sim" && escolha != "Não")
            {
                while (escolha != "Sim" && escolha != "Não")
                {
                    Console.Write("Está não é uma opção válida. Digite Sim para fazer outra operação ou Não para sair do Sistema: ");
                    string novaEscolha = Console.ReadLine();
                    escolha = novaEscolha;
                }

                if (escolha == "Sim")
                {
                    Menu();
                }

                if (escolha == "Não")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Obrigado por utilizar a nossa Calculadora, até a próxima.");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte qualque tecla para finalizar.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Obrigado por utilizar a nossa Calculadora, até a próxima.");
            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadKey();
            System.Environment.Exit(0);

        }
    }
}
