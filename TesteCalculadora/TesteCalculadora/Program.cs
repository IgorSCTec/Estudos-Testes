using System;

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
            Console.WriteLine("Calculadora");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("");
            Console.Write("Escolha a opção desejada: ");

            int opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
            }
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
            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.Write("Digite Sim ou Não:");
            //bool escolha = Convert.ToBoolean(Console.ReadLine());
            //if (escolha = "Sim") ;
            //{
            Menu();
            // }
            // Console.WriteLine("Obrigado por utilizar a nossa Calculadora, até a próxima.")
            Console.ReadKey();
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
            Console.ReadKey();
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
            Console.ReadKey();
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
            Console.WriteLine("O resultado é :" + resultado);
            Console.ReadKey();
        }
    }
}
