using System;
using BlazorCrudBooks.Data;
using BlazorCrudBooks.Modelos;

namespace BlazorCrudBooks.Repositorio
{
	public class Repositorio : IRepositorio
	{
        private readonly ApplicationDbContext _contexto;

        public Repositorio(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
        {
            var libroDesdeBd = await _contexto.Libro.FindAsync(libroId);
            libroDesdeBd.Tituto = actualizarLibro.Tituto;
            libroDesdeBd.Descripcion = actualizarLibro.Descripcion;
            libroDesdeBd.Autor = actualizarLibro.Autor;
            libroDesdeBd.Paginas = actualizarLibro.Paginas;
            libroDesdeBd.Precio = actualizarLibro.Precio;

            await _contexto.SaveChangesAsync();

            return libroDesdeBd;
        }

        public Task<Libro> CrearLibro(Libro crearLibro)
        {
            throw new NotImplementedException();
        }

        public Task<Libro> ElimianarLibro(int libroId)
        {
            throw new NotImplementedException();
        }

        public Task<Libro> GetLibroId(int libroId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Libro>> GetLibros()
        {
            throw new NotImplementedException();
        }
    }
}

