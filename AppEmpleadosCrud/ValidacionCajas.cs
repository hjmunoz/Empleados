using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace AppEmpleadosCrud
{
    public class ValidacionCajas
    {
        /*-------------------Metodos Validaciones-----------------------------*/
        public Boolean Vacio(TextBox Datos, Label error, string MensajeError)
        {
            //------------------validar vacio
            if (Datos.Text == "")
            {
                error.Text = MensajeError;
                Datos.Focus();
                return true;
            }
            else
            {
                error.Text = "";
                return false;
            }
        }
        /*---------------------------------------------------------------------*/

        public Boolean TipoNumero(TextBox caja, Label error, string MensajeError)
        {

            Regex formatotexto = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
            {

                if (!formatotexto.IsMatch(caja.Text))
                {
                    error.Text = MensajeError;
                    caja.Focus();
                    return false;
                }
                else
                {
                    error.Text = "";
                    return true;
                }

            }

        }

        public Boolean TipoTexto(TextBox caja, Label error, string MensajeError)
        {
            Regex Formato = new Regex("[a-zA-ZñÑ\\s]{2,50}");
            if (!Formato.IsMatch(caja.Text))
            {
                error.Text = MensajeError;
                caja.Focus();
                return false;
            }
            else
            {
                error.Text = "";
                return true;
            }
        }

        public Boolean TipoCorreo(TextBox caja, Label error, string MensajeError)
        {
            Regex FormatoCorreo = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

            if (!FormatoCorreo.IsMatch(caja.Text))
            {
                error.Text = MensajeError;
                caja.Focus();
                return false;
            }
            else
            {
                error.Text = "";
                return true;
            }
        }
    }
}