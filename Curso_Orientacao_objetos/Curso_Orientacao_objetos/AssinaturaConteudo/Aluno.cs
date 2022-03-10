using Curso_Orientacao_objetos.ContextoCompartilhado;
using Curso_Orientacao_objetos.NotificacaoConteudo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curso_Orientacao_objetos.AssinaturaConteudo
{
    class Aluno : Base
    {

        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }
        public string Nome { get; set; }

        public string Email { get; set; }
        public Usuario Usuario { get; set; }

        public IList<Assinatura> Assinaturas { get; set; }

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (AlunoPremium)
            {
                AddNotificacao(new Notificacao ("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }

            Assinaturas.Add(assinatura);
        }

        public bool AlunoPremium => Assinaturas.Any(x => !x.EstaInativo);
    }
}
