using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEmpleadosCrud.App
{
    public partial class Datos : System.Web.UI.Page
    {

        //crear nuestro objeto para gestionar  datos
        GestionDatos datos = new GestionDatos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Empleado> ListaEmpleados = datos.LeerTodos();
                GridView1.DataSource = ListaEmpleados;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Empleado> ListaEmpleados = datos.LeerTodos();
            GridView1.DataSource = ListaEmpleados;
            GridView1.DataBind();
        }

        protected void BtnListarTodo_Click(object sender, EventArgs e)
        {
            List<Empleado> ListaEmpleados = datos.LeerTodos();
            GridView1.DataSource = ListaEmpleados;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            List<Empleado> listaEmpleados = datos.LeerTodos();
            GridView1.DataSource = listaEmpleados;
            GridView1.DataBind();
        }

        protected void btnbuscarcodigo_Click(object sender, EventArgs e)
        {
            if (datos.ExisteEmpleado(InCodigoBuscar.Text))
            {
                Response.Redirect("Formulario.aspx?id=" + InCodigoBuscar.Text);
            }
            else
            {
                lblbuscar.Text = "No Existe El Codigo En La Base De Datos";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string valor = Convert.ToString(GridView1.DataKeys[index].Value);
                //Response.Write(" Valor De Fila " + index);
                //Response.Write(" Valor Celda " + valor);
                Response.Redirect("Formulario.aspx?id=" + valor);
            }
        }
    }
}