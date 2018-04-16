<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalProject.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta charset="utf-8" />
    <link href="../css/userlogin.css" rel="stylesheet" />
</head>
<body>

    <h1 class="title">Login</h1>
    <div class="container">

        <form id="form1" runat="server">
            <!-- User name field and it's validator -->

            <asp:TextBox ID="txtID" placeholder="Enter ID" CssClass="text-field first" runat="server"></asp:TextBox>
            <br />

            <!-- Password field, it's validator and forget password link -->
            <asp:TextBox ID="txtPassword" placeholder="Enter password" TextMode="Password" CssClass="text-field" runat="server"></asp:TextBox>

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-login" OnClick="btnLogin_Click" />
            <br />

            <asp:Label ID="status" runat="server" CssClass="status-report"></asp:Label>
        </form>


    </div>
</body>
</html>
