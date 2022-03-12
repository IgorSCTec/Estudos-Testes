using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula_PA
{
	public class Program
	{
		public static void Main()
		{
			Menu();
			System.Environment.Exit(0);
		}

		public static void Menu()
		{
			Console.Clear();
			Console.WriteLine("Atividade Prática - Desvios Condicionais");
			Console.WriteLine("");
			Console.WriteLine("Escolha o exercício desejado.");
			Console.WriteLine("");
			Console.WriteLine("1 - Verificar o Maior número\n2 - Verificar se o número é Par ou Impar\n3 - Maior dividido pelo Menor\n4 - Lucro ou Prejuízo\n5 - Produto de dois números\n6 - Maior ou Menor que 100\n7 - Farol\n8 - Desempenho Futebol\n9 - Empréstimo");
			Console.WriteLine("");
			var opcao = int.Parse(Console.ReadLine());

			switch (opcao)
			{
				case 1: VerificarMaior(); break;
				case 2: ParImpar(); break;
				case 3: DivisaoMaior(); break;
				case 4: Balanco(); break;
				case 5: Produto(); break;
				case 6: MaiorMenor100(); break;
				case 7: Farol(); break;
				case 8: Desempenho(); break;
				case 9: CreditoImobiliario(); break;

				default:
					Console.WriteLine("");
					Console.Write("Essa não é uma opção válida. Por gentileza selecionar a operação que deseja.");
					Thread.Sleep(1000);
					Menu(); break;
			}
		}

			public static void VerificarMaior()
			{
				Console.WriteLine("");
				Console.Write("Digite o Primeiro Número: ");
				var primeiroNumero = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.Write("Digite o Segundo Número: ");
				var segundoNumero = double.Parse(Console.ReadLine());
				Console.WriteLine("");

				if (primeiroNumero > segundoNumero)
					Console.WriteLine("O primeiro número é o maior: " + primeiroNumero);

				if (primeiroNumero < segundoNumero)
					Console.WriteLine("O segundo número é o maior: " + segundoNumero);

				if (primeiroNumero == segundoNumero)
					Console.WriteLine("Os números são iguais: " + primeiroNumero + " e " + segundoNumero);

				OutraOperacao();

			}

			public static void ParImpar()
			{
				Console.WriteLine("");
				Console.Write("Digite o Número: ");
				var numero = double.Parse(Console.ReadLine());
				Console.WriteLine("");

				if (numero % 2 == 0)
				{
					Console.WriteLine("Numero Par: " + numero);
				}
				else
				{
					Console.WriteLine("Numero Impar: " + numero);
				}

				OutraOperacao();

			}

			public static void DivisaoMaior()
			{
				Console.WriteLine("");
				Console.Write("Digite o Primeiro Número: ");
				var primeiroNumero = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.Write("Digite o Segundo Número: ");
				var segundoNumero = double.Parse(Console.ReadLine());
				Console.WriteLine("");

				if (primeiroNumero > segundoNumero)
				{
					Console.WriteLine("O maior número digitado foi: " + primeiroNumero);
					var resultado = primeiroNumero / segundoNumero;
					Console.WriteLine("");
					Console.WriteLine("O Resultado de Divisão é: " + resultado);
				}

				if (primeiroNumero < segundoNumero)
				{
					Console.WriteLine("O maior númeor digitado foi: " + segundoNumero);
					var resultado = segundoNumero / primeiroNumero;
					Console.WriteLine("");
					Console.WriteLine("O Resultado de Divisão é: " + resultado);
				}

				if (primeiroNumero == segundoNumero)
				{
					Console.WriteLine("Os dois número são iguais: " + primeiroNumero + " e " + segundoNumero);
					var resultado = segundoNumero / primeiroNumero;
					Console.WriteLine("");
					Console.WriteLine("O Resultado de Divisão é: " + resultado);
				}

				OutraOperacao();
			}

			public static void Balanco()
			{
				Console.WriteLine("");
				Console.Write("Digite a sua Receita: ");
				var receita = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.Write("Digite a sua Despesa: ");
				var despesa = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				var resultado = receita - despesa;

				if (resultado > 0)
					Console.WriteLine("O Lucro da empresa foi de: " + resultado);

				if (resultado < 0)
					Console.WriteLine("O Prejuízo da empresa foi de: " + resultado);

				if (resultado == 0)
					Console.WriteLine("Você não teve Lucro e nem Prejuízo, o resultado foi de : " + resultado);

				OutraOperacao();
			}

			public static void Produto()
			{
				Console.WriteLine("");
				Console.Write("Digite o Primeiro Número: ");
				var primeiroNumero = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.Write("Digite o Segundo Número: ");
				var segundoNumero = double.Parse(Console.ReadLine());
				var produto = primeiroNumero * segundoNumero;
				Console.WriteLine("");
				Console.WriteLine("O produto dos dois números é: " + produto);

				OutraOperacao();

			}

			public static void MaiorMenor100()
			{
				Console.WriteLine("");
				Console.Write("Digite o Número: ");
				var numero = double.Parse(Console.ReadLine());
				Console.WriteLine("");

				if (numero > 100)
					Console.WriteLine("Número Maior que Cem: " + numero);

				if (numero < 100)
					Console.WriteLine("Número Menor que Cem: " + numero);

				if (numero == 100)
					Console.WriteLine("Número Igual a Cem: " + numero);

				OutraOperacao();
			}

			public static void Farol()
			{
				Console.WriteLine("");
				Console.WriteLine("Considere: \n\n1 - Sinal Vermelho\n2 - Sinal Verde");
				Console.WriteLine("");
				Console.Write("Digite a sua opção: ");
				var opcao = double.Parse(Console.ReadLine());
				Console.WriteLine("");

				if (opcao == 1)
					Console.WriteLine("Espere, o Sinal está Vermelho");
				else
					Console.WriteLine("Poder Seguir, o Sinal está Verde");

				OutraOperacao();
			}

			public static void Desempenho()
			{
				Console.WriteLine("");
				Console.Write("Digite o Número de Vitorias: ");
				var vitorias = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.Write("Digite o Número de Derrotas: ");
				var derrotas = double.Parse(Console.ReadLine());
				Console.WriteLine("");

				if (vitorias > derrotas)
					Console.WriteLine("O desempenho foi BOM.");

				if (vitorias < derrotas)
					Console.WriteLine("O desempenho foi RUIM.");

				if (vitorias == derrotas)
					Console.WriteLine("O número de Vitórias e Derrotas foi igual.");

				OutraOperacao();
			}

			public static void CreditoImobiliario()
			{
				Console.WriteLine("");
				Console.Write("Digite o seu Salário: ");
				var salario = double.Parse(Console.ReadLine());
				var emprestimo = salario * 0.30;
				Console.WriteLine("");
				Console.WriteLine("Você tem liberado até " + emprestimo + " de empréstimo.");

				OutraOperacao();
			}

			public static void OutraOperacao()
		{
			Console.WriteLine("");
			Console.WriteLine("Deseja fazer mais alguma operação?");
			Console.WriteLine("");
			Console.Write("Digite Sim ou Nao: ");
			string escolha = Console.ReadLine();

			if (escolha == "Sim")
			{
				Menu();
			}

			if (escolha == "Nao")
			{
				Console.WriteLine("");
				Console.WriteLine("Obrigado por utilizar a nossa Calculadora, até a próxima.");
				Console.WriteLine("");
				Console.WriteLine("Aperte qualque tecla para finalizar.");
				Console.ReadKey();
				System.Environment.Exit(0);
			}

			if (escolha != "Sim" && escolha != "Nao")
			{
				while (escolha != "Sim" && escolha != "Nao")
				{
					Console.Write("Está não é uma opção válida. Digite Sim para fazer outra operação ou Não para sair do Sistema: ");
					string novaEscolha = Console.ReadLine();
					escolha = novaEscolha;
				}

				if (escolha == "Sim")
				{
					Menu();
				}

				if (escolha == "Nao")
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