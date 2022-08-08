<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="EditarNotas.aspx.cs" Inherits="EscolaWebForms.Web.EditarNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">        
        <div class="col-6">
            <label>Nome</label>
            <asp:TextBox class="form-control" ID="tbNome" runat="server" Enabled="false" Width="100%"></asp:TextBox>
        </div>
        <div class="col-4">
            <label>Disciplina</label>
            <asp:TextBox class="form-control" ID="tbDisciplina" runat="server" Enabled="false" Width="100%"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-3">
            <asp:Panel ID="pn1Sem" runat="server" BorderStyle="Ridge" BorderWidth="1">
                <br />
                <div class="row" style="margin-left:5px">
                     <h5>1º Semestre</h5>
                    <div class="col-5">
                        <label>NOTA 1</label>
                        <asp:TextBox class="form-control valid-js-nota" ID="tbN1" runat="server" Width="100%"></asp:TextBox>
                    </div>
                    <div class="col-5">
                        <label>NOTA 2</label>
                        <asp:TextBox class="form-control valid-js-nota" ID="tbN2" runat="server" Width="100%"></asp:TextBox>
                    </div>
                </div>
                <br />
            </asp:Panel>            
        </div>
        <div class="col-3">
            <asp:Panel ID="pn2Sem" runat="server" BorderStyle="Ridge" BorderWidth="1">
                <br />
                <div class="row" style="margin-left:5px">
                    <h5>2º Semestre</h5>
                    <div class="col-5">
                        <label>NOTA 3</label>
                        <asp:TextBox class="form-control valid-js-nota" ID="tbN3" runat="server"  Width="100%"></asp:TextBox>
                    </div>
                    <div class="col-5">
                        <label>NOTA 4</label>
                        <asp:TextBox class="form-control valid-js-nota" ID="tbN4" runat="server" Width="100%"></asp:TextBox>
                    </div>
                </div>
                <br />
            </asp:Panel>            
        </div>
        <div class="col-4">
            <asp:Panel ID="pn3Sem" runat="server" BorderStyle="Ridge" BorderWidth="1">
                <br />
                <div class="row" style="margin-left:5px">
                     <h5>Média</h5>
                    <div class="col-5">
                        <label>Média Atual</label>
                        <asp:TextBox class="form-control" ID="tbMedia" runat="server" Enabled="false" Width="100%"></asp:TextBox>
                    </div>
                    <div class="col-5">
                        <br />
                        <asp:Label ID="lbMediaStatus" runat="server" Text="REPROVADO/APROVADO" ></asp:Label>
                    </div>
                    
                </div>
                <br />
            </asp:Panel>            
        </div> 
        <div class="col-2">
            <asp:TextBox class="form-control" ID="tbId" runat="server" Visible="false"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-1"></div>
        <div class="col-10">
            <br />
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
