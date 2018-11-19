<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeFile="Transferencias.aspx.cs" Inherits="Views_Transferencias" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label5" runat="server" Text="Transferencias entre cuentas" />
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td style="height: 26px; width: 190px">
                &nbsp;</td>
            <td style="height: 26px">
                &nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px; width: 190px">
                &nbsp;</td>
            <td style="height: 26px">
                &nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px; width: 190px">
                <asp:Label ID="Label1" runat="server" Text="Origen"></asp:Label>
            </td>
            <td style="height: 26px">
                <asp:DropDownList ID="ddCuentaOrigen" runat="server" AutoPostBack="false">
                </asp:DropDownList>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 190px">
                <asp:Label ID="Label2" runat="server" Text="Destino"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddCuentaDestino" runat="server" AutoPostBack="false" >
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 190px">
                <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 190px">
                <asp:Label ID="Label4" runat="server" Text="Monto"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:LinkButton type="button" CssClass="btn  btn-primary" ID="btnEnviar"  runat="server" Text="<span aria-hidden='true' class='glyphicon glyphicon-envelope'></span> Enviar transferencia" OnClick="btnEnviar_Click" />
    <br />
    <asp:Label ID="lblEstado" runat="server"></asp:Label>
      <asp:GridView ID="grdTransferencias" OnRowDataBound="grdTransferencias_RowDataBound" HeaderStyle-BackColor="#000066" 
        HeaderStyle-ForeColor="White" CssClass="table table-sm" AlternatingRowStyle-BackColor="LightGray" 
        HeaderStyle-CssClass="thead-dark" runat="server" >
    </asp:GridView><br>
</asp:Content>

