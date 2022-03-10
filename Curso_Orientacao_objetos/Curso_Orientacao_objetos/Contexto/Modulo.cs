using Curso_Orientacao_objetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.Contexto
{
    public class Modulo : Base
    {

        public Modulo()
        {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }

        public string Titulo { get; set; }

        public IList<Aula> Aulas { get; set; }

    }
}
