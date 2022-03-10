using Curso_Orientacao_objetos.AssinaturaConteudo;
using Curso_Orientacao_objetos.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso_Orientacao_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo Sobre OOP", "Orientacao-Objetos"));
            artigos.Add(new Artigo("Artigo Sobre C#", "Csharp"));
            artigos.Add(new Artigo("Artigo Sobre .NET", "Dotnet"));

            foreach (var artigo in artigos)
            {
                Console.WriteLine(artigo.Id);
                Console.WriteLine(artigo.Title);
                Console.WriteLine(artigo.Url);
            }

            var cursos = new List<Curso>();
            var cursoOOP = new Curso("Fundamentos OOP", "Fundamentos-OOP");
            var cursoCsharp = new Curso("C#", "csharp");
            var cursoDotnet = new Curso(".NET", "dotnet");

            cursos.Add(cursoOOP);
            cursos.Add(cursoCsharp);
            cursos.Add(cursoDotnet);

            var carreiras = new List<Carreira>();
            var carreiraDotnet = new Carreira("Especilista .NET", "especialista-dotnet");
            var carreiraItem2 = new CarreiraItem(2, "OOP", "", null);
            var carreiraItem1 = new CarreiraItem(1, "Comece por aqui", "", cursoCsharp);
            var carreiraItem3 = new CarreiraItem(3, "Aprenda .NET", "", cursoDotnet);
            carreiraDotnet.Items.Add(carreiraItem2);
            carreiraDotnet.Items.Add(carreiraItem3);
            carreiraDotnet.Items.Add(carreiraItem1);
            carreiras.Add(carreiraDotnet);

            foreach (var carreira in carreiras)
            {
                Console.WriteLine(carreira.Title);

                foreach (var item in carreira.Items.OrderBy(x=>x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                    Console.WriteLine(item.Curso?.Title);
                    Console.WriteLine(item.Curso?.Level);

                    foreach (var notification in item.Notificacoes)
                    {
                        Console.WriteLine($"{notification.Propriedade} - {notification.Propriedade}");
                    }
                }
            }

            var assinaturaPayPal = new AssinaturaPayPal();
            var aluno = new Aluno();
            aluno.CriarAssinatura(assinaturaPayPal);

            Console.ReadKey();
        }
    }
}
