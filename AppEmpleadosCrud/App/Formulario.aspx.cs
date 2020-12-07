using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEmpleadosCrud
{
    public partial class Formulario : System.Web.UI.Page
    {

        ValidacionCajas validar = new ValidacionCajas();
        GestionDatos datos = new GestionDatos();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    InCodigo.Text = Request.QueryString["id"];
                    Empleado MyEmpleado = datos.ConsultaEmpleado(InCodigo.Text);
                    InNombre.Text = MyEmpleado.Nombre;
                    InApellido.Text = MyEmpleado.Apellido;
                    InCargo.Text = MyEmpleado.Cargo;
                    InSalario.Text = MyEmpleado.Salario;
                    InArea.Text = MyEmpleado.Area;
                    InCiudad.Text = MyEmpleado.Ciudad;
                    BtnAgregarEmpleado.Visible = false;
                    btneditarempleado.Visible = true;
                    btnborrarempleado.Visible = true;
                    InCodigo.Enabled = false;
                }
                else
                {
                    InCodigo.Enabled = true;
                    BtnAgregarEmpleado.Visible = true;
                    btneditarempleado.Visible = false;
                    btnborrarempleado.Visible = false;
                    return;
                }
                

            }
        }

        protected void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //Enviar los datos
            if (!validar.Vacio(InCodigo, ErrorCodigo, "No puede ser vacio"))
            {
                if (!validar.Vacio(InNombre, ErrorNombre, "No puede ser vacio"))
                {
                    if (!validar.Vacio(InApellido, ErrorApellido, "No puede ser vacio"))
                    {
                        if (!validar.Vacio(InCargo, ErrorCargo, "No puede ser vacio"))
                        {
                            if (!validar.Vacio(InSalario, ErrorSalario, "No puede ser vacio"))
                            {
                                if (!validar.Vacio(InArea, ErrorArea, "No puede ser vacio"))
                                {
                                    if (!validar.Vacio(InCiudad, ErrroCiudad, "No puede ser vacio"))
                                    {
                                        insertarDatos();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void insertarDatos() 
        {
            Empleado MyEmpleado = new Empleado();
            MyEmpleado.Codigo = InCodigo.Text;
            MyEmpleado.Nombre = InNombre.Text;
            MyEmpleado.Apellido = InApellido.Text;
            MyEmpleado.Cargo = InCargo.Text;
            MyEmpleado.Salario = InSalario.Text;
            MyEmpleado.Area = InArea.Text;
            MyEmpleado.Ciudad = InCiudad.Text;

            if (!datos.ExisteEmpleado(InCodigo.Text))
            {
                if (datos.InsertarEmpleado(MyEmpleado))
                {
                    lblrespuesta.Text = "El Registro Fue Insertado Correctamente";

                }
                else
                {
                    lblrespuesta.Text = "Error Al Insertar" + datos.error;

                }
            }
            else
            {
                ErrorCodigo.Text = "El Codigo " + InCodigo.Text + " Ya Existe";

            }




        }

        private void LimpiarCampos()
        {
            InCodigo.Text = "";
            InNombre.Text = "";
            InApellido.Text = "";
            InCargo.Text = "";
            InSalario.Text = "";
            InArea.Text = "";
            InCiudad.Text = "";
        }

        protected void btneditarempleado_Click(object sender, EventArgs e)
        {
            //codigo para editar empleado
            Empleado MyEmpleado = new Empleado();
            MyEmpleado.Codigo = InCodigo.Text;
            MyEmpleado.Nombre = InNombre.Text;
            MyEmpleado.Apellido = InApellido.Text;
            MyEmpleado.Cargo = InCargo.Text;
            MyEmpleado.Salario = InSalario.Text;
            MyEmpleado.Area = InArea.Text;
            MyEmpleado.Ciudad = InCiudad.Text;
            if (datos.EditarEmpleado(MyEmpleado))
            {
                lblrespuesta.Text = "El Registro Fue Actualizado Correctamente";
            }
            else
            {
                lblrespuesta.Text = "Error Al Actualizar " + datos.error;
            }

        }

        protected void btnborrarempleado_Click(object sender, EventArgs e)
        {
            //Codigo para borra empleado
            if (datos.EliminarEmpleado(InCodigo.Text))
            {
                lblrespuesta.Text = "El Registro Fue Eliminado Correctamente";
                LimpiarCampos();
            }
            else
            {
                lblrespuesta.Text = "Error Al Eliminar " + datos.error;
            }
        }
    }
}