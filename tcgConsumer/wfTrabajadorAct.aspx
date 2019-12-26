<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfTrabajadorAct.aspx.cs" Inherits="wfTrabajadorAct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
         <table class="auto-style2">
             <tr>
                <td colspan="3" class="text-center"><strong>ACTUALIZAR Trabajador</strong></td>
             </tr>
             <tr>
                <td class="auto-style3">Codigo de Trabajador:</td>
                <td colspan="2">
                   <asp:TextBox ID="txtCodigo" runat="server" Width="305px"></asp:TextBox>
                </td>
            </tr>
         </table>
    </div>
    <div runat="server" id="divOcultar" style="width: 477px">
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Apellidos:</td>
                <td colspan="2" style="width: 440px">
                    <asp:TextBox ID="txtApellidos" runat="server" Width="381px"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td class="auto-style5">Nombres:</td>
                <td colspan="2" class="auto-style6" style="width: 440px">
                    <asp:TextBox ID="txtNombres" runat="server" Width="381px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Cargo:</td>
                <td colspan="2" class="auto-style6" style="width: 440px">
                    <asp:TextBox ID="txtCargo" runat="server" Width="381px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">DNI:</td>
                <td colspan="2" class="auto-style6" style="width: 440px">
                    <asp:TextBox ID="txtDni" runat="server" Width="381px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Telefono:</td>
                <td colspan="2" style="width: 440px">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="385px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Direccion:</td>
                <td colspan="2" style="width: 440px">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="385px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td colspan="2" style="width: 440px">
                    <asp:TextBox ID="txtEmail" runat="server" Width="385px"></asp:TextBox>
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
            <td style="width: 311px">
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/>
            </td>
        </tr>
         </table>
    </div>
</asp:Content>

