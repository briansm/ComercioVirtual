<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 286px; width: 427px; margin-right: 418px;" align="center">
        
        &nbsp;
        
    
        
    
        <table style="width:100%;">
            <tr>
                <td style="width: 20px; height: 48px;">
                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td align="right" style="width: 26px; height: 48px;">
                    <asp:TextBox ID="TextBox1" runat="server" Width="171px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 20px">
&nbsp;Contraseña</td>
                <td align="right" style="width: 26px">
                    <asp:TextBox ID="TextBox2" TextMode="password" runat="server" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 20px">
                    &nbsp;</td>
                <td align="right" style="width: 26px">
                    <asp:DropDownList ID="droprol" runat="server" Height="16px" Width="139px">
                        <asp:ListItem>Administrador</asp:ListItem>
                        <asp:ListItem>Gerente</asp:ListItem>
                        <asp:ListItem>Socio</asp:ListItem>
                        <asp:ListItem>Comerciante</asp:ListItem>
                        <asp:ListItem>Proveedor</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 20px; height: 32px">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Registrar" />
                </td>
                <td align="right" style="height: 32px; width: 26px">
                    <asp:Button ID="Button1" runat="server" Text="Ingresar" 
                        onclick="Button1_Click" />
                </td>
            </tr>
        </table>
        
    
        
    
    </div>
</asp:Content>

