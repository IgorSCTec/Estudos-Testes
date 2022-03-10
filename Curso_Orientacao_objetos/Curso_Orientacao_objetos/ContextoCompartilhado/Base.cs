using Curso_Orientacao_objetos.NotificacaoConteudo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.ContextoCompartilhado
{
    public abstract class Base : Notificavel
    {

        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

    }
}
