<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="cpFacturaAct.aspx.cs" Inherits="cpFacturaAct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 579px;
        }
        .auto-style4 {
            width: 471px;
        }
        .auto-style5 {
            width: 462px;
        }
        .auto-style6 {
            width: 436px;
        }
        .auto-style7 {
            width: 243px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table class="auto-style1"  style="column-width: 800px">
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
                <td class="auto-style7">Cliente:</td>
                <td class="auto-style5">Trabajador:</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Calendar ID="cldFecha" runat="server"></asp:Calendar>
                </td>
                <td class="auto-style7">
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
</asp:Content>

