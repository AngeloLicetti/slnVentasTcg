<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfTrabajadorLis.aspx.cs" Inherits="wfTrabajadorLis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table>
        <tr>
                <td colspan="3" style="text-align: center" class="auto-style11"><strong>LISTADO DE TRABAJADORES</strong><asp:GridView ID="gvLista" runat="server" style="color: #000000">
                    </asp:GridView>
                </td>
            </tr>
    </table>
</asp:Content>

