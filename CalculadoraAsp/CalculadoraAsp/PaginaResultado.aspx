<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaResultado.aspx.cs" Inherits="CalculadoraAsp.PaginaResultado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblSoma" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblSubtracao" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblMultiplicacao" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblDivisao" runat="server" Text=""></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
