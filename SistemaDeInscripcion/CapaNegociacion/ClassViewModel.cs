using SistemaDeInscripcion.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInscripcion.CapaNegociacion
{

    // Aqui se Hacen las Validaciones de lugar en la clase ClassUserVieewModel antes de Registrar o guardar el user  
    // -- Es como si fuera la implemetacionde una interfas....
    public class ClassUserViewModel //: AspNetUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public string PhoneNumber { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }
    }

    public class CursosViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Estado { get; set; }
    }

    public  class EstudiantesViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }
   
        public DateTime Fecha_N { get; set; }

        public string Genero { get; set; }

        public string Email { get; set; }

        public string Estado { get; set; }
    }


}
