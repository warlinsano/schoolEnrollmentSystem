using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInscripcion.CapaDatos
{
    public class ContextosDatosDB : DbContext
    { 
        public ContextosDatosDB() : base("CadenaDeConexion")
        {

        }

        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }

        //Tablas de la DB
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<EstudianteCursos> EstudianteCursos { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
 
        //ClassAccount
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }


    }
}
