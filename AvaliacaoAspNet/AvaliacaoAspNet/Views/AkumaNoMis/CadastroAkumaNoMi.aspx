<%@ Page Title="CadastroAkumaNoMi" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAkumaNoMi.aspx.cs" Inherits="AvaliacaoAspNet.Views.CadastroAkumaNoMi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="style1">Akuma No Mi - Cadastro:</h2>
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
            <td>
                <strong>Habilidade:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtHabilidade" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <strong>Tipo:</strong>
            </td>
            <td>
                <asp:DropDownList ID="ddlTipo" runat="server" OnLoad="ddlTipo_Load"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <strong><asp:Label ID="lblConsumido" runat="server" Text="Consumido:"></asp:Label></strong>
            </td>
            <td>
                <asp:Label ID="lblSim" runat="server" Text="Sim:"></asp:Label>
                <asp:RadioButton ID="rbtSim" runat="server" />
                <asp:Label ID="lblNao" runat="server" Text="Não:"></asp:Label>
                <asp:RadioButton ID="rbtNao" runat="server" />
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
