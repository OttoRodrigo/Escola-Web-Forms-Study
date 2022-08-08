<%@ Page Title="" Language="C#" MasterPageFile="~/EscolaMaster.Master" AutoEventWireup="true" CodeBehind="ListaNotas.aspx.cs" Inherits="EscolaWebForms.Web.ListaNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvNotas" runat="server" OnPageIndexChanging="gvAlunos_OnPageIndexChanged" onrowediting="edit_RowEditing" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
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
            <asp:Button ID="btnNovaNota" runat="server" Text="Novo Registro de Notas" class="btn btn-primary" OnClick="btnNovaNota_onclick" />
        </div>
    </div>

</asp:Content>
