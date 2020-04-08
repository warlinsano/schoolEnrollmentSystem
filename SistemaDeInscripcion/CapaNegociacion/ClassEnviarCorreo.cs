using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInscripcion.CapaNegociacion
{
    class ClassEnviarCorreo
    {
        //LE FALTAN VALIDACIONES
        //NO TIENE VALIDACION DE SI EL E-MAEIL EXISTE O NO....
        private string MiEmail = "the.warlin@hotmail.com";

        private string PassEmal = "*********";

        //public string ParaCorreoDestino { private get; set; }
        //public string TituloAsunto { private get; set; }
        //public string CuerpoMensaje { private get; set; }

        //----------------------------
        //var ParaCorreoDestino = "warlinsano@gmail.com";
        //var TituloAsunto = "Prueva Coreo de enviado C#";
        //var CuerpoMensaje = "Estoy Probando si Funciona el envio de email desde la app C#";
        //----------------------------

        public string EnviarMail(string ParaCorreoDestino, string TituloAsunto, string CuerpoMensaje)
        {
            string msj = "";
            try { 
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(MiEmail);
                //foreach (var item in collection)
                //{
                if (string.IsNullOrEmpty(ParaCorreoDestino.Trim()) )
                    {
                    return msj = "Falta Llenar el Email del Destinatario";
                    }
              else if  (string.IsNullOrEmpty(TituloAsunto.Trim()))
                    {
                        return msj = "Deve Llenar el Asunto del Email";
                    }
             else if (string.IsNullOrEmpty(CuerpoMensaje.Trim()))
                    {
                    return msj = "Deve Llenar el Mensaje del Email";
                    }
                else
                    {
                    message.To.Add(new MailAddress(ParaCorreoDestino));
                    }
                //}
                    message.Subject = TituloAsunto;
                    message.IsBodyHtml = true;
                    message.Body = CuerpoMensaje;
                    smtp.Port = 587;
                    smtp.Host = "smtp.live.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(MiEmail, PassEmal);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
            }
            catch (Exception ex)
            {
                return msj = "Error al Enviar el Email: "+ex.ToString();
            }
         return msj = "Se Envio el Correo";
        }

    }
}
