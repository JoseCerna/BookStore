using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Dominio;
using BookStore.Repository;
using BookStore.Common.ViewModels;

namespace BookStore.Services
{
    public class LibroService : IDisposable
    {
        private IRepository<Libro> _libroRepository;
        private IRepository<Editorial> _editorialRepository;
        private IRepository<Autor> _autorRepository;
        private IRepository<Categoria> _categoriaRepository;

        public LibroService(IRepository<Libro> libroRepository, IRepository<Editorial> editorialRepository, IRepository<Autor> autorRepository, IRepository<Categoria> categoryRepository)
        {
            this._libroRepository = libroRepository;
            this._editorialRepository = editorialRepository;
            this._autorRepository = autorRepository;
            this._categoriaRepository = categoryRepository;
        }

        //public IEnumerable<Libro Get(int playlistId)
        //{
        //    var playList = _playListRepository.Get().FirstOrDefault(x => x.Id == playlistId);
        //    if (playList == null) throw new InvalidOperationException("Playlist no encontrado");
        //    return new PlaylistEditViewModel() { Name = playList.Name, Id = playList.Id, CustomerId = playList.CustomerId, Tracks = playList.Track.Select(track => new TracksListViewModel(track, playList.Id)).ToList() };
        //}

        public IEnumerable<LibroViewModel> Get()
        {
            var books = _libroRepository.Get().ToList();
            if (books == null) throw new InvalidOperationException("Libro no encontrado");
            return books.Select(book => new LibroViewModel(book)).ToList();
        }


        public IEnumerable<LibroViewModel> GetBook(string sBook)
        {
            var books = _libroRepository.Get().Where(x => x.Titulo.Contains(sBook)).ToList();
            if (books == null) throw new InvalidOperationException("Libro no encontrado");
            return books.Select(book => new LibroViewModel(book)).ToList();
        }

        public void Dispose()
        {
            _libroRepository = null;
        }

    }
}
