using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Services;
using BookStore.Common.ViewModels;

namespace BookStore.Controllers
{
    public class LibroController : Controller
    {
        private LibroService _libroService;

        public LibroController(LibroService libroService)
        {
            _libroService = libroService;
        }
        
        // GET: Libro
        public ActionResult Index()
        {
            try
            {
                var libros = _libroService.Get();
                ViewBag.Titulo = "Search Books";
                return View(libros);
            }
            catch (Exception ex)
            {
                throw; // redirigir a una pagina de error
            }
        }
    }
}