using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_Orientacao_objetos.Contexto
{
    public class Carreira : Conteudo
    {

        public Carreira(string title, string url)
            :base (title,url)
        {
            Items = new List<CarreiraItem>(); 
        }

        public IList<CarreiraItem> Items { get; set; }

        public int TotalCursos => Items.Count;      

    }

}
