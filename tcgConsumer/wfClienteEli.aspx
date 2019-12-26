<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfClienteEli.aspx.cs" Inherits="wfClienteEli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
         <table class="auto-style2">
             <tr>
                <td colspan="3" class="text-center"><strong>ELIMINAR CLIENTE</strong></td>
             </tr>
             <tr>
                <td class="auto-style3">Codigo de Cliente:</td>
                <td colspan="2">
                   <asp:TextBox ID="txtCodigo" runat="server" Width="333px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
         </table>
    </div>
    <div runat="server" id="divOcultar">
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Apellidos:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtApellidos" runat="server" Width="381px" Enabled="False"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td class="auto-style5">Nombres:</td>
                <td colspan="2" class="auto-style6">
                    <asp:TextBox ID="txtNombres" runat="server" Width="381px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Telefono:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="385px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Direccion:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="385px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtEmail" runat="server" Width="385px" Enabled="False"></asp:TextBox>
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

