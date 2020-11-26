<%@ Page Title="" Language="C#" MasterPageFile="~/App/Layout.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="AppEmpleadosCrud.App.Datos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h1 class="TextoH1"> crud basico a una tabla html</h1>
    <main class="EstiloMain">

    <div class="ContenedorApp">

        <div class="MenuApp">
            
            <div class="ContenedorBtnApp">
               &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ListaEmpleados" Class="btnApp"/>
                </div>
                </div>
            <div class="ContenedorDatos">
            
                <div class="contenedorGrid">
                <asp:GridView CssClass="FormatoGV" ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
               </div>
        </div>

    </div>
        
    </main>

</asp:Content>
