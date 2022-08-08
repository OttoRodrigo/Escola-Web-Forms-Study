<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EscolaWebForms.Web.Login" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="Content\bootstrap.css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            
            <div class="col-4"></div>
            <div class="col-4 border border-secondary rounded" style="margin-top:10px">
                <br />
                <h3>LOGIN</h3>
                <br />
                <div class="form-group">
                    <label>Usuario</label>
                    <asp:TextBox class="form-control" ID="tbUsuario" runat="server"></asp:TextBox> 
                </div>
                <div class="form-group">
                    <label>Senha</label>
                    <asp:TextBox class="form-control" ID="tbSenha" runat="server" type="password"></asp:TextBox>
                </div>
                <br />
                <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <br />
                <label style="visibility:hidden"></label>
            </div>            
            <div class="col-4"></div>
        </div>
        <script type="text/javascript" src="Comum/comumJs.js"></script>
    </form>
</body>
</html>
