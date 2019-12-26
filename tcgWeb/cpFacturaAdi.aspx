<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="cpFacturaAdi.aspx.cs" Inherits="cpFacturaAdi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>REGISTRO DE VENTAS</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">Codigo de venta:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
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
            <tr>
                <td class="auto-style10" colspan="3">
                    <asp:Label ID="lblMje"  runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnRetornar" runat="server" Text="SALIR" OnClick="btnRetornar_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" OnClick="btnBorrar_Click" />
                </td>
                <td style="text-align: center">
                    <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR" OnClick="btnRegistrar_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

