<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="cpFacturaLis.aspx.cs" Inherits="cpFacturaLis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>LISTADO DE VENTAS</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:GridView ID="gvLista" runat="server" style="color: #000000">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: center">
                    <asp:Button ID="btnSalir" runat="server"  Text="SALIR" OnClick="btnSalir_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

