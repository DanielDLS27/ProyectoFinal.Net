<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="usuario_i.aspx.cs" Inherits="CdisMart.Usuarios.usuario_i" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
         <tr>
            <td>Nombre Completo: </td>
            <td>
                <asp:TextBox ID="txtNombre" MaxLength="50" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_nombre" runat="server" ControlToValidate="txtNombre"
                    ErrorMessage="El nombre es requerido" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Correo Electronico: </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="El Email es requerido" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Usuario: </td>
            <td>
                <asp:TextBox ID="txtUsuarioName" MaxLength="10" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_usuarioName" runat="server" ControlToValidate="txtUsuarioName"
                    ErrorMessage="El usuario es requerido" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Contraseña: </td>
            <td>
                <asp:TextBox ID="txtContraseña" MaxLength="10" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_contraseña" runat="server" ControlToValidate="txtContraseña"
                    ErrorMessage="La contraseña es requerida" InitialValue="0" Display="Dynamic" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td>Confirmar Contraseña: </td>
            <td>
                <asp:TextBox ID="txtContraseña2" MaxLength="10" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtContraseña2"
                    ErrorMessage="La contraseña no coincide" Display="Dynamic" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" ValidationGroup="vlg1" OnClick="btnAgregar_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
