using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInscripcion.CapaNegociacion
{
    public partial class ClassErrorOConfirmacion : ClassUserViewModel
    {
       // public int ValorInt { get; set; }

        public bool EstadoConfirmacion { get; set; }

        public string Titulo { get; set; }

        public string MensajeError { get; set; }      

        public string TipoErrorOConfirmacion { get; set; }

        //public string[] Valores { get; set; }

        //se puede usar el "string[] Valores" para pasar datos del user por eso no utlise esta propiedad en el metodo login de la CapaNegociacion...
        //public  ClassUserViewModel UserViewModel{get; set;}

        //public ClassUserViewModel F_UserViewModel()
        //{
        //    return UserViewModel;
        //}

    }

}
