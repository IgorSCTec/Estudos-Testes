using Curso_Orientacao_objetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.AssinaturaConteudo
{
    class Assinatura : Base
    {
        public Plano Plano { get; set; }

        public DateTime? DataFinal { get; set; }

        public bool EstaInativo => DataFinal <= DateTime.Now;
    }
}
