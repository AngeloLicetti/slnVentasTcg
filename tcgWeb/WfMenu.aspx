<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WfMenu.aspx.cs" Inherits="WfMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #33CC33;
            text-align: center;
        }
        .auto-style3 {
            height: 43px;
        }
        .auto-style4 {
            height: 45px;
        }
        .auto-style5 {
            height: 44px;
        }
        .auto-style6 {
            height: 41px;
        }
        .auto-style7 {
            height: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <strong>MENU SISTEMA DE VENTAS TCG</strong></div>
        <br />
        <table class="auto-style1">
            <tr>
                <td style="text-align: center" class="auto-style3">
                    <asp:Button ID="btnListarFacturas" runat="server" OnClick="btnListarFacturas_Click" Text="Listar facturas" />
    </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td style="text-align: center" class="auto-style4">
        
                    <asp:Button ID="Button1" runat="server" Text="Registrar factura" OnClick="Button1_Click" />
        
    </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td style="text-align: center" class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="Actualizar factura" OnClick="Button2_Click" />
    </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td style="text-align: center" class="auto-style6">
                    <asp:Button ID="Button3" runat="server" Text="Eliminar factura" OnClick="Button3_Click" />
    </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td style="text-align: center" class="auto-style7">
                    <asp:Button ID="Button4" runat="server" Text="Consultar factura" OnClick="Button4_Click" />
    </td>
                <td class="auto-style7"></td>
            </tr>
            
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="Button5" runat="server" Text="Salir" OnClick="Button5_Click" />
    </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
