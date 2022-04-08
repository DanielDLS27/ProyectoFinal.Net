<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CdisMart.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                 <tr>
                    <td>Nombre de usuario:</td>
                    <td>
                        <asp:TextBox ID="txtUsuarioName" runat="server" Text="DanielDLS2"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contraseña:</td>
                    <td>
                        <asp:TextBox ID="txtContraseña" TextMode="Password" runat="server" Text="1234"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                    </td>
                </tr>
            </table>

            <tr>
                 <td></td>
                 <td>
                     <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" />
                 </td>
            </tr>

        </div>
    </form>
</body>
</html>
