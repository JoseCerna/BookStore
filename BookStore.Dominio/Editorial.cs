namespace BookStore.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Editorial")]
    public partial class Editorial : EntityBase
    {
        public Editorial()
        {
            Libro = new HashSet<Libro>();
        }

        [Required]
        [StringLength(160)]
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
