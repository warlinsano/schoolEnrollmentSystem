using SistemaDeInscripcion.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInscripcion.CapaNegociacion
{
    class LogicMantCursos
    {

       private ContextosDatosDB db = new ContextosDatosDB();

       public List<Cursos> ListarCursos()
        {
            return db.Cursos.ToList();
        }

        public List<Cursos> ListarCursosNombre(string NombreCurso)
        {
            List<Cursos> Lista = db.Cursos.Where(x => x.Nombre.Contains(NombreCurso)).ToList();
            return Lista;
        }

        public DataTable LlenarComboxDb()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(char));
            dt.Columns.Add("Display", typeof(String));
            dt.Rows.Add("H", "Habilitar");
            dt.Rows.Add("D", "Dehabilitar");
            return dt;
        }

        public string InsertarCursos(string NombreCurso, string Estado)
        {
            //quitar doble estapacios
            //c.Nombre = (NombreCurso.Trim()).ToUpper();
            NombreCurso = NombreCurso.ToUpper();
            string mensaje = string.Empty;
            if (string.IsNullOrEmpty(NombreCurso.Trim()))
            {
                mensaje = "Deve llenar el Nombre";
            }
            else if (Estado == "S")
            {
                mensaje = "Deve llenar Selecionar un Estado";
            }
            else if (CursosExistsByName(NombreCurso))
            {
                mensaje = "Ya Existe un Cursos con este Nombre.. Por Favor Elegir uno Distinto.";
            }
            else
            {
                try
                {
                    Cursos c = new Cursos();
                    c.Nombre= (NombreCurso.Trim()).ToUpper();
                    c.Estado = Estado;
                    db.Cursos.Add(c);
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

        public string EditarCursos(CursosViewModel Curso)
        {
            string mensaje = string.Empty;
            if (string.IsNullOrEmpty(Curso.Nombre.Trim()))
            {
                mensaje = "Deve llenar el campo Nombre";
            }
            else if (Curso.Estado == "S")
            {
                mensaje = "Deve llenar Selecionar un Estado";
            }
            else if (db.Cursos.Count(e =>e.Id!= Curso.Id && e.Nombre == Curso.Nombre ) > 0)
            {
                mensaje = "Ya Existe un Cursos con este Nombre.. Por Favor Elegir uno Distinto.";
            }
            else
            {
                //quitar doble estapacios
                Curso.Nombre = Curso.Nombre.ToUpper();
                //db.Entry(std).State = EntityState.Modified;
                try
                {
                    var std = db.Cursos.Where(s => s.Id == Curso.Id).FirstOrDefault<Cursos>();
                    std.Id = Curso.Id;
                    std.Nombre = Curso.Nombre;
                    std.Estado = Curso.Estado;
                    db.SaveChanges();
                    mensaje = "- Se Edito el Registro Correctamente...";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursosExistsByID(Curso.Id))
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

        private bool CursosExistsByName(string NombreCurso)
        {
            return db.Cursos.Count(e => e.Nombre == NombreCurso) > 0;
        }

        private bool CursosExistsByID(int Id)
        {
            return db.Cursos.Count(e => e.Id == Id) > 0;
        }
    }
}
