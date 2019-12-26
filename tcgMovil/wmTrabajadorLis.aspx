<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wmTrabajadorLis.aspx.cs" Inherits="wmTrabajadorLis" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<body>
    <mobile:Form id="fmPrincipal" runat="server">
        <mobile:Label ID="Label1" Runat="server">SISTEMA DE VENTAS TCG</mobile:Label>
        <br />
        <mobile:Label ID="Label2" Runat="server">LISTAR TRABAJADORES</mobile:Label>
        <br />
        <mobile:ObjectList ID="gvLista" Runat="server" ></mobile:ObjectList>
        
        <mobile:Command ID="btnRetornar" Runat="server" OnClick="btnRetornar_Click">Retornar</mobile:Command>
    </mobile:Form>
</body>
</html>

