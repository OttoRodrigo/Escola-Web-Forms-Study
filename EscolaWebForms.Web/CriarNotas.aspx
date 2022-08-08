<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="CriarNotas.aspx.cs" Inherits="EscolaWebForms.Web.CriarNotas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <label>Aluno</label>
            <asp:DropDownList ID="dpAluno" runat="server" Width="100%" class="btn btn-primary dropdown-toggle"></asp:DropDownList>
        </div>
        <div class="col-4">            
            <label>Disciplina</label>
            <asp:DropDownList ID="dpDisciplina" runat="server" Width="100%" class="btn btn-primary dropdown-toggle"></asp:DropDownList>
        </div>
    </div>    
    <div class="row">
        <div class="col-1"></div>
        <div class="col-10">
            <br />
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
