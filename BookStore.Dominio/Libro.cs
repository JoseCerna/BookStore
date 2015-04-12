namespace BookStore.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libro")]
    public partial class Libro : EntityBase
    {
        [Required]
        [StringLength(10)]
        public string ISBN10 { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN13 { get; set; }

        [Required]
        [StringLength(160)]
        public string Titulo { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public int Paginas { get; set; }

        [Required]
        [StringLength(160)]
        public string Idioma { get; set; }

        [Required]
        [StringLength(160)]
        public string Dimension { get; set; }

        public decimal Peso { get; set; }

        public decimal Precio { get; set; }

        [Required]
        [StringLength(300)]
        public string Imagen { get; set; }

        public int AutorId { get; set; }

        public int CategoriaId { get; set; }

        public int EditorialId { get; set; }

        public virtual Autor Autor { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Editorial Editorial { get; set; }
    }
}
