<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="auction_s.aspx.cs" Inherits="CdisMart.Auctions.auction_s" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" ID="lblUser"></asp:Label>

    <asp:GridView ID="grd_subastas" AutoGenerateColumns="false" runat="server" OnRowCommand="grd_subastas_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="# de la subasta" DataField="AuctionId" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton runat="server" Text='<%# Eval("ProductName") %>' CommandName="link_titulo" CommandArgument='<%# Eval("AuctionId") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Descripcion del producto" DataField="Description" />
            <asp:BoundField HeaderText="Fecha de inicio de la subasta" DataField="StartDate" DataFormatString="{0:dd/MM/yyyy}"/>
            <asp:BoundField HeaderText="Fecha de fin de la subasta" DataField="EndDate" DataFormatString="{0:dd/MM/yyyy}"/>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btn_historial" runat="server" Text="Historial" CommandName="btn_historial" CommandArgument='<%# Eval("AuctionId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

           
        </Columns>
    </asp:GridView>

</asp:Content>
