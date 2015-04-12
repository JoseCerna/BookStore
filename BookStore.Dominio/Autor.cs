namespace BookStore.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Autor")]
    public partial class Autor : EntityBase
    {
        public Autor()
        {
            Libro = new HashSet<Libro>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(160)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(160)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength(160)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [StringLength(800)]
        public string AcercaDe { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
