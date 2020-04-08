namespace SistemaDeInscripcion.CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estudiantes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(40)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(11)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        //[DataType(DataType.DateTime)]
        [Column(TypeName = "date")]
        public DateTime Fecha_N { get; set; }

        [Required]
        [StringLength(1)]
        public string Genero { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
