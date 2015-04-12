namespace BookStore.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categoria")]
    public partial class Categoria : EntityBase
    {
        public Categoria()
        {
            Libro = new HashSet<Libro>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(160)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(300)]
        public string Descripcion { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
