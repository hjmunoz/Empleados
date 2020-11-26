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
    }
}