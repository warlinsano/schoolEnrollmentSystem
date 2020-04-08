using SistemaDeInscripcion.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInscripcion.CapaNegociacion
{
    class LogicMantEstudiantes
    {

        private ContextosDatosDB db = new ContextosDatosDB();

        public List<Estudiantes> ListarEstudiantes()
        {
            return db.Estudiantes.ToList();
        }

        public List<Estudiantes> ListarEstudiantesNombre(string EstudiantesNombre)
        {
            List<Estudiantes> Lista = db.Estudiantes.Where(x => x.Nombre.Contains(EstudiantesNombre)).ToList();
            return Lista;
        }

        public DataTable LlenarComboxDb()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(char));
            dt.Columns.Add("Display", typeof(String));
            dt.Rows.Add("H", "ACTIVO");
            dt.Rows.Add("D", "SUSPENDIDO");
            return dt;
        }

        public string Model_Es_Valido(EstudiantesViewModel Estudiante)
        {
            string mensaje = string.Empty;
            if (string.IsNullOrEmpty(Estudiante.Nombre.Trim()))
            {
                mensaje = "Deve llenar el Nombre";
            }
            else if (string.IsNullOrEmpty(Estudiante.Apellido.Trim()))
            {
                mensaje = "Deve llenar el Apellido";
            }
            else if (!(ValidacionUtil.ValidadCedula(Estudiante.Cedula, out mensaje)))
            {
                //mensaje = mensaje;
            }
            //else if(EstudiantesExistsByCedula(Estudiante.Cedula))
            //{
            //    mensaje = "Ya existe un registro de estudiante asociado a esta cedula";
            //}
            else if (db.Estudiantes.Count(e => e.Id != Estudiante.Id && e.Cedula == Estudiante.Cedula) > 0)
            {
                mensaje = "Ya existe un registro de estudiante asociado a esta cedula";
            }
            else if (!(ValidacionUtil.ValidadCedula(Estudiante.Cedula, out mensaje)))
            {
                //mensaje = mensaje;
            }
            else if (string.IsNullOrEmpty(Estudiante.Telefono.Trim()) || Estudiante.Telefono.Length < 10)
            {
                mensaje = "Deve Completar el Telefono";
            }
            else if (string.IsNullOrEmpty(Estudiante.Fecha_N.ToString()))
            {
                mensaje = "Deve Completar el campo Fecha de Nacimiento";
            }
            //ValidacionUtil.ValidadFecha(Estudiante.Fecha_N.ToString()) &&
            else if (!ValidacionUtil.validarFechaNacimiento(Estudiante.Fecha_N.ToString(), out mensaje))
            {
                mensaje = "Error de Fecha de Nacimiento, verifique que la persona sea mayor de Edad o la fecha tenga el formato correcto.";
            }
            else if (string.IsNullOrEmpty(Estudiante.Genero))
            {
                mensaje = "Deve seleccionar un Genero";
            }
            else if (string.IsNullOrEmpty(Estudiante.Email.Trim()))
            {
                mensaje = "Deve Completar el campo Email";
            }
            else if (!ValidacionUtil.MailIsValid(Estudiante.Email.Trim()))
            {
                mensaje = "Email no es valido";
            }
            else if (Estudiante.Estado == "S" || string.IsNullOrEmpty(Estudiante.Estado.Trim()))
            {
                mensaje = "Deve llenar Selecionar un Estado";
            }
            else
            {
                mensaje = string.Empty;
            }
            return mensaje;
        }

        public string InsertarEstudiantes(EstudiantesViewModel Estudiante)
        {
            //quitar doble estapacios
            Estudiante.Nombre = Estudiante.Nombre.ToUpper();
            string mensaje = Model_Es_Valido(Estudiante);
            if (string.IsNullOrEmpty(mensaje.Trim()))
            {
                try
                {
                    Estudiantes Est = new Estudiantes();
                    //Est.Id = Estudiante.Id;
                    Est.Nombre = (Estudiante.Nombre.Trim()).ToUpper();
                    Est.Apellido = Estudiante.Apellido.Trim().ToUpper();
                    Est.Cedula = Estudiante.Cedula;
                    Est.Telefono = Estudiante.Telefono;
                    Est.Fecha_N =  Estudiante.Fecha_N;   // date...
                    Est.Genero = Estudiante.Genero;
                    //std.Genero = Estudiante.Genero;
                    Est.Email = Estudiante.Email.Trim();
                    Est.Estado = Estudiante.Estado;

                    db.Estudiantes.Add(Est);
                    db.SaveChanges();
                    mensaje = "- Se inserto correctamete el Curso";
                }
                catch (Exception)
                {
                    mensaje = "ERROR DE SERVER: A ocurrido un error al insertar el Curso, por favor contactar con soporte Tecnico del sistema..";
                    throw;
                }
            }
            return mensaje;
        }

        public string EditarEstudiantes(EstudiantesViewModel Estudiante)
        {
            //quitar doble estapacios
            Estudiante.Nombre = Estudiante.Nombre.ToUpper();
            string mensaje = Model_Es_Valido(Estudiante);
            if (string.IsNullOrEmpty(mensaje.Trim()))
            {
                //db.Entry(std).State = EntityState.Modified;
                try
                {
                    var std = db.Estudiantes.Where(s => s.Id == Estudiante.Id).FirstOrDefault<Estudiantes>();
                    std.Id = Estudiante.Id;
                    std.Nombre = Estudiante.Nombre.Trim().ToUpper();
                    std.Apellido = Estudiante.Apellido.Trim().ToUpper();
                    std.Cedula = Estudiante.Cedula;
                    std.Telefono = Estudiante.Telefono;
                    std.Genero = Estudiante.Genero;

                    std.Fecha_N =  Estudiante.Fecha_N;   // date...
                    //std.Genero = "M";
                    //std.Genero = Estudiante.Genero;
                    std.Email = Estudiante.Email.Trim();
                    std.Estado = Estudiante.Estado;
                    db.SaveChanges();
                    mensaje = "- Se Edito el Registro Correctamente...";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudiantesExistsByID(Estudiante.Id))
                    {
                        mensaje = "No Existe Registro Relacionado con este Id  verfique que no Halla sido Eliminado...";
                    }
                    else
                    {
                        mensaje = "A ocurrido un Error al editar el Registro";
                        throw;
                    }
                }
            }
            // return StatusCode(HttpStatusCode.NoContent);
            return mensaje;
        }

        private bool EstudiantesExistsByCedula(string Cedula)
        {
            return db.Estudiantes.Count(e => e.Cedula == Cedula) > 0;
        }

        private bool EstudiantesExistsByID(int Id)
        {
            return db.Estudiantes.Count(e => e.Id == Id) > 0;
        }


    }
}
