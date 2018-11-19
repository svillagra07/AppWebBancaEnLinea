<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.master" AutoEventWireup="true" CodeFile="Cuentas.aspx.cs" Inherits="Views_Cuentas" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <h2><asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido(a)"></asp:Label></h2><br>
    <br />
    <asp:GridView ID="grdCuentas" HeaderStyle-BackColor="#000066"  
        HeaderStyle-ForeColor="White" CssClass="table table-sm" AlternatingRowStyle-BackColor="LightGray" 
        HeaderStyle-CssClass="thead-dark" runat="server" AutoGenerateColumns="false" OnRowDataBound="grdCuentas_RowDataBound" >
    </asp:GridView><br>
</asp:Content>

