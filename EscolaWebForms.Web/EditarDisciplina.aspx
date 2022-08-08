<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="EditarDisciplina.aspx.cs" Inherits="EscolaWebForms.Web.EditarDisciplina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">       
        <div class="col-12">
            <label>Nome</label>
            <asp:TextBox class="form-control" ID="tbNome" runat="server"></asp:TextBox>
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
        <div class="col-1">
            <asp:TextBox class="form-control" ID="tbId" runat="server" style="visibility:hidden"></asp:TextBox>        
        </div>
    </div>

    <script type="text/javascript" src="Comum/comumJs.js"></script>
</asp:Content>
