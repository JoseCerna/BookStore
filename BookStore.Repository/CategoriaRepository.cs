using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Dominio;

namespace BookStore.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria, BookStoreContext>
    {
        public CategoriaRepository(BookStoreContext context) :base(context)
        {
        }
    }
}
