using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.NotificacaoConteudo
{
    public sealed class Notificacao
    {

        public Notificacao()
        {

        }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Propriedade { get; set; }
        public string Mensagem { get; set; }

    }
}
