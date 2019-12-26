<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<body>
    <mobile:Form id="fmPrincipal" runat="server">
        <mobile:Label ID="Label1" Runat="server">SISTEMA DE VENTAS TCG</mobile:Label>
        <br />
        <mobile:List ID="lstIdiomas" Runat="server" OnItemCommand="lstIdiomas_ItemCommand">
            <Item Text="Registrar trabajador" Value="Espaniol" />
            <Item Text="Actualizar trabajador" Value="Frances" />
            <Item Text="Eliminar trabajador" Value="Aleman" />
            <Item Text="Consultar trabajador" Value="Noruego" />
            <Item Text="Listar trabajador" Value="Portugues" />
            <Item Text="Salir" Value="Salir" />
        </mobile:List>

    </mobile:Form>
</body>
</html>
