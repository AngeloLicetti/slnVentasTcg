<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wmTrabajadorAct.aspx.cs" Inherits="wmTrabajadorAct" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<body>
    <mobile:Form id="fmPrincipal" runat="server">
        <mobile:Label ID="Label1" Runat="server">SISTEMA DE VENTAS TCG</mobile:Label>
        <br />
        <mobile:Label ID="Label2" Runat="server">ACTUALIZAR TRABAJADOR</mobile:Label>
        <br />
        <mobile:Label ID="Label3" Runat="server">Codigo: </mobile:Label>
        <mobile:TextBox ID="txtCodigo" Runat="server"></mobile:TextBox>
        <mobile:Panel ID="divOcultar" Runat="server" Visible="false">
            <mobile:Label ID="lblCod" Runat="server"> </mobile:Label>
            <mobile:Label ID="Label4" Runat="server">Apellidos: </mobile:Label>
            <mobile:TextBox ID="txtApellidos" Runat="server"></mobile:TextBox>
            <mobile:Label ID="Label5" Runat="server">Nombres: </mobile:Label>
            <mobile:TextBox ID="txtNombres" Runat="server"></mobile:TextBox>
            <mobile:Label ID="Label6" Runat="server">Cargo: </mobile:Label>
            <mobile:TextBox ID="txtCargo" Runat="server"></mobile:TextBox>
            <mobile:Label ID="Label7" Runat="server">DNI: </mobile:Label>
            <mobile:TextBox ID="txtDni" Runat="server"></mobile:TextBox>
            <mobile:Label ID="Label8" Runat="server">Celular: </mobile:Label>
            <mobile:TextBox ID="txtTelefono" Runat="server"></mobile:TextBox>
            <mobile:Label ID="Label9" Runat="server">Direccion: </mobile:Label>
            <mobile:TextBox ID="txtDireccion" Runat="server"></mobile:TextBox>
            <mobile:Label ID="Label10" Runat="server">Email: </mobile:Label>
            <mobile:TextBox ID="txtEmail" Runat="server"></mobile:TextBox> 
        </mobile:Panel>
        <mobile:Label ID="lblMje" Runat="server"></mobile:Label>
        <mobile:Command ID="btnRetornar" Runat="server" OnClick="btnRetornar_Click">Retornar</mobile:Command>
        <mobile:Command ID="btnBorrar" Runat="server" OnClick="btnBorrar_Click">Borrar</mobile:Command>
        <mobile:Command ID="btnActualizar" Runat="server" OnClick="btnActualizar_Click">Registrar</mobile:Command>
    </mobile:Form>
</body>
</html>
