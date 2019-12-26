<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfFacturaAct.aspx.cs" Inherits="wfFacturaAct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 85%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 383px;
        }
        .auto-style4 {
            width: 383px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 383px;
            text-align: center;
        }
        .auto-style10 {
            text-align: center;
            width: 588px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
            color: #00CC00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>SISTEMA DE VENTAS TCG</strong></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>ACTUALIZACION DE VENTAS</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">Codigo de venta:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
    </div>
    <div runat="server" id="divOcultar">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Comentario:</td>
                <td colspan="2" class="auto-style2">
                    <asp:TextBox ID="txtComentario" runat="server" Width="1256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Fecha:</td>
                <td class="auto-style5">Cliente:</td>
                <td class="auto-style5">Trabajador:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Calendar ID="cldFecha" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlCliente" runat="server" Height="16px" style="text-align: center" Width="300px">
                    </asp:DropDownList>
                </td>
                <td style="text-align: center">&nbsp;
                    <asp:DropDownList ID="ddlTrabajador" runat="server" Height="16px" style="text-align: center" Width="342px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <table>
            <tr>
                <td class="auto-style10" colspan="3">
                    <asp:Label ID="lblMje"  runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnRetornar" runat="server" Text="RETORNAR" OnClick="btnRetornar_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" OnClick="btnBorrar_Click" />
                </td>
                <td style="text-align: center">
                    <asp:Button ID="btnActualizar" runat="server" Text="ACTUALIZAR" OnClick="btnActualizar_Click"  />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
