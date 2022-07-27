<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="CriarAluno.aspx.cs" Inherits="EscolaWebForms.Web.CriarAluno" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <div class="row">
        <div class="col-2">
            <label>CPF</label>
            <asp:TextBox class="form-control valid-js-cpf" ID="tbCpf" runat="server" type="number"></asp:TextBox>
        </div>
        <div class="col-10">
            <label>Nome</label>
            <asp:TextBox class="form-control" ID="tbNome" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-2">
            <label>CEP</label>
            <asp:TextBox class="form-control valid-js-cep" ID="tbCep" runat="server" AutoCompleteType="BusinessState"></asp:TextBox>
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
            <asp:Button ID="btnCriar" class="btn btn-success" runat="server" Text="Criar" Width="100%" OnClick="btnCriar_OnClick" />
        </div>
    </div>
    <div class="row">
        <div class="col-1">        
            <asp:Button ID="btnVoltar" class="btn btn-link" runat="server" Text="Voltar" OnClick="btnVoltar_OnClick" />
        </div>
    </div>

    <script type="text/javascript" src="Comum/comumJs.js"></script>
</asp:Content>
