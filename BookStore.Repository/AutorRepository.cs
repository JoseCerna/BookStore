using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Dominio;

namespace BookStore.Repository
{
    public class AutorRepository : BaseRepository<Autor, BookStoreContext>
    {
        public AutorRepository(BookStoreContext context) :base(context)
        {
        }
    }
}
