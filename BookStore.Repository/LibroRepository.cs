using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Dominio;

namespace BookStore.Repository
{
    public class LibroRepository : BaseRepository<Libro, BookStoreContext>
    {
        public LibroRepository(BookStoreContext context) :base(context)
        {
        }
    }
}
