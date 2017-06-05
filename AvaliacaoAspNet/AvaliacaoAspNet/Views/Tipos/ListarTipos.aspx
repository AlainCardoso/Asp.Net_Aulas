<%@ Page Title="ListaTipos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarTipos.aspx.cs" Inherits="AvaliacaoAspNet.Views.Tipos.ListarTipos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div aligh="center">
        <h3>Lista de Tipos.</h3>
        <asp:GridView ID="gvwListarTipos" runat="server"></asp:GridView>
    </div>
</asp:Content>
