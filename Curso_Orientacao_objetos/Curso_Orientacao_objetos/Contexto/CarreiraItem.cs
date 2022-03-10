using Curso_Orientacao_objetos.ContextoCompartilhado;
using Curso_Orientacao_objetos.NotificacaoConteudo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.Contexto
{
    public class CarreiraItem : Base
    {
        public CarreiraItem(int ordem, string titulo, string descricao, Curso curso)
        {

            if (curso == null)
            {
                AddNotificacao(new Notificacao("Curso", "Curso Invalido"));
            }

            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public Curso Curso { get; set; }
    }
}
