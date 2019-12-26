<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="cpFacturaEli.aspx.cs" Inherits="cpFacturaEli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 620px;
        }
        .auto-style4 {
            width: 555px;
        }
        .auto-style5 {
            width: 554px;
        }
        .auto-style6 {
            width: 430px;
        }
        .auto-style7 {
            width: 412px;
        }
        .auto-style8 {
            width: 282px;
        }
        .auto-style9 {
            color: #00FF00;
            width: 508px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>ELIMINACION DE VENTAS</strong></td>
            </tr>
            <tr>
                <td class="auto-style8">Codigo de venta:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
        </table>
    </div>
    <div runat="server" id="divOcultar">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Comentario:</td>
                <td colspan="2" class="auto-style2">
                    <asp:TextBox ID="txtComentario" runat="server" Width="1256px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Fecha:</td>
                <td class="auto-style7">Cliente:</td>
                <td class="auto-style5">Trabajador:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Calendar ID="cldFecha" runat="server" Enabled="False"></asp:Calendar>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtCliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td style="text-align: center">&nbsp;
                    <asp:TextBox ID="txtTrabajador" runat="server" Enabled="False"></asp:TextBox>
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
                    <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click"/>
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>

