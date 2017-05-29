<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adicionar.aspx.cs" Inherits="Aula2405_EF_MF.Views.Categorias.Adicionar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Adicionar Categoria</h1>
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>

    <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
</asp:Content>
