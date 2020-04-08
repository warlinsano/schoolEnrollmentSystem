using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using SistemaDeInscripcion.CapaDatos;
using SistemaDeInscripcion.CapaPresentacion;

namespace SistemaDeInscripcion.CapaNegociacion
{
    class ClassLogin
    {
        //conexion a la Db
        private ContextosDatosDB db = new ContextosDatosDB();
        
         ClassErrorOConfirmacion Obj_ErrorOConfirmacion = new ClassErrorOConfirmacion();

        //pendiente
        //metodo de Registrarse - logger Register
        public ClassErrorOConfirmacion Register(string usuario, string contrasena)
        {
            // Es nesesario un ViewModel en la capa Negosiacion ClassUserVieewModel 

            //LLEVA UN REGISTROS O CONTROL  CONTROLA TODAS LAS ACCIONES QUE HACE EL USUARIO ....LOG A NIVEL DE DB
            try
            {

            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
            return Obj_ErrorOConfirmacion;
        }

        //metodo de Entrar - login
        public ClassErrorOConfirmacion Login(string usuario, string contrasena)
        {
            //LLEVA UN REGISTROS O CONTROL  CONTROLA TODAS LAS ACCIONES QUE HACE EL USUARIO ....LOG A NIVEL DE DB
            //Numeros de intentos de Iniccios de seccion proccedimentos que bloque el usuario...
            
           // var user1 = db.AspNetUsers.Where(u => u.UserName == usuario && u.PasswordHash == contrasena).Select(us => new { us.Id, us.NormalizedUserName }).FirstOrDefault();
           // var roles = db.AspNetUserRoles.Where(x => x.UserId == user1.Id).Select(x => x.AspNetRole.NormalizedName).ToList();

            try
            {
                var user = db.AspNetUsers.Where(u => u.UserName == usuario && u.PasswordHash == contrasena).Select(us => new { us.Id, us.NormalizedUserName, us.Email, us.EmailConfirmed, us.LockoutEnabled, us.AccessFailedCount }).FirstOrDefault();
                //lleno el obj para pasarselo a la capa de presentacion...form Login o PantallaPrincipal

                if (user!=null)
                {
                    if (user.EmailConfirmed != true)
                    {
                        Obj_ErrorOConfirmacion.EstadoConfirmacion = false;
                        Obj_ErrorOConfirmacion.Titulo = "VERRIFIQUE SU EMAIL";
                        Obj_ErrorOConfirmacion.MensajeError = "El proceso de Registro no a terminado hemos enviado un mesaje de verficiacion deve entrar a su" +
                            " Email: "+user.Email+" para verficar que este le pertenece y  poder acceder al sistema";
                        Obj_ErrorOConfirmacion.TipoErrorOConfirmacion = "Msj_Emergente_Info";
                        return Obj_ErrorOConfirmacion;
                    }

                    if (user.LockoutEnabled == true && user.AccessFailedCount < 3)
                     {
                       Obj_ErrorOConfirmacion.EstadoConfirmacion = false;
                       Obj_ErrorOConfirmacion.Titulo = "USUARIO BLOQUEADO POR  ADMINISTRACION";
                       Obj_ErrorOConfirmacion.MensajeError = "El usuario: " + usuario + " se encuentra temporalmente bloqueado por favor contacte con  soporte tecncio del sistema o su superior";
                       Obj_ErrorOConfirmacion.TipoErrorOConfirmacion = "Msj_Emergente_Info";
                       return Obj_ErrorOConfirmacion;
                     }

                    if (user.LockoutEnabled == false && user.AccessFailedCount >= 3)
                    {
                        Obj_ErrorOConfirmacion.EstadoConfirmacion = false;
                        Obj_ErrorOConfirmacion.Titulo = "USUARIO BLOQUEADO POR NUMEROS DE INTENTOS";
                        Obj_ErrorOConfirmacion.MensajeError = "El usuario: " + usuario + " se encuentra temporalmente bloqueado hemos enviado un correo para desbloquarlo verifiquelo por favor, si ya no tiene acceso al correo contacte con  soporte tecncio del sistema o su superior";
                        Obj_ErrorOConfirmacion.TipoErrorOConfirmacion = "Msj_Emergente_Info";
                        return Obj_ErrorOConfirmacion;
                    }

                    //pendiente
                    //if (user.Estado == "V"){  // Usuario de vacasiones.....}
                    //if (user.Estado == "L"){  // Usuario de Licencia.....}
                    //if (user.Estado == "S"){  // Usuario de Licencia.....}
                    //Etc...

                    //login correcto si llega aki sin retornar return es por que el usuario puede entrar...
                    Obj_ErrorOConfirmacion.EstadoConfirmacion = true;
                    Obj_ErrorOConfirmacion.MensajeError = string.Empty;
                    Obj_ErrorOConfirmacion.Id= user.Id;
                    Obj_ErrorOConfirmacion.UserName = usuario;
                    Obj_ErrorOConfirmacion.NormalizedUserName = user.NormalizedUserName;
                    Obj_ErrorOConfirmacion.Email = user.Email;
                    //-----UserSystemLog(string usuarioId, string accion)
                    //-----Enviar correo
                    return Obj_ErrorOConfirmacion;
                }
                else
                    {
                    var userByid = db.AspNetUsers.Where(u => u.UserName == usuario).Select(us => new { us.Id, us.NormalizedUserName, us.Email, us.EmailConfirmed, us.LockoutEnabled, us.AccessFailedCount }).FirstOrDefault();
                    //pendiente         -Numeros de Intentos...-Numeros de Intentos...Enviar correo.
                    if (userByid != null)
                    {
                        //Interto en la BD en tabla AspNetUser el campo AccessFailedCount le sumo uno(+1) y en base de datos creo  un trigger para el insert de esta tabla
                        //que si el campo AccessFailedCount es igual a 3 que me camabie el valor de el campo LockoutEnabled a true osea que me bloquee el usuario por instentos fallidos.
                        //UserSystemLog(string usuario,string Evento, string accion
                        //-----UserSystemLog(string usuarioId, string accion)
                    }

                    //Usuario o clave incorreta usuario desavilitado, bloqueado por intentos fallidos, bacasiones, etc.....
                    Obj_ErrorOConfirmacion.EstadoConfirmacion = false;
                    Obj_ErrorOConfirmacion.MensajeError = "Usuario y/o Contraseña incorrectos...";
                    Obj_ErrorOConfirmacion.TipoErrorOConfirmacion = "Msj_Lavel";
                    return Obj_ErrorOConfirmacion;
                    }
            }
            catch (Exception ex)
            {
                //pendiente
                //se puede captuar la Exception y mandar un msj mas bonito al usuario pero eso se arria despues...
                Obj_ErrorOConfirmacion.EstadoConfirmacion = false;
                Obj_ErrorOConfirmacion.Titulo = "ERROR DE DB O SERVER";
                Obj_ErrorOConfirmacion.TipoErrorOConfirmacion = "Msj_Emergente_Error";
                Obj_ErrorOConfirmacion.MensajeError = ex.ToString();
                return Obj_ErrorOConfirmacion;
            }
            //finally
            //{

            //}
        }

        //pendiente
        //metodo de Cerrar Seccion - log off
        public ClassErrorOConfirmacion LogOff(string usuario, string contrasena)
        {
            //LLEVA UN REGISTROS O CONTROL  CONTROLA TODAS LAS ACCIONES QUE HACE EL USUARIO ....LOG A NIVEL DE DB
            try
            {

            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
            return Obj_ErrorOConfirmacion;
        }

        //pendiente
        //metodo de Control o historia de Acciones de usuarios - Log del sistama 
        public ClassErrorOConfirmacion UserSystemLog(string usuarioId,string Evento, string accion)
        {

            //LLEVA UN REGISTROS O CONTROL  CONTROLA TODAS LAS ACCIONES QUE HACE EL USUARIO ....LOG A NIVEL DE DB
            //logica de este metodo (id="jdjdjjdjddjdj", eneveto="Update", accion="Publico nota a idAlumno 3333333") 
            //la fecha sera otro campo a en la base de datos que se pondra a insertar un registro en la tabla log
            var user = db.AspNetUsers.Where(u => u.Id == usuarioId).Select(us => new { us.Id, us.NormalizedUserName }).FirstOrDefault();
            var roles = db.AspNetUserRoles.Where(x => x.UserId == user.Id).Select(x => x.AspNetRole.NormalizedName).ToList();
            try
            {

            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
            return Obj_ErrorOConfirmacion;

            #region RevisarMasTarde
            //                    if (roles.Contains("Admin"))
            //                    {
            //                        // new useradmin_form2().Show objeto para llamar el formulario
            //                        //dt.Rows[0][0].ToString() consulata la posicion del nombre en la consulta sql y la covierte a string para enviar los paramatros del nombre al form "useradmin_form2" y al mismo tiempo lo abre .show..
            //                        new PantallaPrincipal(user.Id, user.NormalizedUserName).Show();
            //        //INICIO SECCION CONTROL
            //    }
            //                    else if (roles.Contains("Normal"))
            //                    {
            //                        new PantallaPrincipal(user.Id, user.NormalizedUserName).Show();
            //    //INICIO SECCION CONTROL
            //}
            #endregion

        }

        //pendiente
        //metodo de Verficar Acceso por Roles -  List Access Control by Rols
        public ClassErrorOConfirmacion ListAccessControlbyRols(string usuario, string contrasena)
        {
            //LLEVA UN REGISTROS O CONTROL  CONTROLA TODAS LAS ACCIONES QUE HACE EL USUARIO ....LOG A NIVEL DE DB
            try
            {

            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
            return Obj_ErrorOConfirmacion;
        }

    }

    }
