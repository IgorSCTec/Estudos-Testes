using Curso_Orientacao_objetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.Contexto
{
    public abstract class Conteudo : Base
    {

        public Conteudo(string title, string url)
        {
            Title = title;
            Url = url;
        }     
        

        public string Title { get; set; }

        public string Url { get; set; }
    }
}
