using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading.Tasks;


namespace SistemaDeInscripcion.CapaNegociacion
{
    class ValidacionUtil
    {

        public static bool ValidadCedula(string Cedula, out string mensaje)
        {
            mensaje = string.Empty;
            if (string.IsNullOrEmpty(Cedula.Trim()))
            {
                mensaje = "Debe de escribir La Cedula";
                return false;
            }

            if (!EsNumero(Cedula))
            {
                mensaje = "La Cedula solo debe de contener numeros";
                return false;
            }

            if (Cedula.Length != 11)
            {
                mensaje = "La Cedula debe tener 11 digitos";
                return false;
            }
            int[] Por = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            char[] Valores = Cedula.ToCharArray();
            int[] sequence = Valores.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            char[] Resultado;
            Cedula = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                Cedula += ((Por[i] * sequence[i]).ToString()); ;
            }
            Resultado = Cedula.ToCharArray();
            int suma = 0;
            for (int i = 0; i < Resultado.Length; i++)
            {
                suma += int.Parse(Resultado[i].ToString());
            }

            int unidad = int.Parse(suma.ToString().Remove(0, 1));
            int restante = unidad == 0 ? 0 : 10 - unidad;
            if (((suma + restante) - suma) == sequence[10])
            //if ((suma + int.Parse(Valores[10].ToString())) % 2 == 0)
            {
                return true;
            }
            else
            {
                mensaje = "La Cedula es Invalida";
                return false;
            }
        }

        //ref -- por refencia
        public static String Quitar_EspaciosDoblesDobles(string s)
        {
            if (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
                Quitar_EspaciosDoblesDobles(s);
            }
            return s;
        }

        public static String Quitar_TdodosEspacios(string s)
        {
            if (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
                Quitar_TdodosEspacios(s);
            }
            return s;
        }

        public static bool EsNumero(string Cadena)
        {
            long valor;
            if (long.TryParse(Cadena, out valor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EsLetras(string Cadena)
        {
            bool respuesta = true;
            for (int x = 0; x < Cadena.Length; x++)
            {
                if (Cadena[x] >= '0' && Cadena[x] <= '9')
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public static string RemplazarLetras(string Cadena)
        {
            string respuesta = string.Empty;
            for (int x = 0; x < Cadena.Length; x++)
            {
                if (Cadena[x] >= '0' && Cadena[x] <= '9')
                {
                }
                else
                {
                    respuesta = Cadena.Replace(Cadena[x].ToString(), "");
                }
            }
            return respuesta;
        }

        public static string RemplazarNumeros(string Cadena)
        {
            string respuesta = string.Empty;
            for (int x = 0; x < Cadena.Length; x++)
            {
                if (Cadena[x] >= '0' && Cadena[x] <= '9')
                {
                    respuesta = Cadena.Replace(Cadena[x].ToString(), "");
                }
            }
            return respuesta;
        }

        public static void EscribirSoloLetras(KeyPressEventArgs e)
        {
            try
            {

                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        public static void EscribirSinEspacios(KeyPressEventArgs e)
        {
            try
            {
              
                if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        public static void EscribirSoloNumero(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            catch (Exception ex)
            {
            }
        }

        //Validacion de doble espacios
        public static string QuitarEspaciosDoble(string cadena)
        {
            cadena.Trim();
            if (cadena.Contains("  "))
            {
                cadena = cadena.Replace("  ", " ");
                cadena = QuitarEspaciosDoble(cadena);
            }
            return cadena;
        }

        //--Metodo de limpiar todos los controles de entradas de un panel
        public static void limpiar2(Panel p)
        {
            foreach (var c in p.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = 0;
                }
            }
        }

        //Validacion de Cedula
        public static bool Validacion(TextBox txtCedula)
        {
            bool a = false;
            //                
            string Cedula, tmp;
            int temporal;
            int n = 0;
            int ultimo = 0;
            Cedula = txtCedula.Text;

            if (Cedula.Length < 11)
            {
                //Mensaje("cantidad de numeros en La Cedula invalidad... *_*");
            }
            else
            {
                ultimo = Convert.ToInt32(Cedula[10].ToString());
                for (int conteo = 0; conteo <= Cedula.Length - 2; conteo++)
                {
                    if ((conteo % 2) == 0)
                    {   // es par  
                        temporal = Convert.ToInt32(Cedula[conteo].ToString()) * 1;
                    }
                    else
                    { // es impar                           
                        temporal = Convert.ToInt32(Cedula[conteo].ToString()) * 2;
                    }
                    for (int c = 0; c <= temporal.ToString().Length - 1; c++)
                    {  //suma
                        tmp = temporal.ToString();
                        n = n + Convert.ToInt32(tmp[c].ToString());
                    }
                }
                tmp = n.ToString();
                if (tmp[1].ToString() == "0")
                {
                    Cedula = Convert.ToString(Convert.ToInt32(tmp[0].ToString()) * 10);
                }
                else
                {
                    Cedula = Convert.ToString((Convert.ToInt32(tmp[0].ToString()) + 1) * 10);
                }
                tmp = "";
                Cedula = (Convert.ToInt32(Cedula + tmp)).ToString();
                Cedula = (Convert.ToInt32(Cedula) - n).ToString();
                if ((Convert.ToInt32(Cedula)) == (Convert.ToInt32(ultimo)))
                {
                    a = true;
                    //Mensaje("Cedula Validad *_*");                                 
                }
                else
                {
                    a = false;
                    //Mensaje("'La  Cedula  es invalidad 0_0");
                }
            }
            //    
            return a;
        }

        //Validacion si la cedula existe 
        /*
        public bool CedulaExisteEnDB(string cedula = "")
        {
        //if (CedulaExisteEnDB(Validacion(txt_cedula)) == true) { }
        DataTable Dt_cedula = new DataTable();
        Dt_cedula = c.select("SELECT * FROM Cedulados WHERE Cedula='" + cedula + "' ");
        if (Dt_cedula.Rows.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        }
        */

        //validar Fecha Nacimiento         //validar si no es una fecha......... con EXPRECIONES REGULARES
        public static bool validarFechaNacimiento(string fecha, out string mensaje)
        {
            //bool retorno = true;
            int dia_N = 0, mes_N = 0, anio_N = 0;
            int dia_A = 0, mes_A = 0, anio_A = 0;
            DateTime fecha_N = new DateTime();
            DateTime fecha_Actual = DateTime.Now;
            fecha_N = DateTime.Parse(fecha);
            // Mensaje(DateTime.Now.ToString());                                 //fecha_N = DateTime.Parse((String.Format("{0:dd/MM/yyyy }", DateTime.Parse(fecha)))); 
            //Mensaje(String.Format("{0:MM/dd/yyyy}", DateTime.Parse(fecha)));    String.Format("{0:yyyy/MM/dd HH:mm:ss}", System.DateTime.Now);                              
            if (fecha_N > fecha_Actual)
            {
                mensaje = " Esta persona no ha nacido aun o la fecha de su pc esta mal..";
                return false;
            }
            else if (fecha_N.ToString("dd/MM/yyyy") == fecha_Actual.ToString("dd/MM/yyyy"))
            {
                mensaje = " Esta persona  nacido hoy o la fecha de su pc esta mal..";
                return false;
            }
            else
            {
                dia_N = Convert.ToInt32(fecha_N.Date.Day);
                mes_N = Convert.ToInt32(fecha_N.Date.Month);
                anio_N = Convert.ToInt32(fecha_N.Date.Year);
                //---------------------
                dia_A = Convert.ToInt32(fecha_Actual.Date.Day);
                mes_A = Convert.ToInt32(fecha_Actual.Date.Month);
                anio_A = Convert.ToInt32(fecha_Actual.Date.Year);
                //---------------------
                mes_A = mes_N - mes_A;
                anio_A = anio_N - anio_A;
                
                #region ParaVerficarTuEdad
                if (mes_A == 0)
                {
                    if (dia_A == dia_N)
                    {
                        mensaje = "Felicidades cumples años hoy y tu edad es: " + anio_A.ToString() + " años";
                        return (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
                    }
                    else if (dia_A < dia_N)
                    {
                        anio_A = anio_A + 1;
                        dia_A = (dia_N - dia_A);
                        mensaje = "Tu edad actual es: " + anio_A.ToString() + "   y te faltan: " + dia_A.ToString() + " dias para cumplir años";
                        return (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
                    }
                    else
                    {
                        dia_A = (dia_A - dia_N);
                        mensaje = "Tu edad actual es: " + anio_A.ToString() + " años.. y cumplites años hace:  " + dia_A.ToString() + "  Dias";
                        return (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
                    }
                }
                else
                {
                    if (mes_A < 0)
                    {
                        mensaje = "TU EDAD ES: " + anio_A.ToString() + "  años y ya cumpliste años este año.. ";
                        return (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
                    }
                    else
                    {
                        mensaje = "TU EDAD ES: " + anio_A.ToString() + "  años y no has cumplido años este año.. ";
                        anio_A = anio_A + 1;
                        return (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
                    }
                }
                #endregion
            }
            //retorno = (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
            //mensaje = "";
            //return (int.Parse(anio_A.ToString()) * (-1)) >= 18 ? true : false;
        }
        //-----------

        //validar Fecha Sea Mayor a fecha actual
        public static bool validarFechaMayorActual(string fecha)
        {
            DateTime fecha_N = new DateTime();
            DateTime fecha_Actual = DateTime.Now;
            fecha_N = Convert.ToDateTime(fecha);  //validar si no es una fecha.........
            //fecha_N = DateTime.TryParse(fecha, out DateTime r);
            if (fecha_N > fecha_Actual)
            {
                return true;
                //Mensaje("No valido........");
            }
            else if (fecha_N.ToString("dd/MM/yyyy") == fecha_Actual.ToString("dd/MM/yyyy"))
            {
                return true;
                //Mensaje("No valido........");
            }
            else
            {
                return false;
                //Mensaje("-----Valido----.");
            }
        }

        //------------validador de fechas...
        public static bool ValidadFecha(string fechaRecibida) 
        {
        var date1 = fechaRecibida;
        var date2 = "23/06/1997";

        DateTime dt1 = DateTime.Now;
        DateTime dt2 = dt1;

        var culture = CultureInfo.CreateSpecificCulture("es-MX");
        var styles = DateTimeStyles.None;

        bool fechaValida = DateTime.TryParse(date1, culture, styles, out dt1)
                           && DateTime.TryParse(date2, culture, styles, out dt2);
        //Console.WriteLine(dt1 >= dt2);
        //Console.WriteLine("date1: " + dt1.ToString());
        //Console.WriteLine("date2: " + dt2.ToString());
        //Console.WriteLine("date1---: " + date1.ToString());
        //Console.WriteLine("date2---: " + date2.ToString());
        if (!fechaValida)
        {
            //Console.WriteLine("Error en la fecha");
            fechaValida = true;
        }
        else
        {
            fechaValida = false;
        }
        return fechaValida;
        }

        public static bool MailIsValid_1(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool MailIsValid(string strEmail)
        {
            Regex validateEmail = new Regex("^[\\W]*([\\w+\\-.%]+@[\\w\\-.]+\\.[A-Za-z] {2,4}[\\W]*,{1}[\\W]*)*([\\w+\\-.%]+@[\\w\\-.]+\\.[A-Za-z]{2,4})[\\W]*$");
            return validateEmail.IsMatch(strEmail);
        }

    }

}
