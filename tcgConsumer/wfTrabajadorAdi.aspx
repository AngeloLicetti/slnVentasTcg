<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfTrabajadorAdi.aspx.cs" Inherits="wfTrabajadorAdi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td colspan="3" class="text-center"><strong>REGISTRAR TRABAJADOR</strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Codigo de Trabajador:</td>
            <td colspan="2">
                <asp:TextBox ID="txtCodigo" runat="server" Width="379px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellidos:</td>
            <td colspan="2">
                <asp:TextBox ID="txtApellidos" runat="server" Width="381px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Nombres:</td>
            <td colspan="2" class="auto-style6">
                <asp:TextBox ID="txtNombres" runat="server" Width="381px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Cargo:</td>
            <td colspan="2" class="auto-style6">
                <asp:TextBox ID="txtCargo" runat="server" Width="381px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">DNI:</td>
            <td colspan="2" class="auto-style6">
                <asp:TextBox ID="txtDni" runat="server" Width="381px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Telefono:</td>
            <td colspan="2">
                <asp:TextBox ID="txtTelefono" runat="server" Width="385px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Direccion:</td>
            <td colspan="2">
                <asp:TextBox ID="txtDireccion" runat="server" Width="385px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email:</td>
            <td colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" Width="385px"></asp:TextBox>
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

