<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeFile="Cuentas.aspx.cs" Inherits="Views_Cuentas" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <h2><asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido(a)"></asp:Label></h2><br>
    <br />
    <asp:GridView ID="grdCuentas" HeaderStyle-BackColor="#000066" 
        HeaderStyle-ForeColor="White" CssClass="table table-sm" AlternatingRowStyle-BackColor="LightGray" 
        HeaderStyle-CssClass="thead-dark" runat="server" >
 <!-- <Columns>  
        <asp:BoundField HeaderText="Cuenta" DataField="CUE_COD_CUENTA"/>  
     <asp:BoundField HeaderText="Cliente" DataField="CLI_COD_CLIENTE"/> 
     <asp:BoundField HeaderText="Descripcion" DataField="CUE_DESCRIPCION" />   
     <asp:BoundField HeaderText="Saldo" DataField="CUE_SALDO" DataFormatString="{0:N2}"/>  
     <asp:BoundField HeaderText="Estado" DataField="CUE_ESTADO"/>  
     <asp:BoundField HeaderText="Moneda" DataField="CUE_MONEDA"/>  
</Columns>-->  
    </asp:GridView><br>
</asp:Content>

