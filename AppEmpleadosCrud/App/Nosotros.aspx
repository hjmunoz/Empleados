<%@ Page Title="" Language="C#" MasterPageFile="~/App/Layout.Master" AutoEventWireup="true" CodeBehind="Nosotros.aspx.cs" Inherits="AppEmpleadosCrud.App.Nosotros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="TextoH1"> Nuestro Equipo de Trabajo</h1>
    <main class="EstiloMain">
       
        <div class="ContenedorCards">
            <!--Inicio Cards-->
            <div class="cards">
                <div>
                    <img class="PicProgramador" src="pic/Programador-1.png" alt="">
                </div>
              <div>
                <p class="TextoResaltado"> Nombre </p>
                <p class="TextoNormal"> Hector Jefrey Muñoz Ortiz </p>
                <p class="TextoResaltado"> Correo </p>
                <p class="TextoNormal"> Hector.Jefrey@hotmail.com </p>
              </div>
            </div>
            <!--Final de cards-->
             
        </div>

    </main>

</asp:Content>
