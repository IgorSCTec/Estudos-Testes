using Curso_Orientacao_objetos.Contexto.Enums;
using Curso_Orientacao_objetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.Contexto
{
    public class Aula : Base
    {
        public int Ordem { get; set; }

        public string Titulo { get; set; }

        public int DuracaoEmMinutos { get; set; }

        public EConteudoLevel Level { get; set; }

    }
}
