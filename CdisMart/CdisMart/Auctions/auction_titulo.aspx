<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="auction_titulo.aspx.cs" Inherits="CdisMart.Auctions.auction_titulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" ID="lblUser"></asp:Label>

    <table>
        <tr>
            <td>
                Nombre del producto:
            </td>
            <td>
                <asp:Label runat="server" ID="lblProductName"></asp:Label>
            </td>
        </tr>
       <tr>
            <td>
                Descripcion:
            </td>
            <td>
                <asp:Label runat="server" ID="lblDescription"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Fecha de incio:
            </td>
            <td>
                <asp:Label runat="server" ID="lblStart"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Fecha de fin:
            </td>
            <td>
                <asp:Label runat="server" ID="lblEnd"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Oferta mas alta:
            </td>
            <td>
                <asp:Label runat="server" ID="lblHigh"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Ganador:
            </td>
            <td>
                <asp:Label runat="server" ID="lblWinner"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                ID Usuario:
            </td>
            <td>
                <asp:Label runat="server" ID="lblUserId"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
