<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfIngreso.aspx.cs" Inherits="wfIngreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2" style="text-align: center">Sistema Ventas TCG</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">Usuario:<asp:TextBox ID="txtusuario" runat="server" style="text-align: left"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">Clave:<asp:TextBox ID="txtclave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                    
                    <asp:Button ID="btnsalir" runat="server" OnClientClick="javascript:window.close();" Text="Salir" />
                </td>
                <td style="text-align: left">
                    <asp:Button ID="btnngresar" runat="server" OnClick="btnngresar_Click" Text="Ingresar" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
