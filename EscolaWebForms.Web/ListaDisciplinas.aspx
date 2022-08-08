<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="ListaDisciplinas.aspx.cs" Inherits="EscolaWebForms.Web.ListaDisciplinas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvDisciplinas" runat="server" OnPageIndexChanging="gvDisciplinas_OnPageIndexChanged" onrowediting="edit_RowEditing" OnRowDeleting="delete_RowDeleting" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
        <%--<div class="col-1"></div>--%>
    </div>
    <div class="row">
        <div class="col-2">
            <br />
            <asp:Button ID="btnNovaDisciplina" runat="server" Text="Nova Disciplina" class="btn btn-primary" OnClick="btnNovaDisciplina_onclick" />
        </div>
    </div>

</asp:Content>
