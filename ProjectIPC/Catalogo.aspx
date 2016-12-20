<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Catalogo.aspx.cs" Inherits="Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="background-color: #FFCC00; height: 615px; font-family: 'Arial Narrow'; font-size: 20px;">
        <p style="margin-left: 40px; color: #000000;">
            PRODUCTOS DE INTERES</p>
        <p style="margin-left: 40px; color: #000000;">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Cargar Productos" />
        </p>
        <p style="margin-left: 40px; color: #000000;">
            &nbsp;</p>
        <p style="margin-left: 40px; color: #000000;">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
</div>
</asp:Content>

