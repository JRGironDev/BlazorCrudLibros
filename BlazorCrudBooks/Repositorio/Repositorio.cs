using System;
using BlazorCrudBooks.Data;
using BlazorCrudBooks.Modelos;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Libro> CrearLibro(Libro crearLibro)
        {
            if (crearLibro != null)
            {
                crearLibro.FechaCreacion = DateTime.Now;
                await _contexto.Libro.AddAsync(crearLibro);
                await _contexto.SaveChangesAsync();
                return crearLibro;
            }
            else
            {
                return new Libro();
            }
        }

        public async Task ElimianarLibro(int libroId)
        {
            var libroDesdeBd = await _contexto.Libro.FindAsync(libroId);
            _contexto.Remove(libroDesdeBd);
            await _contexto.SaveChangesAsync();
            
        }

        public async Task<Libro> GetLibroId(int libroId)
        {
            var libroDesdeBd = await _contexto.Libro.FindAsync(libroId);
            if (libroDesdeBd == null)
            {
                return new Libro();
            }

            return libroDesdeBd;
        }

        public Task<List<Libro>> GetLibros()
        {
            return _contexto.Libro.ToListAsync();
        }
    }
}

