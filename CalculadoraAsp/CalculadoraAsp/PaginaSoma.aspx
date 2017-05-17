<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaSoma.aspx.cs" Inherits="CalculadoraAsp.PaginaSoma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSoma" runat="server" Text="+" OnClick="btnSoma_Click" />
            &nbsp;&nbsp;
    <asp:Button ID="btnResultado" runat="server" Text="=" OnClick="btnResultado_Click" />
            <br />
            <asp:Label ID="lblSoma" runat="server" Text=""></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
