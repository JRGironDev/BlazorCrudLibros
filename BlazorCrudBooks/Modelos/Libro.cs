using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrudBooks.Modelos
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El título es obligatorio")]
        public string Tituto { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "La cantidad de páginas es obligatoria")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        public int Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

