using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Noticias
    {
        int id;
        string titulo, autor, conteudo;
        DateTime data;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Conteudo { get => conteudo; set => conteudo = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}