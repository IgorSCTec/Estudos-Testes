using Curso_Orientacao_objetos.Contexto.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.Contexto
{
    public class Curso : Conteudo
    {

        public Curso(string title, string url)
            :base(title,url)
        {
            Modulos = new List<Modulo>();
        }

        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }

        public int DuracaoEmMinutos { get; set; }

        public EConteudoLevel Level { get; set; }
    }

}
