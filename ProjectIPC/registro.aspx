<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="registro.aspx.cs" Inherits="registro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table style="width:100%;">
        <tr>
            <td style="width: 188px">
                Nombre</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                Apellido</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                Direccion</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                Telefono</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                No.Cuenta</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                Usuario(correo electronico)</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                Contraseña</td>
            <td style="width: 179px">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 188px">
                &nbsp;</td>
            <td style="width: 179px">
                <asp:Button ID="Button1" runat="server" Text="Registrar" 
                    onclick="Button1_Click" />
            </td>
            <td style="width: 196px">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>