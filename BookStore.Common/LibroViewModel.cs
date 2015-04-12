using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Dominio;

namespace BookStore.Common.ViewModels 
{
    public class LibroViewModel
    {
        public LibroViewModel()
        {

        }
        public LibroViewModel(Libro libro)
        {
            this.ISBN10 = libro.ISBN10;
            this.ISBN13 = libro.ISBN13;
            this.Titulo = libro.Titulo;
            this.Descripcion = libro.Descripcion;
            this.Paginas = libro.Paginas;
            this.Dimension = libro.Dimension;
            this.Peso = libro.Peso;
            this.Precio = libro.Precio;
            this.Imagen = libro.Imagen;
            this.NombreAutor = libro.Autor.Nombre;
            this.NombreEditorial = libro.Editorial.Nombre;
            this.NombreCategoria = libro.Categoria.Nombre;
        }

        public int Id { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Paginas { get; set; }
        public string Idioma { get; set; }
        public string Dimension { get; set; }
        public decimal Peso { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public string NombreAutor { get; set; }
        public string NombreEditorial { get; set; }
        public string NombreCategoria { get; set; }

    }
}
