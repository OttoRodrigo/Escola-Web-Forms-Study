<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="ExcluirDisciplina.aspx.cs" Inherits="EscolaWebForms.Web.ExcluirDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="col-2">
            <label>Id</label>
            <asp:TextBox class="form-control" ID="tbId" runat="server" type="number" Enabled="false"></asp:TextBox>
        </div>
        <div class="col-10">
            <label>Nome</label>
            <asp:TextBox class="form-control" ID="tbNome" runat="server" Enabled="false" Width="100%"></asp:TextBox>
        </div>
    </div>    
    <div class="row">
        <div class="col-1"></div>
        <div class="col-10">
            <br />
            <asp:Button ID="btnExcluir" class="btn btn-danger" runat="server" Text="Excluir" Width="100%" OnClick="btnExcluir_OnClick" />
        </div>
    </div>
    <div class="row">
        <div class="col-1">        
            <asp:Button ID="btnVoltar" class="btn btn-link" runat="server" Text="Voltar" OnClick="btnVoltar_OnClick" />
        </div>
    </div>
</asp:Content>
