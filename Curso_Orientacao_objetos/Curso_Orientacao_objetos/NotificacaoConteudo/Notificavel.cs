using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curso_Orientacao_objetos.NotificacaoConteudo
{
    public abstract class Notificavel
    {

        public List<Notificacao> Notificacoes { get; set; }

        public Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }

        public bool IsInvalid => Notificacoes.Any();
    }
}
