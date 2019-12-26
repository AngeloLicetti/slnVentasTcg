<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfDVentaAdi.aspx.cs" Inherits="wfDVentaAdi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td colspan="3" class="text-center"><strong>REGISTRAR DVENTA</strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Codigo de DVenta:</td>
            <td colspan="2">
                <asp:TextBox ID="txtCodigo" runat="server" Width="379px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Cantidad:</td>
            <td colspan="2">
                <asp:TextBox ID="txtCantidad" runat="server" Width="381px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Precio:</td>
            <td colspan="2" class="auto-style6">
                <asp:TextBox ID="txtPrecio" runat="server" Width="381px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">VentaId:</td>
            <td colspan="2">
                <asp:DropDownList ID="ddlVenta" runat="server" Height="17px" Width="389px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Articulo:</td>
            <td colspan="2">
                <asp:DropDownList ID="ddlArticulo" runat="server" Height="17px" Width="390px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="3" class="text-center">
                <asp:Label ID="lblMje" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>

                &nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
            </td>
            <td>
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

