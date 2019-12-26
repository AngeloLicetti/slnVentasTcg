<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfClienteLis.aspx.cs" Inherits="wfClienteLis" %>

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
                <td class="auto-style4">Listado de clientes</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:GridView ID="gvLista" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: center">
                    <asp:Button ID="btnCancelar" runat="server" OnClientClick="script: window.close();" Text="CANCELAR" />
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>