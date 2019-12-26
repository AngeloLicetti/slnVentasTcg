<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfDVentaEli.aspx.cs" Inherits="wfDVentaEli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
         <table class="auto-style2">
             <tr>
                <td colspan="3" class="text-center"><strong>ELIMINAR DVENTA</strong></td>
             </tr>
             <tr>
                <td class="auto-style3">Codigo de DVenta:</td>
                <td colspan="2">
                   <asp:TextBox ID="txtCodigo" runat="server" Width="333px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
         </table>
    </div>
    <div runat="server" id="divOcultar">
        <table class="auto-style2">
            <tr>
            <td class="auto-style3">Cantidad:</td>
            <td colspan="2">
                <asp:TextBox ID="txtCantidad" runat="server" Width="381px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Precio:</td>
            <td colspan="2" class="auto-style6">
                <asp:TextBox ID="txtPrecio" runat="server" Width="381px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">VentaId:</td>
            <td colspan="2">
                <asp:DropDownList ID="ddlVenta" runat="server" Height="17px" Width="389px" Enabled="False">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Articulo:</td>
            <td colspan="2">
                <asp:DropDownList ID="ddlArticulo" runat="server" Height="17px" Width="390px" Enabled="False">
                </asp:DropDownList>
            </td>
        </tr>
         </table>
    </div>
    <div>
        <table class="auto-style2">
            <tr>
            <td colspan="3" class="text-center">
                <asp:Label ID="lblMje" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>

                <asp:Button ID="btnRetornar" runat="server" Text="Retornar" OnClick="btnRetornar_Click" />

            </td>
            <td class="auto-style3">
                <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click"/>
            </td>
            <td style="width: 314px">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
            </td>
        </tr>
         </table>
    </div>
</asp:Content>

