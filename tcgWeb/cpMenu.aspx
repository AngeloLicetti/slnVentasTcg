<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="cpMenu.aspx.cs" Inherits="cpMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h2 style="text-align: center">
            Elija una opción del menú o pulse el botón salir si desea salir de la web
        </h2>
    </div>
    <div style="text-align: center">

        <asp:Button ID="btnSalir" runat="server" OnClick="btnSalir_Click" style="text-align: center" Text="Salir" />

    </div>

</asp:Content>

