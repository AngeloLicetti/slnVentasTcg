<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfFacturaLis.aspx.cs" Inherits="wfFacturaLis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 238px;
        }
        #form1 {
            width: 908px;
        }
        .auto-style3 {
            width: 232px;
        }
        .auto-style4 {
            width: 232px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>SISTEMA DE VENTAS TCG</strong></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>LISTADO DE VENTAS</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:GridView ID="gvLista" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: center">
                    <asp:Button ID="btnCancelar" runat="server"  Text="CANCELAR" OnClick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
