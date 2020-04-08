namespace SistemaDeInscripcion.CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre_Usuario { get; set; }

        [Required]
        [StringLength(40)]
        public string Pwd { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
