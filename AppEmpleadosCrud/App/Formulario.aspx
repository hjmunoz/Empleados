<%@ Page Title="" Language="C#" MasterPageFile="~/App/Layout.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="AppEmpleadosCrud.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<h1 class="TextoH1"> crud basico a una tabla html</h1>
    <main class="EstiloMain">

    <div class="ContenedorApp">

        <div class="MenuApp">
            
            <div class="ContenedorBtnApp">
                
                <asp:Label ID="lblrespuesta" runat="server" Font-Bold="True"></asp:Label>
                </div>
                </div>
            <div class="ContenedorDatos">
        <!-- Inicio de contenedor datos-->
                
                <div Class="contenedortodoformulario">
                    <!-- Inicio formulario-->
                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="lblCodigo" runat="server" Text="Codigo"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InCodigo" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrorCodigo" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>

                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InNombre" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrorNombre" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>

                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InApellido" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrorApellido" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>

                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="Label2" runat="server" Text="Cargo"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InCargo" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrorCargo" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>

                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="Label4" runat="server" Text="Salario"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InSalario" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrorSalario" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>

                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="Label5" runat="server" Text="Area"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InArea" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrorArea" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>

                    <div class="contenedordatoform">

                        <div class="contenedorlabel">  <asp:Label ID="Label6" runat="server" Text="Ciudad"></asp:Label> </div>
                        <div class="contenedortext"> <asp:TextBox ID="InCiudad" runat="server"></asp:TextBox>  </div>
                        <div class="contenedorerror"> <asp:Label ID="ErrroCiudad" runat="server" Font-Size="Smaller" ForeColor="#0033CC" Text="!!"></asp:Label> </div>                                                                                 
                    </div>



                    <div class="ContenedorBtnApp"> 
                    <asp:Button ID="BtnAgregarEmpleado" runat="server" Text="Enviar Datos" Class="btnApp" OnClick="BtnAgregarEmpleado_Click" />
                    <!-- Fin formulario-->          
                    <asp:Button ID="btneditarempleado" runat="server" Text="Guardar Cambios" Class="btnApp" OnClick="btneditarempleado_Click"/>
                    <asp:Button ID="btnborrarempleado" runat="server" Text="Borrar Datos" Class="btnApp" OnClick="btnborrarempleado_Click" OnClientClick="result=confirm(&quot;Desea Borrar El Registro&quot;)"/>
                    </div>
                    


                </div>


             
               
                
               
        <!-- final de contenedor datos-->
            </div>

    </div>
        
    </main>
</asp:Content>
