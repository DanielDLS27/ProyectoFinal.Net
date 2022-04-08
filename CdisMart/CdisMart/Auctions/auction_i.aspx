<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="auction_i.aspx.cs" Inherits="CdisMart.Auctions.auction_i" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" ID="lblUser"></asp:Label>

    <table>
        <tr>
            <td>
                Producto: 
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtProductName"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 Description: 
             </td>
            <td>
                <asp:TextBox runat="server" ID="txtDes"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 Fecha de inicio: 
             </td>
            <td>
                <asp:TextBox runat="server" ID="txtInicio"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 Fecha de fin: 
             </td>
            <td>
                <asp:TextBox runat="server" ID="txtFin"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button runat="server" Text="Agregar Subasta" OnClick="Unnamed1_Click"/>
            </td>
        </tr>
    </table>

</asp:Content>
