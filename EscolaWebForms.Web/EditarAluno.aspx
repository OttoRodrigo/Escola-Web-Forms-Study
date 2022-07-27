<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="EditarAluno.aspx.cs" Inherits="EscolaWebForms.Web.EditarAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="col-2">
            <label>CPF</label>
            <asp:TextBox class="form-control" ID="tbCpf" runat="server" type="number" Enabled="false" Width="90%"></asp:TextBox>
        </div>
        <div class="col-10">
            <label>Nome</label>
            <asp:TextBox class="form-control" ID="tbNome" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-2">
            <label>CEP</label>
            <asp:TextBox class="form-control valid-js-cep" ID="tbCep" runat="server" type="number"></asp:TextBox>
        </div>
        <div class="col-2">
            <label>Número</label>
            <asp:TextBox class="form-control" ID="tbNum" runat="server" type="number"></asp:TextBox>
        </div>
        <div class="col-8">
            <label>Complemento</label>
            <asp:TextBox class="form-control" ID="tbComp" runat="server"></asp:TextBox>
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col-1"></div>
        <div class="col-10">
            <asp:Button ID="btnEditar" class="btn btn-success" runat="server" Text="Salvar" Width="100%" OnClick="btnEditar_OnClick" />
        </div>
    </div>
    <div class="row">
        <div class="col-1">        
            <asp:Button ID="btnVoltar" class="btn btn-link" runat="server" Text="Voltar" OnClick="btnVoltar_OnClick" />
        </div>
    </div>

    <script type="text/javascript" src="Comum/comumJs.js"></script>
</asp:Content>
