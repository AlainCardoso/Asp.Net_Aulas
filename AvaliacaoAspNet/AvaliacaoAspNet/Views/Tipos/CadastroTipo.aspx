<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroTipo.aspx.cs" Inherits="AvaliacaoAspNet.Views.Tipos.CadastroTipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="style1">Tipos de Akuma No Mi - Cadastro:</h2>
    <table>
        <tr>
            <td>
                <strong>Nome:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <strong>Descrição:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Salvar" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
