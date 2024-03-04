using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalDeNoticias.Models;


namespace PortalDeNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {
            return View(Repositorio.ListadeNoticia1);
        }

        public ActionResult Detalhes(int id)

        {
            var noticiaSelecionada = Repositorio.ListadeNoticia1.FirstOrDefault(not => not.Id == id);
            return View(noticiaSelecionada);
        }

        public ActionResult Buscar(string texto)
        {
            var noticiasEncontrada = Repositorio.ListadeNoticia1.Where(not => not.Titulo.Contains(texto)
            || not.Conteudo.Contains(texto));
            return View(noticiasEncontrada);
        }
    }



}
