namespace SistemaDeInscripcion.CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EstudianteCursos
    {
        public int Id { get; set; }

        public int IdEstudiante { get; set; }

        public int IdCurso { get; set; }

        public int? Nota { get; set; }
    }
}
